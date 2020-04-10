
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum StateDirectionSpawn
{
    SpawnVetical,
    SpawnHorizontal,
    Disable
    
}

public class SpawnControl2D : MonoBehaviour {

    [SerializeField] private Transform spawnPos;
    [SerializeField] private float rateSpawn ,timespawn;
    [SerializeField] private float vRandomMin, vRandomMax, hRandomMin, hRandomMax;//Random Vertical and Horizontal
    [SerializeField] private string tagSpawn = "Spawn";// Def..
    private Transform enemyTransform;
    private Vector3 spawnPositionA, spawnPositionB;


    private bool isPositionPlayer = false;

   

    public StateDirectionSpawn directionSpawn = StateDirectionSpawn.Disable;
    private Transform playerTransform= null;
    public void ChangeState(StateDirectionSpawn stateDirection_)
    {
        //stateDirection_ = directionSpawn;
        directionSpawn = stateDirection_;
    }
    #region Propriedes  Get Set
   

    

    

    
    #endregion


    // Use this for initialization
    protected  void Start()
    {
        ActiveSpawner();
        
       
    }
  private   void ActiveSpawner()
    {

        InvokeRepeating(tagSpawn, timespawn, rateSpawn);
        
    }
    /// <summary>
    /// Selecione O Tipo que deseja Trabalhar.
    /// </summary>
    private void Spawn()
    {

        switch (directionSpawn)
        {
            // Spawn Vertical 
            #region Spawn  Vertical
            case StateDirectionSpawn.SpawnVetical:
                {
                    
                    isPositionPlayer = !isPositionPlayer;

                     

                    if (isPositionPlayer && playerTransform != null)
                    {
                        spawnPositionA = new Vector3(playerTransform.position.x,
                                                    transform.position.y,
                                                    transform.position.z); //SpawnPoint
                    }
                    else
                    {
                        spawnPositionA = new Vector3(Random.Range(vRandomMin, vRandomMax),
                                                    transform.position.y,
                                                    transform.position.z);//Spawn Random
                    }
                    
                    enemyTransform = Instantiate(spawnPos) as Transform;
                   
                    enemyTransform.position = spawnPositionA;

                }
                break;
            #endregion

            // Spawn Horizontal
            #region Spawn Horizontal
            case StateDirectionSpawn.SpawnHorizontal:
                {
                    
                    isPositionPlayer = !isPositionPlayer;

                     

                    if (isPositionPlayer && playerTransform != null)
                    {
                        spawnPositionA = new Vector3(playerTransform.position.x,
                                                    playerTransform.position.y,
                                                    transform.position.z);//SpawnPoint
                    }
                    else
                    {
                        spawnPositionA = new Vector3(transform.position.x,
                                                    Random.Range(hRandomMin, hRandomMax),
                                                    transform.position.z);//Spawn Random
                    }
                   

                        enemyTransform = Instantiate(spawnPos) as Transform;
                    

                    enemyTransform.position = spawnPositionA;
                    
                }
                break;
            #endregion
            case StateDirectionSpawn.Disable:
                
                try
                {
                    
                }
                // Desable spawn
                catch
                {
                    Debug.LogWarning("DisableSpawn");
                }
                
                break;
            default:
                break;
        }
        

       
    }
    



}
