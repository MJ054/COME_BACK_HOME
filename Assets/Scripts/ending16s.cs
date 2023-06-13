using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ending16s : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(_typing2());
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator _typing2()
    {
        yield return new WaitForSeconds(10f);
        SceneManager.LoadScene("ending17");

    }
}
