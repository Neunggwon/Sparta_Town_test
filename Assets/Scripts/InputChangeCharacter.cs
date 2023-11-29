using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputChangeCharacter : MonoBehaviour
{
    public Player player;
    public Animator anim;
    public RuntimeAnimatorController[] animCon;

    public GameObject ChangeCharacterPanel;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    public void ChangeCharacter(int ChNun)
    {
        switch (ChNun)
        {
            case 0:
                SelectKnight();
                break;
            case 1:
                SelectElf();
                break;
        }
    }
    public void SelectKnight()
    {
        player.anim.runtimeAnimatorController = animCon[0];
        ChangeCharacterPanel.SetActive(false);
    }
    public void SelectElf()
    {
        player.anim.runtimeAnimatorController = animCon[1];
        ChangeCharacterPanel.SetActive(false);
    }

    public void DisabledButton()
    {
        ChangeCharacterPanel.gameObject.SetActive(false);
    }
    //Ã¢ ¿ÀÇÂ
    public void ActivateButton()
    {
        ChangeCharacterPanel.gameObject.SetActive(true);
    }
}
