using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets._2D;
public class PedraBehaviour : MonoBehaviour
{
    [SerializeField]private float timeDelete;
    public PlatformerCharacter2D  platformerCharacterRobot;
    SpawnControl2D spawnControl;
    //public Text gameOver;
    private UIController GameOverUI, UIButtton;
    private StartTimeBehaviou timeBehaviou;
    // Start is called before the first frame update
    void Start()
    {
        //gameOver = GetComponent<Text>();
        platformerCharacterRobot = FindObjectOfType(typeof(PlatformerCharacter2D)) as PlatformerCharacter2D;
        //gameOver.text = "GameOver";
        //gameOver.gameObject.SetActive(false);
        GameOverUI = FindObjectOfType(typeof(UIController)) as UIController;
        timeBehaviou = FindObjectOfType(typeof(StartTimeBehaviou)) as StartTimeBehaviou;
        spawnControl = FindObjectOfType(typeof(SpawnControl2D)) as SpawnControl2D;
        UIButtton = FindObjectOfType(typeof(UIController)) as UIController;
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Game Over");
            platformerCharacterRobot.gameObject.SetActive(false);
            //gameOver.gameObject.SetActive(true);
            GameOverUI.UI[0].gameObject.SetActive(true);
            UIButtton.buttons[0].gameObject.SetActive(true);
            timeBehaviou.StopTime = true;
            spawnControl.ChangeState(StateDirectionSpawn.Disable);

        }
        if (collision.gameObject.CompareTag("Plataform"))
        {
            Destroy(gameObject, timeDelete);
        }
        
    }
}
