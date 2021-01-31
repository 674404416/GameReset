using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcTalk : MonoBehaviour
{
    public float maxTalkDistance = 10f;
    public bool canTalk = false;
    public string[] content;

    private GameObject m_Hero;

    // Start is called before the first frame update
    void Start()
    {
        m_Hero = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(m_Hero.transform.position, transform.position) <= maxTalkDistance)
        {
            canTalk = true;
            GameEvent.RegistryEvent(TEventType.NpcTalk,Talk,this);
        }
        else
        {
            canTalk = false;
        }
    }

    private void Talk(object[] args)
    {
        //检查一下是否已经有了该对话框
        //如果没有就 加载一个通用对话框到屏幕上
        //然后内容放上去
        Debug.Log("说话");
    }
}