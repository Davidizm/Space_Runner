using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {
	public GameObject menu;

	// Use this for initialization
	void Start () {
	
	}

	public void Restart() {
		Time.timeScale = 1.0f;
		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);
	}
	
	public void QuitApplication() {
		Application.Quit ();
	}

	public void Resume() {
		menu.SetActive (false);
		Time.timeScale = 1.0f;
	}
}
