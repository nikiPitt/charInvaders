using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameRecord : MonoBehaviour
{
    public TMP_Text record;
    public TMP_Text bestrecord;
    private int minutes;
    private int seconds;
    private int bestplay;

    // Start is called before the first frame update
    void Start()
    {
        RenderRecord();
    }

    private void OnEnable()
    {
        SharedSources.playtimes.Sort();
        bestplay = (int) SharedSources.playtimes[0];
        seconds = PlayerPrefs.GetInt("seconds");
        minutes = PlayerPrefs.GetInt("minutes");
    }

    private void RenderRecord()
    {
        bestrecord.text = "best record: \n" + bestplay / 60 + "min " + bestplay % 60 + "seconds";
        record.text = "your record: \n" + minutes + "min " + seconds + "seconds";
    }
}
