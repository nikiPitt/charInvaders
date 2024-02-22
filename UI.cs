using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    string textToType = "Greetings, Pilot! Welcome aboard the 2499 starship. " +
                        "As we traverse the cosmos, we find ourselves besieged by relentless Char invaders. " +
                        "It is now your moment to shine, to demonstrate your prowess in the art of combat, and to vanquish these intergalactic foes. " +
                        "Ready your weapons and prepare for battle!";
    private TMP_Text description;

    void Awake()
    {
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
        yield return null;
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }
    
}
