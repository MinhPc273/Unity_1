using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text scoreText;
    public Text scoreOver;
    public GameObject GameOverPanel; 
    public GameObject Line;
    public GameObject Ball;
    public void SetScoreText(string txt){
        if(scoreText){
            scoreText.text = txt;
        }
    }
    public void SetScoreOver(string txt){
        if(scoreOver){
            scoreOver.text = txt;
        }
    }
    public void ShowGameOverPanel(bool IsShow){
        if(GameOverPanel){
            GameOverPanel.SetActive(IsShow); //true = hien, false = an
        }
    }
    public void ShowLine(bool IsShow){
        if(Line) {
            Line.SetActive(IsShow);
        }
    }
    public void ShowBall(bool IsShow){
        if(Ball){
            Ball.SetActive(IsShow);
        }
    }
}
