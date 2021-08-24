using UnityEngine;
using UnityEngine.SceneManagement;

public class Back : MonoBehaviour
{
    public void OnClick()
    {
        SceneManager.LoadScene("start");
    }
}
