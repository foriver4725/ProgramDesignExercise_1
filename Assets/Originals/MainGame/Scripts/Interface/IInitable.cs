using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MainGame.Interface
{
    public interface IInitable
    {
        /// <summary>
        /// ���W�̏�����.
        /// </summary>
        /// <param name="position">���W</param>
        public void InitPosition(Vector3 position);

        /// <summary>
        /// �}�e���A���̏�����.
        /// </summary>
        /// <param name="material">�}�e���A��</param>
        public void InitMaterial(Material material);
    }
}
