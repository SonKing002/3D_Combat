using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Main;

namespace Main
{
    public class PlayerMove : MonoBehaviour
    {
        //플래이어 움직임

        public float h, z, moveSpeed, limitSpeed, jumpPower, limitJump;
        Vector3 dir;
        bool isGround;
        CharacterController cc;

        void Start()
        {
            //할당 초기화
            cc = GetComponent<CharacterController>();
            dir = new Vector3(0,0,0);
        }

        void MoveCtrl()
        {
            h = Input.GetAxis("Horizontal");
            z = Input.GetAxis("Vertical");

            //위 아래 셋팅
            dir = new Vector3(h, 0, z);

            //대각선 속도 일정
            dir.Normalize();

            //로컬 좌표계를 월드 좌표계로 변환
            dir = transform.TransformDirection(dir);

            cc.Move(dir);

        }

        private void FixedUpdate()
        {
            MoveCtrl();
        }
        void Update()
        {
            
        }
    }

}

