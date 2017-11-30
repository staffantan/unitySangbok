using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class Song
{
	public string Title;
	public string Melody;
	public string Text;
	[Multiline]
	public string Lyrics;
	public string Notes;

	public Songs.SongType Type;

	public Song()
	{

	}

	public Song(string title, string melody, string text, string lyrics, string notes)
	{
		Title = title;
		Melody = melody;
		Text = text;
		Lyrics = lyrics;
		Notes = notes;
	}
}