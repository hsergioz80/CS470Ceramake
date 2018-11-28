using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class PlayPauseVideo : MonoBehaviour {

    public GameObject videoPlayer;
    public GameObject pauseButtonObject;
    public GameObject playButtonObject;
    public GameObject videoObject;
    public bool playButtonDisplaying;


    void Start()
    {
        // set videoPlayer to the game object the script is attached to ("this")
        videoPlayer = this.gameObject;
        // set the pauseButtonObject
        pauseButtonObject = GameObject.Find("PauseButton");
        // set the playButtonObject
        playButtonObject = GameObject.Find("PlayButton");
        // set the videoObject to the video being played
        //videoObject = GameObject.Find("(01) Centering v2");
        // play button is not being displayed initially, so set it to false
        playButtonDisplaying = false;
    }

    // when the mouse hovers over the video player, display the pauseButton image
    void OnMouseOver()
    {
        if (!playButtonDisplaying)
            pauseButtonObject.GetComponent<Renderer>().enabled = true;
    }

    // when the mouse is no longer hovering over the video player, disable the pauseButton image
    void OnMouseExit()
    {
        pauseButtonObject.GetComponent<Renderer>().enabled = false;
    }

    void Update()
    {
        // used to determine where the mouse click occured (verifies it happens on the video player)
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        // if there is a mouse click
        if (Input.GetMouseButtonDown(0))
        {
            // if the mouse click happened on the gameObject
            if (Physics.Raycast(ray, out hit) && hit.collider.gameObject == gameObject)
            {
                // check if the video is playing already, if it is, pause it and display the play button image
                if (videoObject.gameObject.GetComponent<VideoPlayer>().isPlaying)
                {
                    videoObject.gameObject.GetComponent<VideoPlayer>().Pause();
                    playButtonObject.GetComponent<Renderer>().enabled = true;
                    // since the mouse is hovering over the video when clicked, both play and pause buttons will display, disable pause
                    pauseButtonObject.GetComponent<Renderer>().enabled = false;
                    playButtonDisplaying = true;
                }
                else // if it's not playing, play it, and remove the play button image
                {
                    videoObject.gameObject.GetComponent<VideoPlayer>().Play();
                    playButtonObject.GetComponent<Renderer>().enabled = false;
                    playButtonDisplaying = false;
                }
            }
        }
    }
}
