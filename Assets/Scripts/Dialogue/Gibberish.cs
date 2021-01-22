using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gibberish : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            AudioManager.Instance.PlaySound(Sounds.Dialogue, transform.position);
        }
    }
}
