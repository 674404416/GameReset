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

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        leftAttack = rightAttack = false;
        Horizontal = Input.GetAxis("Horizontal");
        Vertical = Input.GetAxis("Vertical");
        if (Input.GetButton("Fire1"))
        {
            leftAttack = true;
        }

        if (Input.GetButton("Fire2"))
        {
            rightAttack = true;
        }
    }
}