using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour 
{
	public float playerHealth = 100f;
	public float playerMana = 100f;
	public bool playerDead = false;

	public void Awake()
	{
		DontDestroyOnLoad(this.gameObject);
	}

	public void Start()
	{}

	public void Update()
	{
		if (playerHealth <= 0)
		{
			playerDead = true;
		}
		else
		{
			playerDead = false;
		}

		if (playerMana <= 0)
		{
			playerMana = 0;
			Debug.Log("Out of Mana");
		}

		//Debug
		if (Input.GetKeyDown(KeyCode.M))
		{
			playerMana = playerMana + 100;
		}
	}
}
