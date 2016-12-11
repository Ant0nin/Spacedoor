﻿using System;
using UnityEngine;

public class OpenableDoor : InteractiveObject
{
    public float speed = 0.01f;
    
    private bool b_translateToTarget = false;
    private Vector3 startPosition;
    private Vector3 endPosition;
    private float t = 0.0f;

    protected new void Start()
    {
        base.Start();
        Transform targetTransform = transform.GetChild(0);
        startPosition = transform.position;
        endPosition = targetTransform.position;
    }

    public override void OnFocus(PlayerController playerCtrl)
    {
        this.ui.SetInteractionInfo(ControlDesc.INTERACT + " Open " + objectName);
    }

    public override void OnTrigger(PlayerController playerCtrl)
    {
        b_translateToTarget = true;
    }

    void Update()
    {
        if(b_translateToTarget)
        {
            t += speed;
            transform.position = Vector3.Lerp(startPosition, endPosition, t);
        }
    }
}