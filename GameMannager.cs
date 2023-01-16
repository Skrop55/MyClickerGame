using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMannager : MonoBehaviour
{
    public static int moneyCount;
    public GameObject Money;
    public int IternalMoney;

    void Start()
    {
        moneyCount = 0;
    }

    void Update()
    {
        IternalMoney = moneyCount; 
        Money.GetComponent<Text>().text = "Money: " + moneyCount;
    }
}
