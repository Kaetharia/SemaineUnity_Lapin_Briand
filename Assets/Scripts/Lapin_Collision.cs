﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;using UnityEngine;


public class Lapin_Collision : MonoBehaviour
{
    public Animator animLapin;
    private float invincible = 0.0f;
    public static int score = 0;


    void Start()
    {
        //animLapin = GetComponent<Animator>();
    }

    void Update()
    {
        invincible -= Time.deltaTime;
    }

    private void OnTriggerEnter(Collider collider)
    {
        Debug.Log("Pas Pouf");

        if (collider.gameObject.layer == LayerMask.NameToLayer("Player")&& invincible <= 0)
        {
            animLapin.SetTrigger("Tapper");
            Debug.Log("Pouf");
            invincible = 1.0f;
            ScoreScript.scoreValue += 1;
         

        }


    }
}
