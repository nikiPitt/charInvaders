using TMPro;
using UnityEngine;

public class GameUI : MonoBehaviour
{
    public TMP_Text playerScoreText;
    public TMP_Text playTimeText;
    private Player player;

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<Player>();
        UpdateScoreUI();
        UpdateTimeUI();
    }

    // Update is called once per frame
    void Update()
    {
        if (player)
        {
            UpdateScoreUI();
            UpdateTimeUI();
        }
    }

    void UpdateScoreUI()
    {
        if (player && playerScoreText)
        {
            playerScoreText.text = player.GetScore().ToString();
        }
    }

    void UpdateTimeUI()
    {
        if (player && playTimeText)
        {
            int[] timeArray = player.GetTime();
            playTimeText.text = timeArray[0] + ":" + timeArray[1];
        }        
    }
}   