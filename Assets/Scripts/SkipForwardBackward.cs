using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class SkipForwardBackward : MonoBehaviour {
    
    public GameObject videoObject; // the video itself
    // In the Unity inspector, assign only the skip back image, or the skip forward one (depending
    // on which buttons you're assigning the script to), NOT BOTH
    public GameObject skipBackNorm; // non-transparent skip back image
    public GameObject skipForwardNorm; // non-transparent skip forward image
    // In the Unity inspector, assign a value to only one of these ints, NOT BOTH
    public int secondsToSkipBack; // number of seconds to skip backward
    public int secondsToSkipForward; // number of seconds to skip forward

	void OnMouseOver()
    {
        if (skipBackNorm != null)
            skipBackNorm.GetComponent<Renderer>().enabled = true;
        if (skipForwardNorm != null)
            skipForwardNorm.GetComponent<Renderer>().enabled = true;
    }

    void OnMouseExit()
    {
        if (skipBackNorm != null)
            skipBackNorm.GetComponent<Renderer>().enabled = false;
        if (skipForwardNorm != null)
            skipForwardNorm.GetComponent<Renderer>().enabled = false;
    }
	
	// Update is called once per frame
	void Update ()
    {
        // used to determine where the mouse click occured (verifies it happens on the buttons)
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        // if there is a mouse click
        if (Input.GetMouseButtonDown(0))
        {
            // if the mouse click happened on the skip buttons
            if (Physics.Raycast(ray, out hit) && hit.collider.gameObject == gameObject)
            {
                videoObject.gameObject.GetComponent<VideoPlayer>().time -= secondsToSkipBack;
                videoObject.gameObject.GetComponent<VideoPlayer>().time += secondsToSkipForward;
            }
        }
    }

}
