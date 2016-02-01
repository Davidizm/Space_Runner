using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DisplayBriefMessage : MonoBehaviour {
	// the area to display the message in.
	public Text messageBox;
	// the length of time to display the message
	public float duration;
	// wait for specified time, and then display message
	public float delay;
	// the message to display
	[TextArea(3,10)]
	public string message;

	// Use this for initialization
	void Start () {
		Invoke ("displayMessage", delay);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void displayMessage() {
		messageBox.text = message;
		Invoke ("clearMessage", duration);
	}

	void clearMessage() {
		messageBox.text = "";
	}
}
