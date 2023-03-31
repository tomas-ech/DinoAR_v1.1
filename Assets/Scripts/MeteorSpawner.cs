using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MeteorSpawner : MonoBehaviour
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
        
    }

  
    void SpawnMeteor ()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), 0.04f, spawnPosZ);

        // instantiate ball at random spawn location
        int meteorIndex = Random.Range(0, fireBallPrefabs.Length);

        Instantiate(fireBallPrefabs[meteorIndex], (new Vector3((Random.Range(spawnLimitXLeft, spawnLimitXRight)), spawnerPos.position.y, spawnerPos.position.z)), fireBallPrefabs[meteorIndex].transform.rotation, parent);

        //random spawn time
        float spawnInterval = Random.Range(0.5f, 2f);

        Invoke("SpawnMeteor", spawnInterval);
    }
}
