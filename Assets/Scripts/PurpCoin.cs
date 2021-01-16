using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurpCoin : MonoBehaviour
{
    public int Money = 0;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PurpCoin")) 
        {
            Money += 1;
            Debug.Log("Something Touched me");
            ScoreSystem.PurpCoinScore = Money;

            Destroy(other.gameObject); 

        }
    }
}


