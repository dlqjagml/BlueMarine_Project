﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class FourthCanvas2T : MonoBehaviour
{
    // Start is called before the first frame update

    public Text tx3;
    private string m_text3 = "나를 잘 따라와~~ 마지막 친구를 소개시켜줄게!! 화살표에 커서를 올려봥! ";
    void Start()
    {
         StartCoroutine(typing());
    }

     IEnumerator typing()
    {

        for(int i = 0; i < m_text3.Length; i++)
        {
            tx3.text = m_text3.Substring(0,i);
            yield return new WaitForSeconds(0.15f);
        }
        
    }
}