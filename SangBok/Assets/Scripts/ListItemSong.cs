using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ListItemSong : MonoBehaviour {
    public Text Title, Melody;
    public Song Song;
    public SongsManager Manager;

    public void OnClick()
    {
        Manager.ShowSong(Song);
    }
}