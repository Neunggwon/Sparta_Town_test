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
    private TMP_Text text;
    [SerializeField]
    private TMP_Text playerText;

    public GameObject ChangeNamePanel;

    private void Awake()
    {
        inputField.onValueChanged.AddListener(OnValueChanged);
        inputField.onEndEdit.AddListener(OnEndEdit);
        inputField.onSelect.AddListener(OnSelect);
        inputField.onDeselect.AddListener(OnDeselect);
    }

    public void OnValueChanged(string str)
    {
        //text.text = $"�̸� : {str}";
        playerText.text = str;
    }

    

    public void OnEndEdit(string str)
    {
        //text.text = $"�̸� : {str}";
        playerText.text = str;
    }

    public void OnDeselect(string str)
    {
        //text.text = $"�̸� : {str}";
        playerText.text = str;
    }

    public void OnSelect(string str)
    {
        playerText.text = str;
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
