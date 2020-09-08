using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrepareGame {

    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    /// PLAYER PREF ///
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    public float F_PlayerRotation { get; set; }
    public float F_PlayerFallSpeed { get; set; }
    public float F_PlayerBlockSizeX { get; set; }
    public float F_PlayerBlockSizeY { get; set; }

    public int I_PlayerBlockAmount { get; set; }
    public int I_PlayerBombsAmount { get; set; }

    public List<float> SettingsList { get; set; }

    public int BlockIndex { get; set; }

    public PrepareGame()
    {
        /// Player Chose
        F_PlayerRotation = 0;
        F_PlayerFallSpeed = 5;
        F_PlayerBlockSizeX = 0.5f;
        F_PlayerBlockSizeY = 0.5f;

        I_PlayerBlockAmount = 15;
        I_PlayerBombsAmount = 0;

        /// Basic Stuff
        BlockIndex = 0;

        SettingsList = new List<float>
        {
           F_PlayerRotation,
           F_PlayerFallSpeed,
           I_PlayerBlockAmount,
           I_PlayerBombsAmount,

           F_PlayerBlockSizeX,
           F_PlayerBlockSizeY
        };

    }
}
