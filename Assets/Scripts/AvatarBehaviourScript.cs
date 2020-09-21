using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarBehaviourScript : MonoBehaviour
{
    private Animator animator;
    private CharacterController characterController;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("SitDown"))
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                animator.SetTrigger("StandUp");
            }
            if (Input.GetKeyDown(KeyCode.P))
            {
                AudioSource audioSource = GetComponentInChildren<AudioSource>();
                audioSource.volume = 1.0F;
                audioSource.Play(0);
            }
        }
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("StandUp"))
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                animator.SetTrigger("SitDown");
            }
        }
    }
}
