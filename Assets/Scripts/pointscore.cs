using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pointscore : MonoBehaviour {
    public int score;
    public int best;
    public Text scoreText;
    public Text bestText;
    public int flag;

    // Use this for initialization
    public void Start () {
        score = 0;
        SetScoreText();
        SetBestScoreText();
    }
	
	// Update is called once per frame
	void Update () {
        /* if (flag==1&&(score == best || score > best))
         {
             best = score;
             PlayerPrefs.SetInt("best", best);
             SetBestScoreText();
         }*/
        //SetBestScoreText();
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "points")
        {

            flag = 1;
            score = score + 1;
            best++;
            SetScoreText();
        }
        
            //best = score;
            if (PlayerPrefs.GetInt("best") < score)
            {

                PlayerPrefs.SetInt("best", score);
                SetBestScoreText();
            }
        
    }
    void SetScoreText()
    {
        scoreText.text = "Score : " + score.ToString();
    }
    void SetBestScoreText()
    {
        bestText.text = "Best : " + PlayerPrefs.GetInt("best");
    }
    
}
