using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Video;

public class VRVideoPlayer : MonoBehaviour
{
    VideoPlayer videoPlayer;
    public string videoName;

    // Start is called before the first frame update
    void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>();
        videoPlayer.url = Path.Combine(Application.streamingAssetsPath, videoName);
        videoPlayer.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
