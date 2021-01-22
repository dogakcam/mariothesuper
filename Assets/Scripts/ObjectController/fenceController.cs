using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fenceController : MonoBehaviour
{
    public GameObject Fence;
    public GameObject Monster;
    public GameObject MonsterCap1;
    public GameObject MonsterCap2;
    public GameObject FinalMoon;
    private void Start()
    {
        Fence.SetActive(false);
        Monster.SetActive(false);
        MonsterCap1.SetActive(false);
        MonsterCap2.SetActive(false);
        FinalMoon.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Fence.SetActive(true);
            Monster.SetActive(true);
            MonsterCap1.SetActive(true);
            MonsterCap2.SetActive(true);
            FinalMoon.SetActive(true);
        }
    }
}
