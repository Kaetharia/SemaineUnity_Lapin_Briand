using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RebootLapins : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
 
    }

    public void loadCurrentScene ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        ScoreScript.scoreValue = 0;

    }
}
