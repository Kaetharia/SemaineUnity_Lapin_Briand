using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lapin_Mouv : MonoBehaviour
{
    public List<GameObject> LapinMalin;
    public int chosenlapin;
    private float tempsEcoule = 0.0f;
    public float temps = 1.0f;
    private int lapinTag;
   
  

    void Start()
    {

    }

    void Update()
    {
        tempsEcoule += Time.deltaTime;

        if (tempsEcoule >= temps)
        {
            SautDeLapin();
            
            tempsEcoule = 0.0f;
        }
    }

    void SautDeLapin()
    {
        lapinTag = Random.Range(0, LapinMalin.Count);
        LapinMalin[lapinTag].GetComponent<Animator>().SetTrigger("Debout");
    }


}
