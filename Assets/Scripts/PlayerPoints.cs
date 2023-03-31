using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerPoints : MonoBehaviour
{
    public GameObject gameOver;
    private int playerScore = 0;
    public TextMeshProUGUI scoreText;

    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
    if (other.CompareTag("Coin"))
    {
        playerScore += 1;
        scoreText.text = "Score: " + playerScore;
        other.gameObject.SetActive(false);
    }
    }
}
