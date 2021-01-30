using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Vector3 Offset;
    private GameObject m_Target;
    // Start is called before the first frame update
    void Start()
    {
        m_Target = GameObject.Find("Player");
    }

    private void LateUpdate()
    {
        gameObject.transform.position = m_Target.transform.position + Offset;
    }
}
