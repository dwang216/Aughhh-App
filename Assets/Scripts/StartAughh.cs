using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class StartAughh : MonoBehaviour
{
    private bool musicPaused = true;

    public void PauseMusicOnClick() 
    {
        musicPaused = !musicPaused;

        if(musicPaused)
        {
            // OnGoingMusic.Instance.gameObject.GetComponent<AudioSource>().Pause();
        }

        else 
        {
            // OnGoingMusic.Instance.gameObject.GetComponent<AudioSource>().Play();

        }

    }



}