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
        /// 最大HP.
        /// </summary>
        public float _maxHp { get; set; }

        /// <summary>
        /// ダメージを食らえるかのフラグ.
        /// </summary>
        public bool _isDamagable { get; set; }

        /// <summary>
        /// ダメージを食らう.
        /// </summary>
        /// <param name="damage">ダメージの大きさ</param>
        public void Damage(float damage);

        /// <summary>
        /// 回復する.
        /// </summary>
        /// <param name="healAmount">回復量</param>
        public void Heal(float healAmount);

        /// <summary>
        /// 死ぬ.
        /// </summary>
        public void Die();
    }
}
