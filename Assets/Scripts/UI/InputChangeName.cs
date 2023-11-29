using System.Collections;
using System.Collections.Generic;
using TMPro;
using TMPro.EditorUtilities;
using UnityEngine;
using UnityEngine.UI;

public class InputChangeName : MonoBehaviour
{
    [SerializeField]
    private TMP_InputField inputField;
    [SerializeField]
    private TMP_Text playerNameText;

    public GameObject ChangeNamePanel;

    private void Awake()
    {
        inputField.onValueChanged.AddListener(OnValueChanged);
        inputField.onEndEdit.AddListener(OnEndEdit);
        inputField.onSelect.AddListener(OnSelect);
        inputField.onDeselect.AddListener(OnDeselect);
    }

    //InputField의 데이터 변화가 있을 때
    public void OnValueChanged(string str)
    {
        //text.text = $"이름 : {str}";
        playerNameText.text = str;
    }

    public void OnEndEdit(string str)
    {
        //text.text = $"이름 : {str}";
        playerNameText.text = str;
    }

    public void OnDeselect(string str)
    {
        //text.text = $"이름 : {str}";
        playerNameText.text = str;
    }

    public void OnSelect(string str)
    {
        playerNameText.text = str;
    }



    //창 닫음
    public void DisabledButton()
    {
        ChangeNamePanel.gameObject.SetActive(false);
    }
    //창 오픈
    public void ActivateButton()
    {
        ChangeNamePanel.gameObject.SetActive(true);
    }
}
