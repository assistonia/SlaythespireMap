using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackMain : MonoBehaviour
{
    // Start is called before the first frame update
    public void SceneChange()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void GoInternet()
    {
        UnityEngine.Application.OpenURL("http://www.naver.com"); // 원하는 웹사이트 주소를 입력하세요
    }
}
