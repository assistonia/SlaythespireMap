using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainPlayButton : MonoBehaviour
{
    // Start is called before the first frame update
    public void ScenceChange()
    {
        SceneManager.LoadScene("Mapsample");
    }

    public void MakeCardChange()
    {
        SceneManager.LoadScene("MakeCardScence");
    }

    public void Gocredit()
    {
        SceneManager.LoadScene("EndingCredit");
    }

    public void GoInternet()
    {
        UnityEngine.Application.OpenURL("https://testnets.opensea.io/asset/create"); // 원하는 웹사이트 주소를 입력하세요
    }
}
