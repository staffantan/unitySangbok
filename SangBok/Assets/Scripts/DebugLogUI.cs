using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DebugLogUI : MonoBehaviour {
	[SerializeField]
	private Text Text;

	private Queue<string> logQueue = new Queue<string>();

	// Use this for initialization
	void Start () {
		Application.logMessageReceived += HandleLog;
	}

	private void Update()
	{
		var logText = "";
		foreach(var log in logQueue)
		{
			logText += log + "\n";
		}
		Text.text = logText;
	}

	private void HandleLog(string condition, string stackTrace, LogType type)
	{
		logQueue.Enqueue(condition);
		if(type == LogType.Exception)
		{
			logQueue.Enqueue(stackTrace);
		}
	}
}