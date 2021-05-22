using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed;
    Rigidbody2D ObstacleRB;
    private PlayerMovement PlayerMovementScript;

    // Start is called before the first frame update
    void Start()
    {
        ObstacleRB = GetComponent<Rigidbody2D>();
        PlayerMovementScript = GameObject.Find("Player").GetComponent<PlayerMovement>();

    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerMovementScript.gameOver == false)
        {
            ObstacleRB.velocity = Vector2.left * speed;
        }
            
        if (transform.position.x < -12.0f)
        {
            Destroy(gameObject);
        }
    }
}
