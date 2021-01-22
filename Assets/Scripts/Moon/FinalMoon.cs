using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FinalMoon : MonoBehaviour
{
    public int finalmoon= 0;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("moon")) 
        {
            finalmoon += 3;
            Debug.Log("Something Touched me");
            ScoreSystem.moonScore = finalmoon;
            AudioManager.Instance.PlaySound(Sounds.Moon, transform.position);
            Destroy(other.gameObject);
          
        }
        SceneManager.LoadScene(0);

    }
}
