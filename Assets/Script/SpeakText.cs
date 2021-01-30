using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 文本显示
/// 挂在有Text的组件上使用
/// 其实这个脚本是多余的哈(测试用)，主要是Speak协程，其他脚本可以直接使用Speak()这个协程
/// </summary>

public class SpeakText : MonoBehaviour
{
    public string content;

    private Text text;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        text.text = "";
        StartCoroutine("Speak",content);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator Speak(string content)
    {
        yield return new WaitForSeconds(1.0f);
        for (int i = 0; i < content.Length; i++) {
            text.text += content[i];
            yield return new WaitForSeconds(0.15f);
        }
    }
}
