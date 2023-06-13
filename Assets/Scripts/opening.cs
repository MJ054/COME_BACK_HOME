using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class opening : MonoBehaviour
{

    private PlayerManager thePlayer;
    public Text tx;
    //public Text tx2;
    //private string c_text = thePlayer.characterName;
    private string s_text = " 안녕하세요.\n\n 2190년 2월 25일 15시 55분, 부팅을 시작합니다...";
    // Start is called before the first frame update

    void Start()
    {
        thePlayer = FindObjectOfType<PlayerManager>();

            StartCoroutine(_typing()); 
    }

    void Update()
    {

        /*if (Input.GetKeyDown(KeyCode.Return))
        {
           // thePlayer.characterName = tx2.text;
            Destroy(this.gameObject);
            // SceneManager.LoadScene("opening");
        }*/

    }

    IEnumerator _typing()
    {
        yield return new WaitForSeconds(5f);

        for (int i = 0; i <= s_text.Length; i++)
        {
            tx.text = s_text.Substring(0, i);
            yield return new WaitForSeconds(0.1f);
        }

        yield return new WaitForSeconds(2f);

    }
    // Update is called once per frame
   
}

