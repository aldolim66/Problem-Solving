using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    private Rigidbody2D Rb;

   
    public float xInitialForce;
  
    public float yInitialForce;

    void ResetPosotionBall()
    {
        
        transform.position = Vector2.zero;
       
        Rb.velocity = Vector2.zero;
    }

    void PushBall()
    {

        float yRandomInitialForce = Random.Range(-yInitialForce, yInitialForce);

        float randomDirection = Random.Range(0, 2);

       
        if (randomDirection < 1.1f)
        {
            Rb.AddForce(new Vector2(-xInitialForce, yRandomInitialForce));
        }
        else
        {
            Rb.AddForce(new Vector2(xInitialForce, yRandomInitialForce));
        }
    }

    void MulaiUlangGame()
    {
        
        ResetPosotionBall();
        Invoke("PushBall", 2);
    }

    void Start()
    {
        // Mendapatkan Komponen Rigibody
        Rb = GetComponent<Rigidbody2D>();

        // Memulai Game
        MulaiUlangGame();
    }
}
