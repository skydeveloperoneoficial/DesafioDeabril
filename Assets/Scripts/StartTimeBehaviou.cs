using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class StartTimeBehaviou : MonoBehaviour
{
    SpawnControl2D spawnControl;

    public float countTime;
    public float timeStop;
    public bool StopTime;
    public string time;
    public Text time_;

    // Start is called before the first frame update
    void Start()
    {
        spawnControl = FindObjectOfType(typeof(SpawnControl2D)) as SpawnControl2D;

        countTime = Time.deltaTime;
        //spawnControl.gameObject.SetActive(false);
        spawnControl.ChangeState(StateDirectionSpawn.Disable);


        time_ = FindObjectOfType(typeof(Text)) as Text;

        StopTime= true;
    }

    // Update is called once per frame
    void Update()
    {

        if (countTime == timeStop)
        {
            StopTime = true;
        }
        if (!StopTime)
        {
            countTime++;
        }
        //Debug.Log(time + countTime.ToString("00:00"));
        time_.text = "Horario:"+countTime.ToString("00:00");
        

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {

            spawnControl.ChangeState(StateDirectionSpawn.SpawnVetical);
            StopTime = false;
           
            //Debug.Log("test");
        }
    }

}
    
