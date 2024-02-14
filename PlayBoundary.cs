using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayBoundary : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float playerX = transform.position.x;
        float playerY = transform.position.y;

        if (playerX <= -260)
        {
            transform.SetPositionAndRotation(new Vector3(-260, playerY, 0), Quaternion.identity);
        }

        if (playerX >= 213)
        {
            transform.SetPositionAndRotation(new Vector3(213, playerY, 0), Quaternion.identity);
        }

        if (playerY <= -310)
        {
            if (gameObject.CompareTag("Enemy"))
            {
                Destroy(gameObject);
            }
            transform.SetPositionAndRotation(new Vector3(playerX, -310, 0), Quaternion.identity);
        }

        if (playerY >= 370)
        {
            transform.SetPositionAndRotation(new Vector3(playerX, 370, 0), Quaternion.identity);
            if (gameObject.CompareTag("Shot"))
            {
                Destroy(gameObject);
            }
        }
    }
}
