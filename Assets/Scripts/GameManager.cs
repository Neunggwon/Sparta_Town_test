using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameManager instance = null;

    //[Header("# Player Info")]
    //public int playerId;

    //[Header("# InputChangeName")]
    //[SerializeField]
    //private TMP_InputField inputField;
    //[SerializeField]
    //private TMP_Text text;
    //[SerializeField]
    //private TMP_Text playerText;

    //public GameObject ChangeNameButton;
    //public GameObject ChangeNamePanel;


    //[Header("# InputChangeCharacter")]
    //public Player player;
    //public Animator anim;
    //public RuntimeAnimatorController[] animCon;

    //public GameObject ChangeCharacterButton;
    //public GameObject ChangeCharacterPanel;



    private void Awake()
    {
        if (null == instance)
        {
            instance = this;

            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
        //inputField.onValueChanged.AddListener(OnValueChanged);
        //inputField.onSubmit.AddListener(OnSubmit);
        //inputField.onEndEdit.AddListener(OnEndEdit);

        //anim = GetComponent<Animator>();
    }

    //InputChangeName
    //public void OnValueChanged(string str)
    //{
    //    //text.text = $"이름 : {str}";
    //    playerText.text = str;
    //}

    //public void OnSubmit(string str)
    //{
    //    //text.text = $"이름 : {str}";
    //    playerText.text = str;
    //}

    //public void OnEndEdit(string str)
    //{
    //    //text.text = $"이름 : {str}";
    //    playerText.text = str;
    //}

    //public void DisabledButton()
    //{
    //    ChangeNamePanel.gameObject.SetActive(false);
    //}
    //public void ActivateButton()
    //{
    //    ChangeNamePanel.gameObject.SetActive(true);
    //}

    ////InputChangeCharacter
    //public void PlayerID(int id)
    //{
    //    playerId = id;
    //}

    //public void SelectKnight()
    //{
    //    player.anim.runtimeAnimatorController = animCon[0];
    //    ChangeCharacterPanel.SetActive(false);
    //}
    //public void SelectElf()
    //{
    //    player.anim.runtimeAnimatorController = animCon[1];
    //    ChangeCharacterPanel.SetActive(false);
    //}

    public void TimeScale(float _timeScale)
    {
        Time.timeScale = _timeScale;
    }
}
