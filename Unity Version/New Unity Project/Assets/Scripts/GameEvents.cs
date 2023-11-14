using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameEvents : MonoBehaviour
{
    [SerializeField] 
    private int round;

    private void Start()
    {
        StartLoadInAnimation();
    }

    // Update is called once per frame
    void Update()
    {
        GameObject roundText = GameObject.FindGameObjectWithTag("RoundText");
        roundText.GetComponent<Text>().text = string.Format(""+round+"");
    }

    
    /**
     * Methods.
     */
    void RoundIsOver()
    {
        round++;
        StartRoundSwitchAnimation();
    }

    void StartLoadInAnimation()
    {
        
    }
    
    void StartRoundSwitchAnimation()
    {
        
    }
}
