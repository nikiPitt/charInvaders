using UnityEngine;


public class Player : MonoBehaviour
{
    public int score = 0;

    public void GetPoints(int p)
    {
        score += p;
    }
}
