using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lapin_Collision : MonoBehaviour
{
    private Animator animLapin;

    void Start()
    {
        animLapin = GetComponent<Animator>();
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collider)
    {
        Debug.Log("Pas Pouf");

        if (collider.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            animLapin.SetTrigger("Tapper");
            Debug.Log("Pouf");

        }


    }
}
