﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameHandler : MonoBehaviour
{
    public Text CoinText;
    public int Coins;
    // Start is called before the first frame update
        // Update is called once per frame
    void Update()
    {
        CoinText.text = "Coins : " + Coins;  
    }
}
