using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{
    private void Awake()
    {
        
    }
    
    public void OnStartButton()
    {
        //메인 씬으로 이동
        SceneManager.LoadScene("MainScene");
    }
}
