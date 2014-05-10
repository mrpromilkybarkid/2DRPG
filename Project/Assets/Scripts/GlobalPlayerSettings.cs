using UnityEngine;
using System.Collections;

public class GlobalPlayerSettings : MonoBehaviour 
{
	public static bool smoothCam = false;
	public bool active = false;

	public void Update()
	{
		if (Input.GetKeyDown(KeyCode.Tab))
		{
			if (active)
			{
				active = false;
			}
			else
			{
				active = true;
			}
		}
	}

	public void OnGUI()
	{
		if (active)
		{
			if (GUI.Button(new Rect(100, 100, 100, 100), "SC"))
			{
				if (smoothCam)
				{
					smoothCam = false;
				}
				else if (!smoothCam)
				{
					smoothCam = true;
				}
			}
		}
		else
		{
		}
	}
}
