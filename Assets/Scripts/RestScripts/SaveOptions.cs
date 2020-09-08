using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveOptions : MonoBehaviour
{

    public MainScript Main;

    public void Save()
    {

        for (int i = 0; i < Main.Prepare.SettingsList.Count; i++)
        {
            PlayerPrefs.SetFloat("Player" + i, Main.Prepare.SettingsList[i]);
        }
    }

    public void Load()
    {
        for (int i = 0; i < Main.Prepare.SettingsList.Count; i++)
        {
            Main.Prepare.SettingsList[i] = PlayerPrefs.GetFloat("Player" + i);
        }
    }
}

