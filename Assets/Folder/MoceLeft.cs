using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoceLeft : MonoBehaviour
{
    [SerializeField] float speed = 30;
    PlayerController playerControllerScript;
    float leftBound = -50;

    private void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    void Update()
    {
       
        if(playerControllerScript.gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        if(transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}
