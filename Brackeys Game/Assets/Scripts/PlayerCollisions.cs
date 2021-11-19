using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisions : MonoBehaviour
{
    private bool gameOver = false;
    private PlayerMovement playerMovement;
    private GameManager gameManager;

    private void Awake()
    {
        playerMovement = GetComponent<PlayerMovement>();
        gameManager = FindObjectOfType<GameManager>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == 6)
        {
            gameOver = true;
            playerMovement.enabled = false;
            gameManager.GameOver();
        }
    }
}
