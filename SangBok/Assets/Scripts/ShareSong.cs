using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
using ZXing;

public class ShareSong : MonoBehaviour {
	public SongsManager songsManager;
	//private RawImage _rawImage;
	private InputField _input;

	private void OnEnable()
	{
		if(_input == null)
		{
			_input = GetComponent<InputField>();
		}
		
		var message = JsonUtility.ToJson(songsManager.CurrentSong);
		var bytes = Encoding.UTF8.GetBytes(message);
		_input.text = Convert.ToBase64String(bytes);

		UniClipboard.SetText(_input.text);

		//var encoded = new Texture2D(256, 256);
		//var color32 = Encode(message, encoded.width, encoded.height);
		//encoded.SetPixels32(color32);
		//encoded.Apply();

		//if(_rawImage == null)
		//{
		//	_rawImage = GetComponent<RawImage>();
		//}

		//_rawImage.texture = encoded;
	}

	//private Color32[] Encode(string message, int w, int h)
	//{
	//	var writer = new BarcodeWriter
	//	{
	//		Format = BarcodeFormat.QR_CODE,
	//		Options = new ZXing.Common.EncodingOptions
	//		{
	//			Height = h,
	//			Width = w
	//		}
	//	};

	//	return writer.Write(message);
	//}
}
