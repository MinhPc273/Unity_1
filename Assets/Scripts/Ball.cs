using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    GameController m_gc;
    private void Start() {
        m_gc = FindObjectOfType<GameController>();
    }
    private void OnCollisionEnter2D(Collision2D col) {
        if(col.gameObject.CompareTag("Player")) {
            Destroy(gameObject);
            m_gc.IncrementScore();
        }
    }
    private void OnTriggerEnter2D(Collider2D col) {
        if(col.gameObject.CompareTag("DeathZone")) {
            Destroy(gameObject);
            m_gc.SetGameOver(true);
        }
    }
}
