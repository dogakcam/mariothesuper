using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorIsLavatwo : MonoBehaviour
{
    public GameObject Frog;


    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "frog")

        {
            Frog.transform.position = new Vector3((float) 1693.07, (float) -169.4, (float) -9763.4);
        }
    }
}