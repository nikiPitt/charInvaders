using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEditor.Build;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //Class Enemy instance fields
    public TMP_Text e;
    [SerializeField] private string type;
    [SerializeField] private int speed;
    
    private void Update()
    {
        Move();
    }

    private void toString()
    {
        Debug.Log("Enemy type: " + type + " Speed: " + speed);
    }

    private void Move()
    {
        e.rectTransform.position += new Vector3(0f, this.speed, 0) * Time.deltaTime;
    }
}