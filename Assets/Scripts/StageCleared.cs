using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StageCleared : MonoBehaviour
{

    // Start is called before the first frame update
    private void Start()
    {
        if(DataController.gameData.num == 2)
        {
            SceneManager.LoadScene("chapter2");
        }
        else if(DataController.gameData.num == 3)
        {
            SceneManager.LoadScene("chapter3");
        }
    }
}