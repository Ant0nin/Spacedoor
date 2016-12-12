﻿using System;
using UnityEngine;

public class TrapButton : InteractiveObject
{
    Game_Manager game;

    protected new void Start()
    {
        base.Start();
        game = GameObject.Find("GameManager").GetComponent<Game_Manager>();
    }

    public override void OnFocus(PlayerController playerCtrl)
    {
        this.ui.SetInteractionInfo(ControlDesc.INTERACT + " Push " + objectName);
    }

    public override void OnTrigger(PlayerController playerCtrl)
    {
        game.Lose();
    }
}