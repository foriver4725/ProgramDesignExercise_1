using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MainGame.Interface
{
    public interface IMovable
    {
        /// <summary>
        /// ��u�ŁA����n�_�ɏu�Ԉړ�����.
        /// </summary>
        /// <param name="target">�ڕW�n�_�̍��W</param>
        public void WarpTo(Vector3 target);

        /// <summary>
        /// ����n�_�Ɍ������āA���ʈړ�����.
        /// </summary>
        /// <param name="target">�ڕW�n�_�̍��W</param>
        /// <param name="speed">�ړ���</param>
        public void MoveTo(Vector3 target, float moveAmount);
    }
}
