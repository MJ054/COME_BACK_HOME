using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class name : MonoBehaviour
{
    public Text text;
    private PlayerManager thePlayer;
    PlayerManager m;
    // Start is called before the first frame update
    private void Awake()
    {
        m = GameObject.Find("virus").GetComponent<PlayerManager>();

    }
    void Start()
    {
        thePlayer = FindObjectOfType<PlayerManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            thePlayer.characterName = text.text;
            Destroy(this.gameObject);
            Destroy(m.gameObject);
            //SceneManager.LoadScene("chapter");
            m.input = true;
        }
    }


}