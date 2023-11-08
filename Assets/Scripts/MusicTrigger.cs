using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicTrigger : MonoBehaviour
{
    public AudioSource MusicPlayer;

    private void OnTriggerEnter(Collider other)
    {
        MusicPlayer.Pause();
    }

    private void OnTriggerExit(Collider other)
    {
        MusicPlayer.UnPause();
    }
}
