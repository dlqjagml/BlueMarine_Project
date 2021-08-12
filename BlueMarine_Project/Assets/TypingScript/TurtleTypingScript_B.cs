﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;   

public class TurtleTypingScript_B : MonoBehaviour
{
    // Start is called before the first frame update

    public Text tx2;
    private string m_text2 = "연간 1,200만 톤의 플라스틱이 바다로 유입됩니다. 대부분의 해양 플라스틱은 육상의 생활 쓰레기나 산업 폐기물로 부터 유입됩니다.바다의 플라스틱은 모든 해양생물에게 악영향을 미칩니다. 비닐봉지가 해파리인줄알고 삼키는 고래의 뱃속에는 100kg에 달하는 플라스틱, 끈, 비닐봉지가 나왔습니다.";

    void Start()
    {
         StartCoroutine(typing());
    }

     IEnumerator typing()
    {
        yield return new WaitForSeconds(2f);

        for(int i = 0; i < m_text2.Length; i++)
        {
            tx2.text = m_text2.Substring(0,i);
            yield return new WaitForSeconds(0.15f);
        }
        
    }
}