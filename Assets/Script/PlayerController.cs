using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int maxSpeed = 10;

    private PlayerInput m_Input;
    private GameObject m_Camera;
    private GameObject m_Hero;

    // Start is called before the first frame update
    void Start()
    {
        m_Input = gameObject.GetComponent<PlayerInput>();
        m_Camera = GameObject.Find("Main Camera");
        m_Hero = gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        UpdatePosition();
        UpdateRotation();
        
        if (m_Input.leftAttack)
        {
            GameEvent.FireEvent(TEventType.NpcTalk);
        }
    }

    void UpdatePosition()
    {
        Vector3 newPosition = m_Hero.transform.position;
        newPosition += new Vector3(m_Input.Horizontal, m_Input.Vertical, 0) * (Time.deltaTime * maxSpeed);
        m_Hero.transform.position = newPosition;
    }

    // ReSharper disable Unity.PerformanceAnalysis
    void UpdateRotation()
    {
        if (m_Input.bRight) m_Hero.GetComponent<SpriteRenderer>().flipX = false;
        if (!m_Input.bRight) m_Hero.GetComponent<SpriteRenderer>().flipX = true;
    }
}