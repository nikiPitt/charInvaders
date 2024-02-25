using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour
{
    private int _score = 0;
    private int playtime = 0; 
    private int seconds = 0;
    private int minutes = 0;
    
    private void Start()
    {
        StartCoroutine("Playtimer");
    }

    private void Update()
    {
        if (_score >= 1000)
        {
            finishGame();
        }
    }
    
    private IEnumerator Playtimer()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            playtime += 1;
            seconds = playtime % 60;
            minutes = (playtime / 60) % 60;
        }
    }

    public void UpdateScore(Enemy e)
    {
        _score += e.point;
        Debug.Log(_score);
    }

    public int GetScore()
    {
        return _score;
    }

    public int[] GetTime()
    {
        int[] timeArray = {minutes, seconds};
        return timeArray;
    }

    private void finishGame()
    {
        SceneManager.LoadScene(2);
    }

    private void OnDisable()
    {
        PlayerPrefs.SetInt("seconds", seconds);
        PlayerPrefs.SetInt("minutes", minutes);
    }
}
