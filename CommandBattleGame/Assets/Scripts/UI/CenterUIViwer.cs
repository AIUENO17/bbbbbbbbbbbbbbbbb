﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CenterUIViwer : MonoBehaviour
{

    public Button[] CharacterActionButtons = new Button[4];
    public bool CenterUIVisible = false;


    public bool CheckCenterUIVisible(float gaugeRate)
    {
        return gaugeRate >= 1f;
    }

    public void SetCenterUIVisible(bool active)
    {
        this.gameObject.SetActive(active);
    }

    public void SetCharacterActionButtons(CharacterParam characterParam)
    {
        for (int i = 0; i < CharacterActionButtons.Length; i++)
        {
            CharacterActionButtons[i].onClick.RemoveAllListeners();
        }
        //ラムダ式　０ボタンを押した時何をしますかと聞いている 無記名関数
        CharacterActionButtons[0].onClick.AddListener(() =>
        {
            characterParam.FirstButtonAction();
        });
        
        CharacterActionButtons[1].onClick.AddListener(() => characterParam.SecondButtonAction());
        CharacterActionButtons[2].onClick.AddListener(() => characterParam.ThirdButtonAction());
        CharacterActionButtons[3].onClick.AddListener(() => characterParam.FourthButtonAction());


    }
}
