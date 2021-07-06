using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class pauseplay : MonoBehaviour
{
    public VideoPlayer videoPlayer;

    [SerializeField] bool isPaused;

    private void Start()
    {
        isPaused = false;
    }

    public void PausePlay()
    {
        if (isPaused)
        {
            videoPlayer.Play();
            isPaused = videoPlayer.isPaused;
        }
        else
        {
            videoPlayer.Pause();
            isPaused = videoPlayer.isPaused;
        }
    }
}
