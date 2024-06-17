using MainGame.Ex;
using MainGame.Livings;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MainGame.EventHandler
{
    public class EventHandler : MonoBehaviour
    {
        /// <summary>
        /// Player�X�N���v�g�̃C���X�^���X
        /// </summary>
        private Player _player;

        /// <summary>
        /// �V�[�����̑S�ẴX�N���v�g�̃C���X�^���X���擾.
        /// </summary>
        private void Awake()
        {
            _player = "player".FindTag<Player>();
        }

        /// <summary>
        /// BeforeEntry(), Entry() �̏��ɌĂ�.
        /// </summary>
        private void Start()
        {
            _player.Entry();
        }

        /// <summary>
        /// BeforeFlip(), Flip(), AfterFlip() �̏��ɌĂ�.
        /// </summary>
        private void Update()
        {
            _player.Flip();
        }
    }
}
