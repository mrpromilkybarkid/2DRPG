using UnityEngine;
using System.Collections;

public class PlayerGuiManager : MonoBehaviour 
{
	public PlayerController _PC;
	public PlayerSpellManager _PSM;

	public void Update()
	{	}

	public void OnGUI()
	{
		GUI.Box(new Rect(32, 32, 250, 50), "Health: " + _PC.playerHealth);
		GUI.Box(new Rect(32, 96, 250, 50), "Mana: " + _PC.playerMana);
		GUI.Box(new Rect(32, 156, 250, 50), "Current Spell: " + _PSM.activeSpell);
	}
}