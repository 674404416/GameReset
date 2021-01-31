using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectController : MonoBehaviour
{
    // Start is called before the first frame update
    private float scaleMax = 1.2f;
    private float scaleTime = 0.25f;
    private float countTime;
    private bool isMouseOver = false;
    public GameObject textBox;
    private void Awake()
    {
    }
    void Start()
    {
        
    }
    //触发交互开关
    private void OnMouseOver()
    {
        isMouseOver = true;
    }
    //恢复初始化条件
    private void OnMouseExit()
    {
        isMouseOver = false;
        gameObject.transform.localScale = new Vector2(1, 1);
        countTime = 0;
    }

    private void OnMouseDown()
    {
        textBox.SetActive(true);
    }

    private void FixedUpdate()
    {
        if (isMouseOver)
        {
            WhenMouseOnEf();
        }
    }

    // Update is called once per frame




    //放大效果
    private void WhenMouseOnEf() {
        if(countTime< scaleTime)
        {
            countTime += Time.fixedDeltaTime;
            gameObject.transform.localScale = new Vector2(1+(scaleMax-1)/scaleTime* countTime, 1+(scaleMax - 1) / scaleTime * countTime);
        }
    }


}
