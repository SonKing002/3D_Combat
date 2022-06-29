using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Main;

namespace Main
{
    public class PlayerMove : MonoBehaviour
    {
        //플래이어 움직임

        float h, v, moveSpeed, limitSpeed, jumpPower, limitJump;
        Vector3 dir;
        bool isGround;
        CharacterController cc;

        void Start()
        {
            cc = GetComponent<CharacterController>();
        }

        void MoveCtrl()
        {
            h = Input.GetAxis("Horizontal");
            v = Input.GetAxis("Vertical");
            dir = new Vector3(h, 0, v);

            dir.Normalize();

            dir = transform.TransformDirection(dir);
            

        }

        void Update()
        {

        }
    }

}

