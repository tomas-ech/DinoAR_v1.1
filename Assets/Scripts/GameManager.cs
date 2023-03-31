using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    int points = 1;
    public TextMeshProUGUI score;


    
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }

    private void OnDestroy() {
        points += 1;
        score.text = "Score: " + points.ToString();
    }
}
