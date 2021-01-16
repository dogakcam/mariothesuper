using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreSystem : MonoBehaviour
{
    public GameObject ScoreText;
    public static int theScore;
    public GameObject MoonText;
    public static int moonScore;
    public GameObject PurpCoinText;
    public static int PurpCoinScore;
   
    
    void Update()
    {
        ScoreText.GetComponent<Text>().text = " Coin: " + theScore;
        MoonText.GetComponent<Text>().text = " Moon: " + moonScore;
        PurpCoinText.GetComponent<Text>().text = " Money: " + PurpCoinScore;
    }
}
