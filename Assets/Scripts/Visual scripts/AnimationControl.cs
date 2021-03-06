﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator), typeof(Army))]
public class AnimationControl : MonoBehaviour
{
    private Animator anim;
    [HideInInspector] public Army armyScript;
    EnumArmyFormations currentFormationName;

    // Start is called before the first frame update
    void Start()
    {
        armyScript = GetComponent<Army>();
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        AnimUpdate();
    }

    void AnimUpdate()
    {

        currentFormationName = armyScript.activeFormation.Designation;

        anim.SetBool("Cover",currentFormationName == EnumArmyFormations.Cover);
        anim.SetBool("Moving",currentFormationName == EnumArmyFormations.March);
        anim.SetBool("Charging", currentFormationName == EnumArmyFormations.Charge);
        anim.SetBool("Bracing",currentFormationName 
        == EnumArmyFormations.Brace);
        
        anim.SetBool("Attack", armyScript.isAttacking);

    }
}
