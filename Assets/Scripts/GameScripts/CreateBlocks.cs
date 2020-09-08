using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateBlocks : MonoBehaviour
{

    public MainScript Main;

    public GameObject BlockPrefab;
    public GameObject[] AllBlocks;

    public Transform Parent;

    void Start()
    {
        AllBlocks = new GameObject[(int)Main.Prepare.SettingsList[2]];
        CreateBlock();
    }

    public void CreateBlock()
    {
        if (Main.Prepare.BlockIndex < (int)Main.Prepare.SettingsList[2])
        {
            AllBlocks[Main.Prepare.BlockIndex] = Instantiate(BlockPrefab, Parent, false) as GameObject; // Create from block prefab GameObjects in tab of Blocks
            AllBlocks[Main.Prepare.BlockIndex].GetComponent<Rigidbody2D>().rotation = Random.Range(0, 100); // Random rotation object to be always in diffrent position
            AllBlocks[Main.Prepare.BlockIndex].GetComponent<RectTransform>().localScale = new Vector2(Main.Prepare.SettingsList[4], Main.Prepare.SettingsList[5]); // Set Size
            AllBlocks[Main.Prepare.BlockIndex].GetComponent<BlockScript>().PlayerRotation = (int)Main.Prepare.SettingsList[0];
        }
        else
        {
            Main.EndRound = true;
        }
    }
}
