using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InputNickName : MonoBehaviour
{
    [SerializeField]
    private TMP_InputField inputField;
    //[SerializeField]
    //private Text text;
    [SerializeField]
    private TextMeshProUGUI text;

    private void Awake()
    {
        inputField.onValueChanged.AddListener(OnVlaueChangedEvent);
        inputField.onEndEdit.AddListener(OnEndEditEvent);
        inputField.onSelect.AddListener(OnSelectEvent);
        inputField.onDeselect.AddListener(OnDeselectEvent);
    }
    public void OnVlaueChangedEvent(string str)
    {
        text.text = $"Value Changed : {str}";
    }

    public void OnEndEditEvent(string str)
    {
        text.text = $"End Edit : {str}";
    }

    public void OnSelectEvent(string str)
    {
        text.text = $"Select : {str}";
    }

    public void OnDeselectEvent(string str)
    {
        text.text = $"Deselect : {str}";
    }
    //public string playerName;
    //private string inputName;
    //public InputField playerNameInput;

    //private void Awake()
    //{
    //    playerName = playerNameInput.GetComponent<InputField>().text;
    //}

    //public void InputName()
    //{
    //    playerName = playerNameInput.text;

    //}
    //void Start()
    //{

    //}

    //// Update is called once per frame
    //void Update()
    //{

    //}
    //private void InputNameBottun()
    //{
    //    //버튼을 누르면 입력한 이름을 적용시키고
    //    //메인씬으로 이동
    //    if (playerName.Length > 2 && Input.GetKeyDown(KeyCode.Return))
    //    {
    //        InputName();
    //    }
    //}
}
