using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPipe : MonoBehaviour
{
    [SerializeField] GameObject pipe;
    [SerializeField] float rate = 2;
    private float timer = 0;
    [SerializeField] float height = 10;
    // Start is called before the first frame update
    void Start()
    {
        SpawnPipes();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < rate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            SpawnPipes();
            timer = 0;
        }
    }

    void SpawnPipes()
    {
        float lowestPoint = transform.position.y - height;
        float highestPoint = transform.position.y + height;
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}
