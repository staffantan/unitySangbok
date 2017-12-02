﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using ZXing;

public class ShareSong : MonoBehaviour {
	public SongsManager songsManager;
	private RawImage _rawImage;
	
	private void OnEnable()
	{
		var message = JsonUtility.ToJson(songsManager.CurrentSong);

		var encoded = new Texture2D(256, 256);
		var color32 = Encode(message, encoded.width, encoded.height);
		encoded.SetPixels32(color32);
		encoded.Apply();

		if(_rawImage == null)
		{
			_rawImage = GetComponent<RawImage>();
		}

		_rawImage.texture = encoded;
	}

	private Color32[] Encode(string message, int w, int h)
	{
		var writer = new BarcodeWriter
		{
			Format = BarcodeFormat.QR_CODE,
			Options = new ZXing.Common.EncodingOptions
			{
				Height = h,
				Width = w
			}
		};

		return writer.Write(message);
	}
}
