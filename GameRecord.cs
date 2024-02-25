using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameRecord : MonoBehaviour
{
    private TMP_Text record;
    private int minutes;
    private int seconds;

    // Start is called before the first frame update
    void Start()
    {
        record = GetComponent<TMP_Text>();
        RenderRecord();
    }

    private void OnEnable()
    {
        seconds = PlayerPrefs.GetInt("seconds");
        minutes = PlayerPrefs.GetInt("minutes");
    }

    private void RenderRecord()
    {
        record.text = minutes + "min " + seconds + "seconds";
    }
}
