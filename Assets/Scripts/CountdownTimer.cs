using UnityEngine;
using System.Collections;

public class CountdownTimer : MonoBehaviour
{

    public float currentTime_;
    [SerializeField]private float StopTime_;
    public float setTime_;
    public bool StatTime;
    // Use this for initialization
    void Start()
    {

        currentTime_ = setTime_;
        StatTime = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (StatTime)
        {
            if (currentTime_ > StopTime_)
            {

                currentTime_ -= Time.deltaTime;
                Debug.Log("Time:" + currentTime_.ToString("00:00"));
            }
        }
        else
        {
            Debug.Log("Active StartTime");
        }
        
        
       
    }
   
}
