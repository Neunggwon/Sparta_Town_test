using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;
using UnityEngine.UI;

public class LegacyInputNickName : MonoBehaviour
{
    [SerializeField]
    private InputField inputField;
    [SerializeField]
    private Text text;
    [SerializeField]
    private TMPro_TextContainerEditor playerText;

    public GameObject ChangesNamePanel;

    private void Awake()
    {
        inputField.onValueChanged.AddListener(OnValueChanged);
        inputField.onSubmit.AddListener(OnSubmit);
        inputField.onEndEdit.AddListener(OnEndEdit);
    }

    public void OnValueChanged(string str)
    {
        text.text = $"이름 : {str}";
        //playerText.text = str;
    }

    public void OnSubmit(string str)
    {
        text.text = $"이름 : {str}";
        //playerText.text = str;
    }

    public void OnEndEdit(string str)
    {
        text.text = $"이름 : {str}";
        //playerText.text = str;
    }

    public void DisabledButton()
    {
        ChangesNamePanel.gameObject.SetActive(false);
    }
    public void ActivateButton()
    {
        ChangesNamePanel.gameObject.SetActive(true);
    }

}
