using UnityEngine;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour
{
    private int _score = 0;

    public void UpdateScore(Enemy e)
    {
        _score += e.point;
        Debug.Log(_score);
    }

    public int GetScore()
    {
        return _score;
    }

    private void finishGame()
    {
        SceneManager.LoadScene(2);
    }

    private void Update()
    {
        if (_score >= 1000)
        {
            finishGame();
        }
    }
}
