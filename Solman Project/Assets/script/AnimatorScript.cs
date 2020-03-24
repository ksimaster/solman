using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class AnimatorScript : MonoBehaviour
{

    Animator animator;
    int changeAnim = 0;

    
    void Start()
    {
        animator = GetComponent<Animator>();
        ResetAnim();
    }

    // Update is called once per frame
    void Update()
    {
        ChangeAnimation();
        ResetAnim();
        
       // bool fire = Input.GetButtonDown("Fire1");
        
      //  animator.SetBool("Fire", fire);
    }

    void ChangeAnimation()
    {
        animator.SetInteger("ChangeAnim", changeAnim);
    }

    void ResetAnim()
    {
        if (changeAnim != 0) changeAnim = 0;
         
        
    }

   public void Otgimanie_Bttn()
    {
        changeAnim = 1;
    }

   public void Otgim_Prigok_Bttn()
    {
        changeAnim = 2;
    }

   public void Planka_Bttn()
    {
        changeAnim = 3;
    }

   public void Prigok_Bttn()
    {
        changeAnim = 4;
    }

   public void Velosiped_Bttn()
    {
        changeAnim = 5;
    }

   public void Voen_prigok_Bttn()
    {
        changeAnim = 6;
    }


}