using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class SongsManager : MonoBehaviour
{
	public string ServerURL;

    public RectTransform ScrollContents;
    public InputField InputField;

	[Header("Settings Panel")]
	public RectTransform SettingsPanel;
	public InputField ServerUrlInputField;
	public Toggle AutoDownloadToggle;
	public Toggle AdultSongsToggle;

	[Header("Custom Song")]
	public InputField TitelInput;
	public InputField TextInput;
	public InputField MelodyInput;
	public InputField LyricsInput;

	public InputField ImportInput;

	[Header("Song Panel")]
	public RectTransform SongPanel;
	public Text SongTitle;
    public Text SongText;
    public Text SongMelody;
    public Text SongLyrics;
    public Text SongNote;

	public Button DeleteButton;
	public Button ShareButton;
	
	[Header("Prefabs")]
	public GameObject ButtonPrefab, SectionPrefab;

	[HideInInspector]
	public Song CurrentSong;

	[Header("Dialogs")]
	public GameObject DeleteConfirmation;
	public GameObject SharePanel;

	private List<ListItemSong> _allListItems = new List<ListItemSong>();
	private Dictionary<Songs.SongType, ListItemSection> _allSections = new Dictionary<Songs.SongType, ListItemSection>();
	
	// Use this for initialization
	void Start ()
    {
		if (PlayerPrefs.HasKey("ServerURL"))
		{
			ServerURL = PlayerPrefs.GetString("ServerURL");
			ServerUrlInputField.text = ServerURL;
		}

		Populate();

		if (PlayerPrefs.HasKey("AutoDownload") && PlayerPrefs.GetInt("AutoDownload") != 0)
		{
			AutoDownloadToggle.isOn = true;
		}

		if (PlayerPrefs.HasKey("AdultSongs") && PlayerPrefs.GetInt("AdultSongs") != 0)
		{
			AdultSongsToggle.isOn = true;
		}

		if (PlayerPrefs.HasKey("CustomSongs"))
		{
			var customSongs = (JsonHelper.FromJson<Song>(PlayerPrefs.GetString("CustomSongs")));

			if (customSongs.Length > 0)
			{
				AddSection(Songs.SongType.Egna);

				foreach (var s in customSongs)
				{
					AddSong(Songs.SongType.Egna, s);
				}
			}
		}
	}
	
	public void Populate()
	{
		AddSongsByType(Songs.SongType.Klassiskt);
		AddSongsByType(Songs.SongType.Öl);
		AddSongsByType(Songs.SongType.Vin);
		AddSongsByType(Songs.SongType.Nubbe);
		AddSongsByType(Songs.SongType.Punsch);
		AddSongsByType(Songs.SongType.Kräftor);
		AddSongsByType(Songs.SongType.Bakfylla);
		AddSongsByType(Songs.SongType.Nördigt);
		AddSongsByType(Songs.SongType.Odödliga);
	}

	public void ServerURLChanged()
	{
		ServerURL = ServerUrlInputField.text;
		PlayerPrefs.SetString("ServerURL", ServerURL);
	}

	public void AutoDownloadChanged()
	{
		PlayerPrefs.SetInt("AutoDownload", AutoDownloadToggle.isOn ? 1 : 0);

		if(AutoDownloadToggle.isOn && !_allSections.ContainsKey(Songs.SongType.Nedladdade))
		{
			StartCoroutine(DownloadSongs());
		}
	}
	
	public void AdultSongsChanged()
	{
		PlayerPrefs.SetInt("AdultSongs", AdultSongsToggle.isOn ? 1 : 0);

		if (AdultSongsToggle.isOn && !_allSections.ContainsKey(Songs.SongType.Ekivoka))
		{
			AddSongsByType(Songs.SongType.Ekivoka);
		}
	}

	void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SongPanel.gameObject.SetActive(false);
			SettingsPanel.gameObject.SetActive(false);
			DeleteConfirmation.SetActive(false);
			SharePanel.SetActive(false);
		}
    }

	public void ShowSettingsPanel()
	{
		SettingsPanel.gameObject.SetActive(true);
	}

	public void SaveCustomSong()
	{
		if (LyricsInput.text != "")
		{
			Song song = new Song(TitelInput.text, MelodyInput.text != "" ? "Melodi: " + MelodyInput.text : "", TextInput.text != "" ? "Text: " + TextInput.text : "", LyricsInput.text, "");
			AddSongToCustomSongs(song);
		}

		if(ImportInput.text != "")
		{
			byte[] bytes = Convert.FromBase64String(ImportInput.text);
			var json = Encoding.UTF8.GetString(bytes);
			Song song = JsonUtility.FromJson<Song>(json);
			AddSongToCustomSongs(song);
		}

		TitelInput.text = "";
		TextInput.text = "";
		MelodyInput.text = "";
		LyricsInput.text = "";
		ImportInput.text = "";
	}

	public void AddSongToCustomSongs(Song song)
	{
		var customSongs = new List<Song>();

		if (PlayerPrefs.HasKey("CustomSongs"))
		{
			customSongs.AddRange(JsonHelper.FromJson<Song>(PlayerPrefs.GetString("CustomSongs")));
		}

		foreach(var s in customSongs)
		{
			if (s.Lyrics.Equals(song.Lyrics))
				return;
		}

		customSongs.Add(song);

		PlayerPrefs.SetString("CustomSongs", JsonHelper.ToJson<Song>(customSongs.ToArray()));
		RefreshCustomSongs(customSongs);
	}

	private void RefreshCustomSongs(List<Song> customSongs)
	{
		if (_allSections.ContainsKey(Songs.SongType.Egna))
		{
			Destroy(_allSections[Songs.SongType.Egna].gameObject);
			_allSections.Remove(Songs.SongType.Egna);

			var removed = new List<ListItemSong>();
			foreach (var li in _allListItems)
			{
				if (li.Song.Type == Songs.SongType.Egna)
				{
					Destroy(li.gameObject);
					removed.Add(li);
				}
			}

			foreach(var remove in removed)
			{
				_allListItems.Remove(remove);
			}
		}

		if (customSongs.Count > 0)
		{
			AddSection(Songs.SongType.Egna);

			foreach (var s in customSongs)
			{
				AddSong(Songs.SongType.Egna, s);
			}
		}
	}
	
	public void DeleteCustomSong()
	{
		if (PlayerPrefs.HasKey("CustomSongs"))
		{
			var customSongs = new List<Song>(JsonHelper.FromJson<Song>(PlayerPrefs.GetString("CustomSongs")));
			customSongs.RemoveAll(g => g.Lyrics.Equals(CurrentSong.Lyrics) && g.Title.Equals(CurrentSong.Title));
			PlayerPrefs.SetString("CustomSongs", JsonHelper.ToJson<Song>(customSongs.ToArray()));
			RefreshCustomSongs(customSongs);

			SongPanel.gameObject.SetActive(false);
		}
	}

	public void ClearCustomSong()
	{
		TitelInput.text = "";
		TextInput.text = "";
		MelodyInput.text = "";
		LyricsInput.text = "";
	}

	public void Clear()
	{
		InputField.text = "";
		Search();
	}

    public void Search()
    {
        var searchString = InputField.text.ToLower();

		_allSections[Songs.SongType.Klassiskt].gameObject.SetActive(false);
		_allSections[Songs.SongType.Öl].gameObject.SetActive(false);
		_allSections[Songs.SongType.Vin].gameObject.SetActive(false);
		_allSections[Songs.SongType.Nubbe].gameObject.SetActive(false);
		_allSections[Songs.SongType.Punsch].gameObject.SetActive(false);
		_allSections[Songs.SongType.Kräftor].gameObject.SetActive(false);
		_allSections[Songs.SongType.Bakfylla].gameObject.SetActive(false);
		_allSections[Songs.SongType.Nördigt].gameObject.SetActive(false);
		_allSections[Songs.SongType.Odödliga].gameObject.SetActive(false);

		if (_allSections.ContainsKey(Songs.SongType.Ekivoka))
		{
			_allSections[Songs.SongType.Ekivoka].gameObject.SetActive(false);
		}

		foreach (var li in _allListItems)
        {
            var found = false;
            if (li.Song.Title.ToLower().Contains(searchString))
            {
                found = true;
            }
			else if (li.Song.Lyrics.ToLower().Contains(searchString))
            {
                found = true;
            }

			if (found)
			{
				_allSections[li.Song.Type].gameObject.SetActive(true);
			}

            li.gameObject.SetActive(found);
        }

		if (searchString.Equals("kebabsallad") && !_allSections.ContainsKey(Songs.SongType.Ekivoka))
		{
			AddSongsByType(Songs.SongType.Ekivoka);
		}
    }
	
	public void ShowSong(Song song)
    {
        SongPanel.gameObject.SetActive(true);
        SongTitle.text = song.Title;
        SongText.text = song.Text;
        SongMelody.text = song.Melody;
        SongLyrics.text = song.Lyrics;
        SongNote.text = song.Notes;

		DeleteButton.gameObject.SetActive(song.Type == Songs.SongType.Egna);
		ShareButton.gameObject.SetActive(song.Type == Songs.SongType.Egna);
		CurrentSong = song;
	}

	private void AddSongsByType(Songs.SongType songType)
	{
		AddSection(songType);

		switch (songType)
		{
			case Songs.SongType.Ekivoka:
				foreach (var song in Songs.GetEkivokaSongs())
				{
					AddSong(songType, song);
				}
				break;

			default:
				foreach (var song in Songs.GetAllSongs(songType))
				{
					AddSong(songType, song);
				}
				break;
		}
	}

	private IEnumerator DownloadSongs()
	{
		if (string.IsNullOrEmpty(ServerURL))
			yield break;

		WWW www = new WWW(ServerURL);
		yield return www;

		if (string.IsNullOrEmpty(www.error))
		{
			Song[] downloadedSongs = JsonHelper.FromJson<Song>(www.text);

			if (downloadedSongs != null && downloadedSongs.Length > 0)
			{
				var songType = Songs.SongType.Nedladdade;

				AddSection(songType);
				
				foreach (var song in downloadedSongs)
				{
					AddSong(songType, song);
				}
			}
		}
		else
		{
			Debug.Log("Error: " + www.error);
		}

		yield return null;
	}
	
	private void AddSong(Songs.SongType songType, Song song)
	{
		var songButton = Instantiate(ButtonPrefab, ScrollContents);
		var li = songButton.GetComponent<ListItemSong>();
		songButton.name = song.Title;
		li.Title.text = song.Title;
		li.Melody.text = song.Melody;
		li.Song = song;
		li.Manager = this;
		li.Song.Type = songType;

		_allListItems.Add(li);
	}

	private void AddSection(Songs.SongType songType)
	{
		var section = Instantiate(SectionPrefab, ScrollContents);
		section.name = songType.ToString();
		var liSection = section.GetComponent<ListItemSection>();
		liSection.Title.text = songType.ToString();

		_allSections.Add(songType, liSection);
	}
	
}
