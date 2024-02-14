using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Shots : MonoBehaviour
{
    public TMP_Text at;
    [SerializeField] private string shotType;
    [SerializeField] private int speed;
    [SerializeField] private int power;

    private void Start()
    {
        toString();
    }

    private void Update()
    {
        Move();
    }

    private void toString()
    {
        Debug.Log("Shot type: " + shotType + " Speed: " + speed + " Power: " + power);
    }

    private void Move()
    {
        at.rectTransform.position += new Vector3(0f, this.speed, 0) * Time.deltaTime;
    }
}
