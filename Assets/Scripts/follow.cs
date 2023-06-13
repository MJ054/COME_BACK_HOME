using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;
// ? 2017 TheFlyingKeyboard and released under MIT License
// theflyingkeyboard.net
public class follow : MonoBehaviour
{
    public GameObject target;
    public float moveSpeed;
    public float rotationSpeed;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float distance = Vector3.Distance(target.transform.position, transform.position);
        if (distance <= 6.0f)
            transform.position = Vector3.MoveTowards(transform.position, target.transform.position, moveSpeed * Time.deltaTime); 
    

        
    }
}