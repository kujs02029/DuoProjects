using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePlayer : MonoBehaviour
{
    Vector2 movement;
    public int moveSpeed;
    public float firingSpeed = 2;
    [SerializeField] Rigidbody2D rb;
    [SerializeField] GameObject bullet;
    float timer = 0;
    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
        if (timer < firingSpeed)
        {
            timer += Time.deltaTime;
        }
        else
        {
            Instantiate(bullet, new Vector3(transform.position.x, transform.position.y, 0), transform.rotation);
            timer = 0;
        }
    }
}
