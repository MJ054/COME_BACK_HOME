using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Destroy2 : MonoBehaviour
{
    public GameObject[] Object;
    public GameObject ma;
    int i = 0;
    private Joystick b;
    Joystick m;
    private PlayerManager thePlayer;
    PlayerManager t;
    void Start()
    {
        thePlayer = FindObjectOfType<PlayerManager>();

        b = FindObjectOfType<Joystick>();
    }
    private void Awake()
    {
        m = GameObject.Find("Image1").GetComponent<Joystick>();
        t = GameObject.Find("player1").GetComponent<PlayerManager>();

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
                if (DataController.gameData.num < 3)
                    DataController.gameData.num = 3;
                if (DataController.gameData.num == 3)
                {
                    DataController.SaveGameData();
                    SceneManager.LoadScene("chapter3");
                }
            }
            else if (other.gameObject.tag.Equals("joy"))
            {
                m.a = false;
                Destroy(other.gameObject);
            }
        }
    }

    //Imgae Flip
    void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.gameObject.tag == "batteryItem1")
        {
            Vector2 vector;
            vector = transform.position;
            vector.x = 4.76f;
            vector.y = 4.25f;
            transform.position = vector;
            ma.GetComponent<SpriteRenderer>().flipX = true;
            Destroy(coll.gameObject);
        
        }
    }

    void Update()
    {

    }

}
