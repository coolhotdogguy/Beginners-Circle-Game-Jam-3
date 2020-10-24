﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinGame : MonoBehaviour
{
    [SerializeField] Animator creditsAnim;
    [SerializeField] GameObject credits;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            FindObjectOfType<CameraController>().winCamera = true;
            FindObjectOfType<MusicPlayer>().audioSource.clip = FindObjectOfType<MusicPlayer>().music[3];
            FindObjectOfType<MusicPlayer>().audioSource.Play();
            FindObjectOfType<MusicPlayer>().volume = 0.5f;
            creditsAnim.SetBool("Credits", true);
            this.GetComponent<BoxCollider2D>().enabled = false;
        }
    }

    void OnQInput()
    {
        if (FindObjectOfType<StartGameAgainAfterWin>().enableGame)
        {
            StartGameAgain();
        }
    }

    public void StartGameAgain()
    {
        FindObjectOfType<CameraController>().freezeCamera = false;
        FindObjectOfType<CameraController>().ResetCameraAfterWin();
        creditsAnim.SetBool("Credits", false);
        credits.SetActive(false);
        Debug.Log("won");
    }
}
