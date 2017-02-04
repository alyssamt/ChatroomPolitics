using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Chatroom : MonoBehaviour {

	private Text chatroom;

	// Use this for initialization
	void Start () {
		chatroom = GetComponent<Text> ();
		chatroom.text = "";
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void PostMessage(string poster, string message) {
		chatroom.text += string.Format ("[{0}] {1}: {2}\n", GameManager.time, poster, message);
	}
}
