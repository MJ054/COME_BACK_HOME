using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Reflection.Emit;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class te2 : MonoBehaviour
{
    public Text tx;
    private PlayerManager thePlayer;
    private string s_text = " 님 안녕하세요.\n\n 2190년 2월 25일 15시 55분, 부팅을 시작합니다...";
    PlayerManager m_text;
    private void Awake()
    {
        m_text = GameObject.Find("virus").GetComponent<PlayerManager>();

    }

    // Start is called before the first frame update
    void Start()
    {
        thePlayer = FindObjectOfType<PlayerManager>();

    }

    IEnumerator _typing()
    {
         
        string  text = m_text.characterName + s_text;
        for (int i = 0; i <= text.Length; i++)
        {
            tx.text = text.Substring(0, i);
            yield return new WaitForSeconds(0.1f);
        }
        yield return new WaitForSeconds(1f);

        SceneManager.LoadScene("error");


        /*for(int j = 0; j < 10000; j++)
        {
            Debug.Log("|");

        }*/
    }


    // Update is called once per frame
    void Update()
    {
        if (m_text.input == true)
        {
            StartCoroutine(_typing());
            m_text.input = false;
        }
 
    }
}