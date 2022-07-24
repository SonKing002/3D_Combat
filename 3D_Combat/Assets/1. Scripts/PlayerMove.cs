using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Main;

namespace Main
{
    public class PlayerMove : MonoBehaviour
    {
        //�÷��̾� ������

        public float h, z, moveSpeed, limitSpeed, jumpPower, limitJump;
        Vector3 dir;
        bool isGround;
        CharacterController cc;

        void Start()
        {
            //�Ҵ� �ʱ�ȭ
            cc = GetComponent<CharacterController>();
            dir = new Vector3(0,0,0);
        }

        void MoveCtrl()
        {
            h = Input.GetAxis("Horizontal");
            z = Input.GetAxis("Vertical");

            //�� �Ʒ� ����
            dir = new Vector3(h, 0, z);

            //�밢�� �ӵ� ����
            dir.Normalize();

            //���� ��ǥ�踦 ���� ��ǥ��� ��ȯ
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

