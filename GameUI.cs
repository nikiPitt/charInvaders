using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameUI : MonoBehaviour
{
    private TMP_Text playerScore;
    private Player player;

    // Start is called before the first frame update
    void Start()
    {
        playerScore = GetComponent<TMP_Text>();
        player = FindObjectOfType<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        playerScore.text = player.GetScore().ToString();
    }
}
