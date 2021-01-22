using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossCap : MonoBehaviour
{
           public int MonsterCap = 2;
           public GameObject MonsterDestroyer;
           public GameObject MonsterCap1;
           public GameObject MonsterCap2;
           void Start()
           {
               MonsterDestroyer.SetActive(false);
           }
           void Update()
           {
               if(MonsterCap == 1)
               {
                   MonsterCap1.SetActive(false);
               }
               if(MonsterCap == 0)
               {
                   MonsterCap2.SetActive(false);
                   MonsterDestroyer.SetActive(true);
               }
   
           }
   
           void OnTriggerEnter(Collider other)
           {
               if(other.CompareTag("Cap"))
               {
                   MonsterCap -= 1;
   
               }
           }
}
