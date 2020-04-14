using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityStandardAssets._2D;
public class StartTimeBehaviou : MonoBehaviour
{
    SpawnControl2D spawnControl;
    private UIController timeUI,GameOverUI;
    public PlatformerCharacter2D platformerCharacterRobot;
    public int countTime;
    public int timeStop;
    public  int currentTime;
    public bool StopTime,StopOut;
    public string time;

    //public Text time_;

    // Start is called before the first frame update
    void Start()
    {
        spawnControl = FindObjectOfType(typeof(SpawnControl2D)) as SpawnControl2D;

        countTime =(int) Time.time;
        //spawnControl.gameObject.SetActive(false);
        spawnControl.ChangeState(StateDirectionSpawn.Disable);
        timeUI = FindObjectOfType(typeof(UIController)) as UIController;
        GameOverUI= FindObjectOfType(typeof(UIController)) as UIController;
        platformerCharacterRobot = FindObjectOfType(typeof(PlatformerCharacter2D)) as PlatformerCharacter2D;
        //time_ = FindObjectOfType(typeof(Text)) as Text;

        StopTime = true;
        StopOut =  true;
    }

    // Update is called once per frame
    void Update()
    {

        if (countTime == timeStop)
        {
            StopTime = true;
            GameOverUI.UI[0].gameObject.SetActive(true);
            
            platformerCharacterRobot.gameObject.SetActive(false);
            
            spawnControl.ChangeState(StateDirectionSpawn.Disable);

            

        }
        if (!StopTime)
        {
            countTime++;
        }
        if (StopOut)
        {
            countTime = currentTime;
        }
        
        //Debug.Log(time + countTime.ToString("00:00"));
        //time_.text = "Horario:"+countTime.ToString("00:00");
        timeUI.UI[1].text = "Horario:" + countTime.ToString("00:00");

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {

            spawnControl.ChangeState(StateDirectionSpawn.SpawnVetical);

            StopTime = false;
            StopOut = false;
            Debug.Log("test");
            
        }
    }

}
    
