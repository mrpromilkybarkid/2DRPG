using UnityEngine;
using System.Collections;

public class MainCameraFollow : MonoBehaviour 
{
	public GameObject player;
	Vector3 camPos;
	Vector3 playerPos;

	public void Update()
	{
		this.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, -10);
	}
}
