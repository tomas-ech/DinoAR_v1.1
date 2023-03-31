using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MeteorSpawner1 : MonoBehaviour
{
    public GameObject meteor;

    public float spawnLimitXLeft = -8f;
    public float spawnLimitXRight = 10f;  //se mueve en Z
    public float spawnPosZ = 0.06f;
    public Transform spawnerPos;

    private float startDelay = 3.0f;
    public GameObject[] fireBallPrefabs;
    public Transform parent;

    //public MoveToPlayer meteorScript;
    //public TextMeshProUGUI score;


    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnMeteor", startDelay);
    }

    private void Update()
    {
        /*int scorePoints = meteorScript.points;
        score.text = "Score:" + scorePoints.ToString();
        Debug.Log("Puntaje:" + scorePoints);*/
        
    }

    // Spawn random ball at random x position at top of play area
    void SpawnMeteor ()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), 0.04f, spawnPosZ);

        // instantiate ball at random spawn location
        int meteorIndex = Random.Range(0, fireBallPrefabs.Length);

        Instantiate(fireBallPrefabs[meteorIndex], (new Vector3((Random.Range(spawnLimitXLeft, spawnLimitXRight)), spawnerPos.position.y, spawnerPos.position.z)), fireBallPrefabs[meteorIndex].transform.rotation, parent);

        float spawnInterval = Random.Range(1, 3);

        Invoke("SpawnMeteor", spawnInterval);
    }
}
