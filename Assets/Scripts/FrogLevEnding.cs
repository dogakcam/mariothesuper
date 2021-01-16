using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogLevEnding : MonoBehaviour
{
    public GameObject Mario;
    

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")

        {
            Mario.transform.position = new Vector3((float) 95.98, (float) 224.2, (float) -632.83);
            Mario.transform.rotation = Quaternion.Euler(0, 222, 0);
        }
    }
}
