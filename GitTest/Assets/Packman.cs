using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Packman : MonoBehaviour
{
    Vector2 movement;
    [SerializeField] Rigidbody2D rb;
    [SerializeField] float speed = 5;
    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }
}
