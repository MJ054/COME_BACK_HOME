using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class lastlast : MonoBehaviour
{
    public Text ex;
    private string s_text = " 사용자 인식 불가. \n 사용자의 명령이 입력될 때까지 대기합니다... ";
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(_typing());

    }

    IEnumerator _typing()
    {
        yield return new WaitForSeconds(1f);
        for (int i = 0; i <= s_text.Length; i++)
        {
            ex.text = s_text.Substring(0, i);
            yield return new WaitForSeconds(0.15f);
        }

        yield return new WaitForSeconds(2f);
        //  SceneManager.LoadScene("chapter1");

    }
    // Update is called once per frame
    void Update()
    {

    }
}
