using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] obstacles;
    int value;
    private PlayerMovement PlayerMovementScript;

    private void Start()
    {
        
        InvokeRepeating("Spawn", 2.0f, 3.0f);
        PlayerMovementScript = GameObject.Find("Player").GetComponent<PlayerMovement>();
    }


    void Spawn()
    {
        value = Random.Range(0, obstacles.Length);
        if(PlayerMovementScript.gameOver==false)
        Instantiate(obstacles[value],transform.position,Quaternion.identity);

    }
}




