using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class SpawnBox : MonoBehaviour
{
    public GameObject box;


    private void Start()
    {
        SpawnTheBox();

    }
    
    void SpawnTheBox()
    {
        int Amount = Random.Range(10,25);
        for(int i = 0; i < Amount; i++)
        {
            float randomx = Random.Range(-3.6f, 3.6f);
            float randomy = Random.Range(3.6f, -3.6f);
            Instantiate(box, new Vector2(randomx, randomy), Quaternion.identity);
        }
    }

    float SpawnTime = 3f;
    public float SpawnTime2 = 1f;

    void Update()
    {
        if (Time.time > SpawnTime)
        {
            float randomx = Random.Range(-3.6f, 3.6f);
            float randomy = Random.Range(3.6f, -3.6f);
            Instantiate(box, new Vector2(randomx, randomy), Quaternion.identity);

            SpawnTime = Time.time + SpawnTime2;
        }
    }


}
