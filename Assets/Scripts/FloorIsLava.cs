using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FloorIsLava : MonoBehaviour
{
    public GameObject Mario;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))

        {
            SceneManager.LoadScene(1);
        }
    }
}
