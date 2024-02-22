using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices.ComTypes;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    private Player player;
    [SerializeField] AudioSource audioSource;
    private void Start()
    {
        player = GameObject.FindObjectOfType<Player>();
    }

    private void OnCollisionEnter2D(Collision2D collision) 
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Play audio effect");
            audioSource.Play();
        }
    }
    
    private void OnCollisionStay2D(Collision2D collision)
    { 
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Enemy e = collision.gameObject.GetComponent<Enemy>();
            player.UpdateScore(e);
            Destroy(collision.gameObject);
        }
    }
}
