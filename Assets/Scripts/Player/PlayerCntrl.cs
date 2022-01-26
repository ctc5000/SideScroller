using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DefaultNamespace
{
    public class PlayerCntrl:MonoBehaviour
    {
        public Animator animator;
        private Movement _movement;

        private void Start()
        {
            _movement = GetComponent<Movement>();
            animator = GetComponent<Animator>();
            
        }

        private void Update()
        {
            if (_movement.moveHorizontal != 0 || _movement.moveVertical != 0)
            {
                animator.SetBool("Run",true);
            }
            else
            {
                animator.SetBool("Run",false);
            }
        }
    }
}