using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets._2D;

public class RestartButtonBehaviour : MonoBehaviour
{
    public Button button;
    private Platformer2DUserControl robot;
    // Start is called before the first frame update
    void Start()
    {
        robot = FindObjectOfType(typeof(Platformer2DUserControl)) as Platformer2DUserControl;
        button = FindObjectOfType(typeof(Button)) as Button;
        button.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {

            button.gameObject.SetActive(true);
            robot.gameObject.SetActive(false);
            Destroy(robot.gameObject);

        }
    }
}
