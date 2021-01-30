using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tes1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameEvent.RegistryEvent(TEventType.TestOne,test,this);
        GameEvent.FireEvent(TEventType.TestOne);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(t2.I.a);
    }

    public void test(object[] args)
    {
        Debug.Log("ceshichenggong");
    }
}
