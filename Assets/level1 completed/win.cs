using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class win : MonoBehaviour
{
    public GameObject panelToShow;
    public VideoPlayer videoPlayer;

    void Start()
    {
        // Subscribe to the videoPlayer's loopPointReached event
        videoPlayer.loopPointReached += OnVideoEnd;
    }

    void OnVideoEnd(VideoPlayer vp)
    {
        // Video has ended, show the panel
        panelToShow.SetActive(true);
    }

}
