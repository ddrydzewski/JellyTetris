using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScript : MonoBehaviour
{

    public bool EndRound { get; set; }
    public bool CanPlayerTouch { get; set; }
    public bool PlayerTouchNow { get; set; }
    public bool GameStart { get; set; }

    public PrepareGame Prepare;
    public UIStuff UiStuff;

    public GameObject ChoseStuffGameObject;
    public GameObject MainGameObject;

    void Start()
    {
        EndRound = false;
        CanPlayerTouch = true;
        PlayerTouchNow = false;
        GameStart = false;

        Prepare = new PrepareGame();
        MainGameObject.gameObject.SetActive(false);


        UiStuff.PlayerRotationSlider.onValueChanged.AddListener(SetRotation);
        UiStuff.PlayerFallSpeedSlider.onValueChanged.AddListener(SetFallSpeed);
        UiStuff.PlayerBlockAmountSlider.onValueChanged.AddListener(SetBlockAmount);
        UiStuff.PlayerBombsAmountSlider.onValueChanged.AddListener(SetBombsAmount);
        UiStuff.PlayerBlockSizeXSlider.onValueChanged.AddListener(SetSizeX);
        UiStuff.PlayerBlockSizeYSlider.onValueChanged.AddListener(SetSizeY);
    }

    public void StartGameButton()
    {
        ChoseStuffGameObject.gameObject.SetActive(false);
        MainGameObject.gameObject.SetActive(true);
        GameStart = true;
    }

    void Update()
    {
        for (int i = 0; i < UiStuff.TextList.Count - 2; i++)
        {

            UiStuff.TextList[i].text = ((int)(Prepare.SettingsList[i])).ToString();
        }

        UiStuff.TextList[4].text = Prepare.SettingsList[4].ToString();
        UiStuff.TextList[5].text = Prepare.SettingsList[5].ToString();
    }

    public void SetRotation(float value) { Prepare.SettingsList[0] = value; }

    public void SetFallSpeed(float value) { Prepare.SettingsList[1] = value; }

    public void SetBlockAmount(float blockamount) { Prepare.SettingsList[2] = (int)blockamount; }

    public void SetBombsAmount(float bombsamount) { Prepare.SettingsList[3] = (int)bombsamount; }

    public void SetSizeX(float sizex) { Prepare.SettingsList[4] = sizex; }

    public void SetSizeY(float sizey) { Prepare.SettingsList[5] = sizey; }
}
