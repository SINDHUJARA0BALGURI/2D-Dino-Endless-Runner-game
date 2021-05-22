using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    Material bgMat;
    public float xOffset;
    private PlayerMovement PlayerMovementScript;
    // Start is called before the first frame update
    void Start()
    {
        bgMat = GetComponent<MeshRenderer>().material;
        PlayerMovementScript = GameObject.Find("Player").GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        if (PlayerMovementScript.gameOver == false)
        {
            bgMat.mainTextureOffset = new Vector2(xOffset * Time.time, 0);
        }
    }
}
