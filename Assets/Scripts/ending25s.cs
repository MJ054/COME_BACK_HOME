using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ending25s : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(_typing());
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator _typing()
    {
        yield return new WaitForSeconds(6f);
        qqqqqqqqq.num = 1;

        SceneManager.LoadScene("1");

    }
}
