using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenechange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("2");
        }*/
    }

    public void ButtonClick()
    {
        DataController.LoadGameData();

        if (DataController.gameData.num == 1)
        {
            SceneManager.LoadScene("op3");
        }
        else if (DataController.gameData.num == 2)
        {
            SceneManager.LoadScene("chapter2");
        }
        else if (DataController.gameData.num == 3)
        {
            SceneManager.LoadScene("chapter3");
        }
    }



    
}
