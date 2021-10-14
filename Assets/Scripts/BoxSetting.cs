using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BoxSetting : MonoBehaviour
{
   
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Rigidbody2D>() == null)
            return;

        if(collision.gameObject.tag == "Ball")
        {
            ScoreManager.Instance.AddScore();
            this.gameObject.SetActive(false);
            Destroy(this.gameObject, 1);
        }
    }



}
