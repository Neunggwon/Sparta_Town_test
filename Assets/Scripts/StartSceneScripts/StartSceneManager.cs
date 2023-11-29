using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class StartSceneManager : MonoBehaviour
{
    [SerializeField]
    private TMP_InputField inputField;
    [SerializeField]
    private TMP_Text text;
    [SerializeField]
    private TMP_Text playerNameText;

    public Button ChangeNameButton;
    public GameObject ChangeNamePanel;



    public void OnValueChanged(string str)
    {
        //text.text = $"�̸� : {str}";
        playerNameText.text = str;
    }

    public void OnEndEdit(string str)
    {
        //text.text = $"�̸� : {str}";
        playerNameText.text = str;
    }

    public void OnDeselect(string str)
    {
        //text.text = $"�̸� : {str}";
        playerNameText.text = str;
    }

    public void OnSelect(string str)
    {
        playerNameText.text = str;
    }



    //â ����
    public void DisabledButton()
    {
        ChangeNamePanel.gameObject.SetActive(false);
    }
    //â ����
    public void ActivateButton()
    {
        ChangeNamePanel.gameObject.SetActive(true);
    }
}
