using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    
    public Camera Kamera;
    public float speed;

  
    private void Update()
    {
        Vector3 mouse = Kamera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1));
        Vector3 angle = mouse - transform.position;
        
        if(Vector3.Distance(mouse, transform.position) > 0.5)
        {
            transform.Translate(angle.normalized * speed * Time.deltaTime);
        }
    }


}
