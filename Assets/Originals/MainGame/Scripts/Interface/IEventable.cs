using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MainGame.Interface
{
    public interface IEventable
    {
        /// <summary>
        /// �ŏ��̃t���[����1�񂾂����s�����.
        /// </summary>
        public void Entry();

        /// <summary>
        /// ���t���[��1�񂸂Ă΂��.
        /// </summary>
        public void Flip();
    }
}

