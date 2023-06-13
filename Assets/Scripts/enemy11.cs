using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy11 : MonoBehaviour
{
    int count = 0;
    bool p = true;
    public GameObject Character;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("move", 0, 0.018f);

    }

    // Update is called once per frame
    void Update()
    {

    }
    void move()
    {
        count++;
        float ff = p ? 0.05f : -0.05f;
        Character.transform.position += new Vector3(0, ff, 0);
        if (count > 170)
        {
            count = 0;
            p = !p;
        }
    }
}
