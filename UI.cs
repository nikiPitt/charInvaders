using System.Collections;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    private string[] textToTypeList = {"Greetings, Pilot! Welcome aboard the 2499 starship. " +
                                       "As we traverse the cosmos, we find ourselves besieged by relentless Char invaders. " +
                                       "It is now your moment to shine, to demonstrate your prowess in the art of combat, and to vanquish these intergalactic foes. " +
                                       "Ready your weapons and prepare for battle!",
                                       "Pilot! You've pulled off an epic maneuver, " + 
                                       "slicing through those Char Invaders like a hot knife through butter! " + 
                                       "Your flying were out of this world! Let's keep the lunar base safe from those pesky invaders. " +
                                       "We're counting on you to be our hero in the universe!"
                                      };
    string textToType;
    private TMP_Text description;
    private int activeScreenidx;

    void Awake()
    {
        activeScreenidx = SceneManager.GetActiveScene().buildIndex;
        if (activeScreenidx == 0)
        {
            textToType = textToTypeList[0];
        } else if (activeScreenidx == 2)
        {
            textToType = textToTypeList[1];
        }

        description = GetComponent<TMP_Text>();
    }
    void Start()
    {
        StartCoroutine(TypeTextCO());
    }

    IEnumerator TypeTextCO()
    {
        description.text = string.Empty;
        for (int i = 0; i < textToType.Length; i++)
        {
            description.text += textToType[i];
            yield return new WaitForSeconds(0.05f);
        }

        if (activeScreenidx == 2)
        {
            // Trigger Credits Updates
        }
        yield return null;
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }
    
}
