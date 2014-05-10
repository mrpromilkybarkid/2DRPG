using UnityEngine;
using System.Collections;

public class PlayerSpellManager : MonoBehaviour
{
	public GameObject earthSpell;
	public GameObject windSpell;
	public GameObject fireSpell;
	public GameObject waterSpell;

	[HideInInspector]
	public GameObject activeSpell;

	public PlayerController _PC;

	public void Start()
	{
		activeSpell = earthSpell;
	}

	public void Update()
	{
		if (Input.GetKeyDown(KeyCode.Alpha1))
		{
			activeSpell = earthSpell;
		}

		if (Input.GetKeyDown(KeyCode.Alpha2))
		{
			activeSpell = windSpell;
		}

		if (Input.GetKeyDown(KeyCode.Alpha3))
		{
			activeSpell = fireSpell;
		}

		if (Input.GetKeyDown(KeyCode.Alpha4))
		{
			activeSpell = waterSpell;
		}

		if (_PC.playerMana > 0 && Input.GetMouseButtonDown(0))
		{
			Instantiate(activeSpell, transform.position, Quaternion.identity);
			_PC.playerMana = _PC.playerMana - 50;
		}
	}
}
