using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] float strength;
    [SerializeField] Manager manager;
    [SerializeField] bool alive = true;
    // Start is called before the first frame update
    void Start()
    {
        manager = GameObject.FindGameObjectWithTag("Manage").GetComponent<Manager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && alive)
        {
            rb.velocity = Vector2.up * strength;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        manager.gameOver();
        alive = false;
    }
}
