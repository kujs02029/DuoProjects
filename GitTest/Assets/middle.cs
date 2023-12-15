using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class middle : MonoBehaviour
{
    [SerializeField] Manager manager;
    // Start is called before the first frame update
    void Start()
    {
        manager = GameObject.FindGameObjectWithTag("Manage").GetComponent<Manager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 3)
        {
            manager.add(1);
        }
    }
}
