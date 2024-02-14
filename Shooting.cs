using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField] private GameObject[] shootings;
    private int shootingPosOffset = 50;
    [SerializeField] private AudioSource shootingSound;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 playerPos = transform.position;
            Vector3 shootPos = playerPos + new Vector3(28, shootingPosOffset, 0);
            shootingSound.Play();
            Instantiate(shootings[0], shootPos, Quaternion.identity); 
        }
    }
}