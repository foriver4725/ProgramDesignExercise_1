using MainGame.Interface;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MainGame.Livings
{
    public class Player : MonoBehaviour, IEventable, ILivable, IMovable
    {
        public float _hp { get; set; } = 100f;

        public float _maxHp { get; set; } = 100f;

        public bool _isDamagable { get; set; } = true;

        public void Entry()
        {
            WarpTo(Vector3.zero);
        }

        public void Flip()
        {
            MoveTo(transform.position + Vector3.right, Time.deltaTime);
        }

        public void Damage(float damage)
        {
            if (!_isDamagable) return;

            _hp -= damage;

            if (_hp < 0)
            {
                _hp = 0;
                Die();
            }
        }

        public void Heal(float healAmount)
        {
            _hp += healAmount;

            if (_hp > _maxHp)
            {
                _hp = _maxHp;
            }
        }

        public void Die()
        {
            Destroy(gameObject);
        }

        public void WarpTo(Vector3 target)
        {
            transform.position = target;
        }

        public void MoveTo(Vector3 target, float moveAmount)
        {
            transform.position += (target - transform.position).normalized * moveAmount;
        }
    }
}
