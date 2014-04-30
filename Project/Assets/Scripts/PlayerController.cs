using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour 
{
	public float playerHealth = 100f;
	public float playerMana = 100f;

	private bool playerDead = false;
	private bool inEnterTrigger = false;

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

		if (inEnterTrigger)
		{
			if (Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.UpArrow))
			{
				Debug.Log("Entered");
			}
		}
	}

	public void OnTriggerEnter2D(Collider2D col)
	{
		if (col.transform.tag == "Enterable")
		{
			inEnterTrigger = true;
		}
		else
		{
			inEnterTrigger = false;
		}
	}
}
