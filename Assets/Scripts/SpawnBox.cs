using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class SpawnBox : MonoBehaviour
{
    public GameObject box;
    public float left,right,bottom,top;


    private void Start()
    {
        SpawnTheBox();
    }
    
    void SpawnTheBox()
    {
        int Amount = Random.Range(5,25);
        for(int i = 0; i < Amount; i++)
        {
            float randomx = Random.Range(left, right);
            float randomy = Random.Range(top, bottom);
            Instantiate(box, new Vector2(randomx, randomy), Quaternion.identity);
        }
    }

}
