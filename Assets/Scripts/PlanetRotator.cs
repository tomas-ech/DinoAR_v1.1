using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlanetRotator : MonoBehaviour
{
    public float rotatorSpeed;
    public CapsuleCollider capsuleCollider;
    
    void Start()
    {
        capsuleCollider = GetComponent<CapsuleCollider>();
        capsuleCollider.enabled = true;
    }

    
    void Update()
    {
        transform.Rotate(new Vector3(1f, 1f, 1f) * rotatorSpeed);
        
    }

    private void OnTriggerEnter(Collider other) {
    if (other.CompareTag("Coin"))
    {
        other.gameObject.SetActive(false);
        SceneManager.LoadScene("GameOver");
    }
    }
}
