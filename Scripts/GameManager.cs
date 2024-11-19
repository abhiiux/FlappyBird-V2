using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
  public Bird _bird;
  public MusicManager music;
    public Text Score;
    public GameObject bird;
    public GameObject UI;
    int score; 
    public void Pause()
    {
        Time.timeScale = 0f;
    }

    public void Play()
    {
        Time.timeScale = 1.0f;
        UI.SetActive(false);
        bird.transform.position = new Vector3(0, 0, -1);

        DestroyPipes();
        Resetscore();
        _bird.enabled = true;
    }

    public void GameOver()
    {
      music.Impact();

      UI.SetActive(true);
      Pause();
      _bird.enabled = false;
    }

    public void DestroyPipes()
    {
      Move[] pipes = FindObjectsOfType<Move>();

      for (int i = 0; i < pipes.Length; i++)
      {
        Destroy(pipes[i].gameObject);
      }
    }
    
    public void AddScore()
    {
        score ++;
        Score.text = score.ToString();
        music.Scoring();
    }
    public void Resetscore()
    {
      Score.text = "0";
      score = 0;
    }
}
