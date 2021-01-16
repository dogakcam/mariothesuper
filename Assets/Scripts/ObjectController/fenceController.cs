using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fenceController : MonoBehaviour
{
    public GameObject Fence;
    private void Start()
    {
        Fence.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Fence.SetActive(true);
        }
    }
}
