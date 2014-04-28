using UnityEngine;
using System.Collections;

public class MainCameraFollow : MonoBehaviour 
{
	public GameObject player;
	Vector3 camPos;
	Vector3 playerPos;

	public void Update()
	{
		camPos = new Vector3(this.transform.position.x, this.transform.position.y, -10);
		playerPos = new Vector3(player.transform.position.x, player.transform.position.y, -10);	

		if (GlobalPlayerSettings.smoothCam)
		{
			this.transform.position = Vector3.Lerp(camPos, playerPos, Time.deltaTime);
		}
		else
		{
			this.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, -10);
		}
	}
}
