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
        //���� ������ �̵�
        SceneManager.LoadScene("MainScene");
    }
}
