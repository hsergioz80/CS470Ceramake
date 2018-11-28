using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class PlayPauseVideo : MonoBehaviour {

    public GameObject videoPlayer;

    void Start()
    {
        // set videoPlayer to the game object the script is attached to ("this")
        videoPlayer = this.gameObject;
    }

    void Update()
    {
        // used to determine where the mouse click occured
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        // if there is a mouse click
        if (Input.GetMouseButtonDown(0))
        {
            // find the video being played, set it to videoObject
            GameObject videoObject = GameObject.Find("(01) Centering v2");

            // if the mouse click happened on the gameObject
            if (Physics.Raycast(ray, out hit) && hit.collider.gameObject == gameObject)
            {
                // check if the video is playing already, if it is, pause it
                if (videoObject.gameObject.GetComponent<VideoPlayer>().isPlaying)
                    videoObject.gameObject.GetComponent<VideoPlayer>().Pause();
                else // if it's not playing, play it
                    videoObject.gameObject.GetComponent<VideoPlayer>().Play();
            }
        }
    }
}
