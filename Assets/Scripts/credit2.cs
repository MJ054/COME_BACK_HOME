using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class credit2 : MonoBehaviour
{
    public Text ex;
    private string s_text = " \n Story & Develop 공세정(Sejung Kong) \n Graphic & Develop 이수정 (Sujeong Lee), 정시현 (Sihyun Jung) \n Develop 강민지 (Minji Kang), 이혜원 (Hyewon Lee)";
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(_typing());

    }

    IEnumerator _typing()
    {

        yield return new WaitForSeconds(0.8f);
        yield return new WaitForSeconds(1f);
        for (int i = 0; i <= s_text.Length; i++)
        {
            ex.text = s_text.Substring(0, i);
            yield return new WaitForSeconds(0.08f);
        }

        yield return new WaitForSeconds(2f);
        //  SceneManager.LoadScene("chapter1");

    }
    // Update is called once per frame
    void Update()
    {

    }
}
