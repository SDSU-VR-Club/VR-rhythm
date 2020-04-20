﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostBehaviour : MonoBehaviour
{
    public Animator anim;
    public AudioClip swing;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void AttackAt(Vector3 pos)
    {
        if (anim.GetCurrentAnimatorStateInfo(0).IsName("idle"))
        {
            transform.position = pos;
            anim.SetTrigger("attack");
            audioSource.PlayOneShot(swing, 0.7f);
        }
    }
}
