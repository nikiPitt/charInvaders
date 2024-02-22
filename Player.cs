using UnityEngine;


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
    
}
