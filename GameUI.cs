using TMPro;
using UnityEngine;

public class GameUI : MonoBehaviour
{
    private TMP_Text playerScoreText;
    private Player player;

    // Start is called before the first frame update
    void Start()
    {
        playerScoreText = GetComponent<TMP_Text>();
        Debug.Log(playerScoreText);
        player = FindObjectOfType<Player>();
        UpdateScoreUI();
    }

    // Update is called once per frame
    void Update()
    {
        if (player)
        {
            UpdateScoreUI();
        }
    }

    void UpdateScoreUI()
    {
        if (player && playerScoreText)
        {
            playerScoreText.text = player.GetScore().ToString();
        }
    }
}   