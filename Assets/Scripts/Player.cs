using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public List<Transform> Lapins ;
    public int target = 0;
    public Vector3 lapinPos;
    private Animator Frappe;



    void Start()
    {
        Frappe = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetButtonDown("PreviousLapin"))
        {
            target--;
        }
        if (Input.GetButtonDown("NextLapin"))
        {
            target++;
        }

        if(Input.GetButtonDown("Jump"))
        { 
            Frappe.SetTrigger("frappe");

        }

        if (target <0)
        {
            target += Lapins.Count;
        }
        target = target % (Lapins.Count);
        target = Mathf.Clamp(target, 0, Lapins.Count-1);

        lapinPos = Lapins[target].position ;
        transform.position = Vector3.Lerp(transform.position,lapinPos,Time.deltaTime*5);


    }


}
