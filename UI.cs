using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    string textToType = "Hello Player. Welcome to 2499 spaceship..." +
                        "We are now suffering from Char invaders attack." +
                        "Show us your ability to destroy all the Char invaders!";
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
