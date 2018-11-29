using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SkipButtonMouseOver : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler {

    public GameObject skipForwardNorm;
    public GameObject skipBackNorm;
    
    public void OnPointerEnter(PointerEventData eventData)
    {
        if (skipBackNorm != null)
            skipBackNorm.GetComponent<Renderer>().enabled = true;
        if (skipForwardNorm != null)
            skipForwardNorm.GetComponent<Renderer>().enabled = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (skipBackNorm != null)
            skipBackNorm.GetComponent<Renderer>().enabled = false;
        if (skipForwardNorm != null)
            skipForwardNorm.GetComponent<Renderer>().enabled = false;
    }
    /*
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
    }*/
}
