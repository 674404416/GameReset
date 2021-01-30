using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEvent
{
    static GameEvent()
    {
        m_Events = new Dictionary<object, Action<object[]>>[(int) TEventType.MaxEventNum];
    }

    public static void RegistryEvent(TEventType type, Action<object[]> callback, object listener)
    {
        var table = GetContainer(type);
        table[listener] += callback;
    }

    public static void FireEvent(TEventType type, params object[] args)
    {
        var table = m_Events[(int) type];
        foreach (var item in table)
        {
            item.Value.Invoke(args);
        }
    }

    private static Dictionary<object, Action<object[]>> GetContainer(TEventType type)
    {
        int typeId = (int) type;
        if (typeId < 0 || typeId > (int) TEventType.MaxEventNum)
            return null;

        var table = m_Events[typeId];
        if (table == null)
        {
            table = new Dictionary<object, Action<object[]>>();
            m_Events[typeId] = table;
        }

        return table;
    }

    private static Dictionary<object, Action<object[]>>[] m_Events;
}