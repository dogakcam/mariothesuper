using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public GameObject Mario;
    public GameObject Frog;
    private Mind mind;
    
    private void Start()
    {
        mind = Mind.Instance;
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Cap"))
        {
            mind.ChangePlayer(this.gameObject);
        }
        
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            mind.ChangePlayer(Mario);
            Mario.SetActive(true);
            Mario.transform.position = Frog.transform.position;
            Frog.SetActive(false);

        }
    }

}
