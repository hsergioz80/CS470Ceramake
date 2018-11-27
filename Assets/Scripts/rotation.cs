using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour {
    public float speed = 500f;

    void Update()
    {
        transform.Rotate(Vector3.up, speed * Time.deltaTime);   
    }

}
