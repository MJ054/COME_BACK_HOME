using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Destroy : MonoBehaviour
{
    public GameObject[] Object;
    int i = 0;
 
    void Start()
    {
        
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
                if (DataController.gameData.num< 2)
                    DataController.gameData.num = 2;
                if(DataController.gameData.num == 2)
                {
                    DataController.SaveGameData();
                    SceneManager.LoadScene("chapter2");
                }
                else if (DataController.gameData.num == 3)
                {
                    DataController.SaveGameData();
                    SceneManager.LoadScene("chapter3");
                }
            }
        }
 
    }

    void Update() {
         
    }

}
