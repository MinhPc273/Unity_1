using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject ball;
    public float spawnTime; //khoang time cho qua bong ke tiep

    float m_spawnTime; //kieu dl private
    int m_score;  //private -> tranh bi hack
    bool m_isGameOver=false;

    UIManager m_ui;

    // Start is called before the first frame update
    void Start()
    {
        m_score=0;
        m_spawnTime=0;  
        m_ui = FindObjectOfType<UIManager>();
        m_ui.SetScoreText("Score: "+m_score);
        m_ui.ShowBall(true);
    }

    public void Replay() {
      m_score=0;
      m_isGameOver=false;
      m_ui.SetScoreText("Score: "+m_score);
      m_ui.ShowGameOverPanel(false); 
      m_ui.ShowLine(true);
      m_ui.ShowBall(true);
    }

    // Update is called once per frame
    void Update()
    {
        m_spawnTime -= Time.deltaTime;
        if(GetGameOver()){
             m_spawnTime = 0;
             m_ui.SetScoreOver("Score: "+m_score);
             m_ui.ShowGameOverPanel(true);
             m_ui.ShowLine(false);
             m_ui.ShowBall(false);
             return;
        }
        if(m_spawnTime <=0 ){
            SpawnBall();
            m_spawnTime=spawnTime;
        }
    }


    public void SpawnBall(){
         Vector2 spawnPos = new Vector2(Random.Range(-7,7),6);
         
         if(ball){
            Instantiate(ball, spawnPos, Quaternion.identity); // ?
         }
    }

    public void SetScore(int value) {
        m_score = value;
    }
    public int GetScore() {
        return m_score;
    }
    public void IncrementScore(){
        m_score++;
        m_ui.SetScoreText("Score: "+ m_score);
    }
    public bool GetGameOver() {
        return m_isGameOver;
    }
    public void SetGameOver(bool state){
        m_isGameOver=state;
    }


}
