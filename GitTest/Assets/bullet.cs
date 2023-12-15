using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    [SerializeField]GameObject Enemy;
    [SerializeField] Rigidbody2D rb;

    // Update is called once per frame
    void Update()
    {
        rb.velocity = (Enemy.transform.position - transform.position).normalized;
    }
}
