using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLose : MonoBehaviour
{
    public GameObject gameOver;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
    if (other.CompareTag("Player"))
    {
        gameOver.SetActive(true);
    }
    }
}
