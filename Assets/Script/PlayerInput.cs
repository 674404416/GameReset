using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.TerrainAPI;

public class PlayerInput : MonoBehaviour
{
    public float Horizontal = 0f;
    public float Vertical;
    public Vector2 movement;
    public Vector2 camerMovent;
    public bool leftAttack = false;
    public bool rightAttack = false;

    public bool banHor = false;
    public bool banVer = false;
    public bool bRight = true;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        leftAttack = rightAttack = false;
        if (!banHor)
        {
            Horizontal = Input.GetAxis("Horizontal");
            if (Horizontal < 0f) bRight = false;
            if (Horizontal > 0f) bRight = true;
        }

        if (!banVer) Vertical = Input.GetAxis("Vertical");
        if (Input.GetButtonDown("Fire1"))
        {
            leftAttack = true;
        }

        if (Input.GetButtonDown("Fire2"))
        {
            rightAttack = true;
        }
    }
}