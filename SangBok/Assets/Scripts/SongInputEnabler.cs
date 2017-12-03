using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SongInputEnabler : MonoBehaviour {
	public InputField[] importFields, entryFields;
	
	public void OnInputChangedImportFields()
	{
		foreach(var field in importFields)
		{
			if(field.text != "")
			{
				foreach(var other in entryFields)
				{
					other.interactable = false;
				}
				return;
			}
		}

		foreach (var other in entryFields)
		{
			other.interactable = true;
		}
	}

	public void OnInputChangedEntryFields()
	{
		foreach (var field in entryFields)
		{
			if (field.text != "")
			{
				foreach (var other in importFields)
				{
					other.interactable = false;
				}
				return;
			}
		}

		foreach (var other in importFields)
		{
			other.interactable = true;
		}
	}
}
