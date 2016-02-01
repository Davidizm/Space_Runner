using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerActor : Actor {
	public Slider hudShield;
	public Slider hudHealth;

	// References to menu objects needed by the player
	public GameObject menu;
	public Text menuTitle;
	public GameObject resumeButton;

	// Use this for initialization
	new void Start () {
		base.Start ();
		// set the health bar
		hudHealth.minValue = 0;
		hudHealth.maxValue = startHitPoints;
		updateHudHealth ();
	}
	
	// Update is called once per frame
	void Update () {
		// If the user presses the escape key, show the menu
		if (Input.GetKey (KeyCode.Escape)) {
			showPauseMenu ();
		}
	}

	public override void DoDamage(int amount)
	{
		base.DoDamage (amount);
		updateHudHealth ();
	}

	public void updateHudHealth() {
		hudHealth.value = currentHitPoints;
	}

	public void showPauseMenu() {
		Time.timeScale = 0.0f;
		menuTitle.text = "Menu";
		menu.SetActive (true);
	}

	public void showGameOverMenu() {
		menuTitle.text = "Game Over";
		resumeButton.GetComponent<Button> ().interactable = false;
		menu.SetActive (true);
	}

	void OnDestroy() {
		base.OnDestroy ();
		showGameOverMenu ();
	}
}
