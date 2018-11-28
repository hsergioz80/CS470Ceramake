using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockUnlock : MonoBehaviour {

    public GameObject lockLeft;
    public GameObject lockRight;
    public GameObject unlockLeft;
    public GameObject unlockRight;
    private bool unlockIsDisplaying = true;

    public void displayLockUnlock()
    {
        if (unlockIsDisplaying)
        {
            unlockLeft.GetComponent<Renderer>().enabled = false;
            unlockRight.GetComponent<Renderer>().enabled = false;
            lockLeft.GetComponent<Renderer>().enabled = true;
            lockRight.GetComponent<Renderer>().enabled = true;
            unlockIsDisplaying = false;
        }
        else
        {
            unlockLeft.GetComponent<Renderer>().enabled = true;
            unlockRight.GetComponent<Renderer>().enabled = true;
            lockLeft.GetComponent<Renderer>().enabled = false;
            lockRight.GetComponent<Renderer>().enabled = false;
            unlockIsDisplaying = true;
        }
    }
}
