using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
     AudioSource audioManager1;
     AudioSource audioManager;
    public AudioClip jump;
    public AudioClip score;
    public AudioClip gameOver;

    void Awake()
    {
        audioManager = GetComponent<AudioSource>();
        audioManager1 = GetComponent<AudioSource>();
    }
    public void Flap()
    {
        audioManager.clip = jump;
        audioManager.Play();
    }
    public void Scoring()
    {
        audioManager1.PlayOneShot(score,0.7f);
    }
    public void Impact()
    {
        audioManager.clip = gameOver;
        audioManager.Play();
    }
}
