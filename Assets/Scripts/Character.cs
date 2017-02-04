using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {

    public string charname;
    public List<string> likes;
    public List<string> dislikes;
    public Dictionary<string, Dictionary<string, List<string>>> questions = new Dictionary<string, Dictionary<string, List<string>>>();

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
