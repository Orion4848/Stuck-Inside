using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
public class footsteps : MonoBehaviour
{
    private PlayerController Playercontroller;
    public AudioSource footstepAudioSource1;
    private Animator anim;
    //anim = Animator.GetComponent();
    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        bool x;
        x = anim.GetBool("isMoving");
        if (x == true)
        {
            footstepAudioSource1.enabled = true;
        }

        else 
        { 
            footstepAudioSource1.enabled = false;
        }
    }


}
