using UnityEngine;

public class SimpleCharacterController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }
    public float PLAYER_SPEED = 200f;
    
    // Update is called once per frame
    void Update()
    {
        float moveX = 0f;
        float moveY = 0f;

        if (Input.GetKey(KeyCode.RightArrow))
        {
            moveX += PLAYER_SPEED;
        } 
        
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            moveX -= PLAYER_SPEED;
        }   
        
        if (Input.GetKey(KeyCode.UpArrow))
        {
            moveY += PLAYER_SPEED;
        }
        
        if (Input.GetKey(KeyCode.DownArrow))
        {
            moveY -= PLAYER_SPEED;
        }
        
        transform.Translate(new Vector2(moveX, moveY) * Time.deltaTime);
    }
}
