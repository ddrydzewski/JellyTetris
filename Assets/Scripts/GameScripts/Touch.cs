using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Touch : MonoBehaviour
{

    public CreateBlocks Create;
    public MainScript Main;
    public Explosion Boom;
    public UIStuff UiStuff;
    public SaveOptions SaveLoadOptions;

    void Update()
    {
        if (Main.EndRound == true)
        {
            UiStuff.RestartButton.gameObject.SetActive(true);
        }

        UiStuff.BombsLefText.text = "Bombs Left: " + ((int)Main.Prepare.SettingsList[3] - Boom.BombCount).ToString();

        if ((int)Main.Prepare.SettingsList[3] <= Boom.BombCount)
            UiStuff.ActiveBoomButton.gameObject.SetActive(false);
    }

    IEnumerator WaitLittle()
    {
        yield return new WaitForSeconds(0.4f);
        Main.Prepare.BlockIndex++;
        Create.CreateBlock();
        Main.CanPlayerTouch = true;
    }

    public void Fall()
    {
        if (Main.CanPlayerTouch == true && Main.Prepare.BlockIndex < (int)Main.Prepare.SettingsList[2])
        {

            Create.AllBlocks[Main.Prepare.BlockIndex].GetComponent<Rigidbody2D>().mass = 1;
            Create.AllBlocks[Main.Prepare.BlockIndex].GetComponent<Rigidbody2D>().gravityScale = 1;

            Create.AllBlocks[Main.Prepare.BlockIndex].GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            Create.AllBlocks[Main.Prepare.BlockIndex].GetComponent<Rigidbody2D>().velocity -= new Vector2(0, (int)Main.Prepare.SettingsList[1]);

            Create.AllBlocks[Main.Prepare.BlockIndex].GetComponent<BlockScript>().PlayerDropThisBlock = true;
            Main.CanPlayerTouch = false;

            StartCoroutine(WaitLittle());
        }
    }

    public void Reset()
    {
        SaveLoadOptions.Save();
        SceneManager.LoadScene("GameScene");
        SaveLoadOptions.Load();
        Main.ChoseStuffGameObject.SetActive(false);
        Main.MainGameObject.SetActive(true);
    }

    public void ChangeOptions()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void UseBomb()
    {
        if ((int)Main.Prepare.SettingsList[3] > Boom.BombCount)
            Boom.AndNowMakeBoom();
    }

}
