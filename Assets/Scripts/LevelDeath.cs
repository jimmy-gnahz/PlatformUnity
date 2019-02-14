using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelDeath : MonoBehaviour
{
    public GameObject youFell;
    public GameObject LevelAudio;

    void OnTriggerEnter()
    {
        StartCoroutine(YouFellOff());

    }

    IEnumerator YouFellOff()
    {
        youFell.SetActive(true);
        LevelAudio.SetActive(false);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(0);
    }


}