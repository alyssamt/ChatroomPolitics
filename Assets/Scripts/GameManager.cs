using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public static string time;

	public Chatroom chatroom;

    private List<Character> characters;

	// Use this for initialization
	void Start () {
        characters = ReadCharacters();

		time = "12:00";
		chatroom.PostMessage ("Shithead", "Hey shitheads");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    List<Character> ReadCharacters()
    {
        string line;
        string currQ = "";
        Character currChar = null;
        List<Character> charList = new List<Character>();

        List<string> splitLine;
        string type = "";

        System.IO.StreamReader file = new System.IO.StreamReader("CharacterList.txt");
        while ((line = file.ReadLine()) != null)
        {
            if (line[0] == '*')
            {
                if (currChar)
                {
                    charList.Add(currChar);
                }
                currChar = new Character();
                currChar.charname = line.Substring(1);
            } else if (line[0] == '^')
            {
                currChar.likes.Add(line.Substring(1));
            } else if (line[0] == '_')
            {
                currChar.dislikes.Add(line.Substring(1));
            } else if (line[0] == '?')
            {
                currQ = line.Substring(1);
                currChar.questions.Add(currQ, new Dictionary<string, List<string>>());
            } else if (line[0] == '!')
            {
                splitLine = new List<string>(line.Substring(1).Split(','));
                type = splitLine[0];
                splitLine.Remove(type);
                currChar.questions[currQ].Add(type, splitLine);
            }
        }

        file.Close();
        return charList;
    }
}
