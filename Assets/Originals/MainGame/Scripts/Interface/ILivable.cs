using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MainGame.Interface
{
    public interface ILivable
    {
        /// <summary>
        /// HP.
        /// </summary>
        public float _hp { get; set; }

        /// <summary>
        /// �ő�HP.
        /// </summary>
        public float _maxHp { get; set; }

        /// <summary>
        /// �_���[�W��H�炦�邩�̃t���O.
        /// </summary>
        public bool _isDamagable { get; set; }

        /// <summary>
        /// �_���[�W��H�炤.
        /// </summary>
        /// <param name="damage">�_���[�W�̑傫��</param>
        public void Damage(float damage);

        /// <summary>
        /// �񕜂���.
        /// </summary>
        /// <param name="healAmount">�񕜗�</param>
        public void Heal(float healAmount);

        /// <summary>
        /// ����.
        /// </summary>
        public void Die();
    }
}
