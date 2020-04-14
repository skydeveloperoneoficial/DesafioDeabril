using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public Text[] UI;
    public Button[] buttons;

    // Use this for initialization
    void Start()
    {
        // GameOver
       UI[0].text = "GameOver";
       UI[0].gameObject.SetActive(false);

       buttons[0].gameObject.SetActive(false);
        
    }


    // Update is called once per frame
    void Update()
    {

    }
}
