using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EndGame : MonoBehaviour
{
    public GameObject Mario;
    

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")

        {
           Mario.transform.position = new Vector3((float) 1693.07, (float) -169.4, (float) -9763.4);
           Mario.transform.rotation = Quaternion.Euler(0, 222, 0);
        }
    }
}
