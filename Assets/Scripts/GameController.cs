using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public Text scoresText;
    int scores;
    public static GameController instance;

	void Start ()
    {
        instance = this;
	}
	
    public void ChangeScore(int score)
    {
        scores += score;
        scoresText.text = scores.ToString();
    }
}
