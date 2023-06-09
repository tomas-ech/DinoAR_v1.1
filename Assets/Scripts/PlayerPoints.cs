using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerPoints : MonoBehaviour
{
    private int playerScore = 0;
    public TextMeshProUGUI scoreText;
    public AudioSource playSound;

    
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
        playSound.Play();
        playerScore += 1;
        scoreText.text = "Score: " + playerScore;
        other.gameObject.SetActive(false);
    }
    }
}
