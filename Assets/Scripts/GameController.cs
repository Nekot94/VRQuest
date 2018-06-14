using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public Text scoresText;
    public Text endText;
    int scores;
    public static GameController instance;
    public float timeToRestart = 2;

    void Start ()
    {
        instance = this;
	}
	
    public void ChangeScore(int score)
    {
        scores += score;
        scoresText.text = scores.ToString();
    }

    public void Win()
    {
        endText.text = "Пппдил";
        endText.color = Color.green;
        StartCoroutine(Restart());
    }

    public void Lose()
    {
        endText.text = "Ппприграл";
        endText.color = Color.red;
        StartCoroutine(Restart());
    }

    IEnumerator Restart()
    {
        yield return new WaitForSeconds(timeToRestart);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
