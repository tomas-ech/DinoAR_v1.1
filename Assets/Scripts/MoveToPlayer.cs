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
        transform.LookAt(new Vector3(0f, 0.0428f, 0f));
        GetComponent<Rigidbody>().velocity = transform.forward * -speed;
        //transform.Translate(new Vector3(0.00f, -0.53f, 0.00f) * speed * Time.deltaTime);
        Destroy(gameObject, 8f);        
    }

}
