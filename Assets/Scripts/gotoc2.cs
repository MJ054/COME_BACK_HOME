using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gotoc2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void a()
    {
        if (DataController.gameData.num == 2)
            SceneManager.LoadScene("miro2");
        else if (DataController.gameData.num == 3)
            SceneManager.LoadScene("miro3");
        else
            SceneManager.LoadScene("miro1");
    }
}
