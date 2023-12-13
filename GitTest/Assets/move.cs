using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float speed = .1f;
    // Update is called once per frame
    void FixedUpdate()
    {
        float hr = Input.GetAxis("Horizontal");
        float vr = Input.GetAxis("Vertical");
        transform.position += new Vector3(hr, vr) * speed;
        
    }
}
