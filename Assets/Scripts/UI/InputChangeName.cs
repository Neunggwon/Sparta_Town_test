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

    //InputField�� ������ ��ȭ�� ���� ��
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
