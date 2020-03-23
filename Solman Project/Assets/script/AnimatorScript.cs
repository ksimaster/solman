using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class SimplePlayer : MonoBehaviour
{

    Animator animator;
    bool otgim = false;

    
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       
       // bool fire = Input.GetButtonDown("Fire1");

        
      //  animator.SetBool("Fire", fire);
    }

    void Otgimanie_Bttn()
    {
        otgim = true;
        animator.SetBool("otgim", otgim);
    }

    void Otgim_Prigok_Bttn()
    {

    }

    void Planka_Bttn()
    {

    }

    void Prigok_Bttn()
    {

    }

    void Velosiped_Bttn()
    {

    }

    void Voen_prigok_Bttn()
    {

    }


}