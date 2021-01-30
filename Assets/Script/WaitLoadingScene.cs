using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

/// <summary>
/// 每个场景都要有该脚本，黑屏背景显示
/// </summary>

public class WaitLoadingScene : MonoBehaviour
{
    private Image img_blackBg;
    private Text txt_message;



    private void Awake()
    {
        img_blackBg = transform.Find("img_blackBg").GetComponent<Image>();
        txt_message = transform.Find("txt_message").GetComponent<Text>();
    }


    void Start()
    {
        
    }


    void Update()
    {
        
    }


    // 切黑屏，
    public void ShowImg()
    {
        img_blackBg.gameObject.SetActive(true);
        img_blackBg.color = new Color(img_blackBg.color.r, img_blackBg.color.b, img_blackBg.color.g, 0);
        img_blackBg.DOColor(new Color(img_blackBg.color.r, img_blackBg.color.b, img_blackBg.color.g, 1), 2f);
    }
    
    // 切“白”屏
    public void FadeImg()
    {
        img_blackBg.color = new Color(img_blackBg.color.r, img_blackBg.color.b, img_blackBg.color.g, 1);
        img_blackBg.DOColor(new Color(img_blackBg.color.r, img_blackBg.color.b, img_blackBg.color.g, 0), 2f).OnComplete(() =>
        {
            img_blackBg.gameObject.SetActive(false);
        });

    }


    // 有可能黑屏后会显示一些文字信息
    public void ShowTxt()
    {
        ShowImg();
        txt_message.gameObject.SetActive(true);
        txt_message.color = new Color(txt_message.color.r, txt_message.color.b, txt_message.color.g, 1);
    }

    // 文本渐渐消失
    public void FadeTxt()
    {
        txt_message.color = new Color(txt_message.color.r, txt_message.color.b, txt_message.color.g, 1);
        txt_message.DOColor(new Color(txt_message.color.r, txt_message.color.b, txt_message.color.g, 0), 2f).OnComplete(() =>
        {
            txt_message.gameObject.SetActive(true);
        });
    }
}
