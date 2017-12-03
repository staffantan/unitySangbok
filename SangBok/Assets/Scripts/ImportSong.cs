using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using ZXing;
//using ZXing.Common;
//using ZXing.QrCode;

public class ImportSong : MonoBehaviour {
	public SongsManager songsManager;
	public GameObject MyPanel;

	//private WebCamTexture _camTexture;
	//private Rect _screenRect;
	//private QRCodeReader _reader;

	//private void Start()
	//{
	//	_screenRect = new Rect(0, 0, Screen.width, Screen.height);
	//	_camTexture = new WebCamTexture(Screen.width, Screen.height);
	//	_camTexture.Play();

	//	_reader = new QRCodeReader();
	//}

	//private void OnEnable()
	//{
	//	if(_camTexture != null)
	//	{
	//		_camTexture.Play();
	//	}
	//}

	//private void OnDisable()
	//{
	//	_camTexture.Stop();
	//}


	//private void Update()
	//{
	//	if (Input.GetKeyDown(KeyCode.Escape))
	//	{
	//		MyPanel.SetActive(false);
	//	}

	//	ReadQR();
	//}

	//private void ReadQR()
	//{
	//	var colors = _camTexture.GetPixels32();

	//	var bytes = new byte[colors.Length * 4];
	//	for (int i = 0; i < colors.Length; i++)
	//	{
	//		bytes[i * 4] = (byte)(colors[i].r * 255);
	//		bytes[i * 4 + 1] = (byte)(colors[i].g * 255);
	//		bytes[i * 4 + 2] = (byte)(colors[i].b * 255);
	//		bytes[i * 4 + 3] = (byte)(colors[i].a * 255);
	//	}

	//	LuminanceSource source = new RGBLuminanceSource(bytes, _camTexture.width, _camTexture.height);
	//	BinaryBitmap bitmap = new BinaryBitmap(new HybridBinarizer(source));
	//	try
	//	{
	//		var result = _reader.decode(bitmap);

	//		if (result != null)
	//		{
	//			Debug.Log(result.Text);
	//			Song song = JsonUtility.FromJson<Song>(result.Text);
				
	//			songsManager.AddSongToCustomSongs(song);
	//			MyPanel.SetActive(false);
	//			#if UNITY_ANDROID || UNITY_IOS
	//				Handheld.Vibrate();
	//			#endif
	//		}
	//	}
	//	catch (Exception e)
	//	{
	//		Debug.Log(e.StackTrace);
	//	}
	//}

	//private void OnGUI()
	//{
	//	GUI.DrawTexture(_screenRect, _camTexture, ScaleMode.ScaleToFit);
	//}
}
