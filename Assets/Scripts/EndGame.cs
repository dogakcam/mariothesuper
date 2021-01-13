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
           Mario.transform.position = new Vector3((float) 1969.7, (float) -2, (float) -10957.9);
           Mario.transform.rotation = Quaternion.Euler(0, 222, 0);
        }
    }
}
