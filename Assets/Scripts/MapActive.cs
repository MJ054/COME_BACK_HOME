using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class MapActive : MonoBehaviour
{
    public GameObject mapImage;

    void Start()
    {
        mapImage.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "MapActiveItem")
        {
            mapImage.SetActive(true);
            Destroy(coll.gameObject);
            Destroy(mapImage, 3);
        }
        else
        {
            mapImage.SetActive(false);
        }
    }
}
