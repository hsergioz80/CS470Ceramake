using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnchorVideo : MonoBehaviour
{
    // default state of tagalong is that it's enabled at the start of any video scene being loaded
    private bool tagalongIsEnabled = true;

    public void TagalongDisableEnable()
    {
        // find the gameobject called "Canvas" since this is where the tagalong scripts are applied
        GameObject canvasObject = GameObject.Find("Canvas");

        // if tagalong is enabled and the anchoring button is clicked, disable all tagalong related scripts on Canvas
        if (tagalongIsEnabled) 
        {
            ((MonoBehaviour)canvasObject.GetComponent("SimpleTagalong")).enabled = false;
            ((MonoBehaviour)canvasObject.GetComponent("Interpolator")).enabled = false;
            ((MonoBehaviour)canvasObject.GetComponent("Billboard")).enabled = false;
            tagalongIsEnabled = false;
        }
        else // if tagalong is disabled when anchor button is clicked, re-enable tagalong scripts
        {
            ((MonoBehaviour)canvasObject.GetComponent("SimpleTagalong")).enabled = true;
            ((MonoBehaviour)canvasObject.GetComponent("Interpolator")).enabled = true;
            ((MonoBehaviour)canvasObject.GetComponent("Billboard")).enabled = true;
            tagalongIsEnabled = true;
        }
    }
}
