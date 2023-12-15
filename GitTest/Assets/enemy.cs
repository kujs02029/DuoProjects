using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] Rigidbody2D rb;
    // Update is called once per frame
    void Update()
    {
        rb.velocity = (player.transform.position - transform.position).normalized;
    }
}
