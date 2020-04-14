using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillZoneBehaviour : MonoBehaviour
{
    private StartTimeBehaviou timeBehaviou;
    private void Start()
    {
        timeBehaviou = FindObjectOfType(typeof(StartTimeBehaviou)) as StartTimeBehaviou;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            timeBehaviou.StopTime =  true;
            
            
        }
        if (collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("SampleScene");
        }

    }
}
