using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoveToPlayer : MonoBehaviour
{
    public float speed; 

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0.00f, -0.53f, 0.00f) * speed * Time.deltaTime);
        Destroy(gameObject, 8f);        
    }

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Planet"))
        {
            Debug.Log("Chocante!");
            Destroy(gameObject);
        }
    }

    public void OnMouseDown()
    {
        if (gameObject.CompareTag("Coin"))
        {
            Destroy(gameObject);
        }

    }

}
