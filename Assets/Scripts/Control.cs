using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{

    [SerializeField]
    ClasseBase hero;
    void Start()
    {
        hero = GetComponent<ClasseBase>();
    }


    void Update()
    {
        if(hero.GetType() == typeof(ZeroControl))
        {
            //zeroControl.attacking = Input.GetMouseButtonUp(0);
            hero.attacking = Input.GetMouseButtonUp(0);
           hero.swordAttacking = Input.GetMouseButtonUp(1);
        }

        hero.inputHorizontal = Input.GetAxisRaw("Horizontal");
        if (Input.GetButton("Jump")) { hero.SetJump(); }
        //spriteControl.SetVelocity(Input.GetAxis("Horizontal"));
    }
}
