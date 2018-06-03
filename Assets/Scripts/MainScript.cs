using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScript : MonoBehaviour
{
    // This is global variables
    public GameObject[] pipeObject; // prefab pipe
    public GameObject birdObject; // prefab player
    public float invokeTimeFrom = 0.5f;
    public float invokeTimeTo = 1.5f;
    
    public float pipeHole; // height of the passage between the pipe

    public GameObject GetReadyPanel;
    
    // Use this for initialization
    void Start()
    {
        // Call the "CreateObstacle" function after 0 seconds, then every 1.5 seconds.
        Invoke("CreateObstacle", 1.5f);
        Invoke("CloseGetReady", 1.4f);
    }

    void CloseGetReady()
    {
        // Add player to display
        Instantiate(birdObject);
        GetReadyPanel.active = false;
    }
    
    // Update is called once per frame
    void CreateObstacle()
    {
       
        CancelInvoke();
        // Create random position of the upper obstacle
        float randomPossition = 4f - (4f - 0.8f - pipeHole) * Random.value;
        // Add the top obstacle to the scene
        GameObject upperPipe = Instantiate(pipeObject[0]);
        // Adjust the position of the upper obstacle
        upperPipe.transform.position = new Vector2(4f, randomPossition);
        // Add a lower obstacle to the scene
        GameObject lowerPipe = Instantiate(pipeObject[1]);
        // Adjust the position of the lower obstacle
        lowerPipe.transform.position = new Vector2(4f, randomPossition - pipeHole - 4.8f);
        
        Invoke("CreateObstacle", Random.Range (invokeTimeFrom, invokeTimeTo));
    }
    
}