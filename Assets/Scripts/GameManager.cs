using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public static string time;

	public Chatroom chatroom;

	// Use this for initialization
	void Start () {
		time = "12:00";
		chatroom.PostMessage ("Shithead", "Hey shitheads");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
