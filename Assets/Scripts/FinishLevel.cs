using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLevel : MonoBehaviour
{

    public GameObject levelMusic;
    public AudioSource levelComplete;
    public GameObject levelTimer;

    void OnTriggerEnter()
    {
        levelMusic.SetActive(false);
        levelTimer.SetActive(false);
        levelComplete.Play();
    }

}