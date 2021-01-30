using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Single<T> : MonoBehaviour where T : new()
{
    public static T I
    {
        get
        {
            if (m_instance == null)
                m_instance = new T();
            return m_instance;
        }
    }

    private static T m_instance;
}