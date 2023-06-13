using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Destroy3 : MonoBehaviour
{
    public GameObject[] Object;
    public GameObject ma;
    int i = 0;
    private Joystick b;
    Joystick m;
    void Start()
    {
        b = FindObjectOfType<Joystick>();
    }
    private void Awake()
    {
        m = GameObject.Find("Image1").GetComponent<Joystick>();

    }
    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D other)
    {
        {
            if (other.gameObject.tag.Equals("enemy"))
            {
                if (i == 2)
                    SceneManager.LoadScene("gameover");
                else
                {
                    Object[i].SetActive(false);  //  Destroy(Object[i]);
                    i++;
                }
                Destroy(other.gameObject);

            }
            else if (other.gameObject.tag.Equals("batteryItem1"))
            {
                Destroy(other.gameObject);
                if (i == 0) return;
                i--;
                Object[i].SetActive(true);
            }
            else if (other.gameObject.tag.Equals("home"))
            {
                DataController.SaveGameData();
                SceneManager.LoadScene("ending");
            }
            else if (other.gameObject.tag.Equals("joy"))
            {
                m.a = false;
                Destroy(other.gameObject);
            }
        }
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "batteryItem1")
        {
            Destroy(coll.gameObject);

            Vector2 vector;
            vector = transform.position;
            vector.x = 4.76f;
            vector.y = 4.25f;
            transform.position = vector;
            ma.GetComponent<SpriteRenderer>().flipX = true;
             
        }
    }

    void Update()
    {

    }

}
