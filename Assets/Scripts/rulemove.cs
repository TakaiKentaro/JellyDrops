using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class rulemove : MonoBehaviour
{
    private void Start()
    {
        // コルーチンの起動
        StartCoroutine(aaa());
    }
    private IEnumerator aaa()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("SampleScene");
    }
}
