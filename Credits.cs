using System;
using TMPro;
using UnityEngine;

public class Credits : MonoBehaviour
{
    public TMP_Text e;
    private int speed = 50;

    private void Update()
    {
        MoveCredit();
    }

    public void MoveCredit()
    {   
        e.rectTransform.position += new Vector3(0f, this.speed, 0) * Time.deltaTime;
    }
}
