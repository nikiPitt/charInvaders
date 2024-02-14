using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    [SerializeField] public int power;
    private Player player;
    [SerializeField] private AudioSource destroySound;
    private void Start()
    {
         player = GameObject.FindObjectOfType<Player>();
    }

    private void OnCollisionEnter2D(Collision2D collision) 
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
            destroySound.Play();
            UpdateScore();
        }
    }
    
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
            destroySound.Play();
            UpdateScore();
        }
        
    }
    
    // private void OnCollisionExit2D(Collision2D collision)
    // {
    //     if (collision.gameObject.CompareTag("Enemy"))
    //     {
    //         Debug.Log("Shot!");
    //         Destroy(collision.gameObject);
    //     }
    // }
    
    void UpdateScore()
    {
        player.GetPoints(power);
        //Debug.Log(player.GetComponent<SimpleCharacterController>().score);
    }
}
