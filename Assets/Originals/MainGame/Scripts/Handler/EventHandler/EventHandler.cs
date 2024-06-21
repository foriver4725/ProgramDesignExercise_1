using General;
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
        /// FontLoader�X�N���v�g�̃C���X�^���X
        /// </summary>
        private FontLoader _fontLoader;
        /// <summary>
        /// Player�X�N���v�g�̃C���X�^���X
        /// </summary>
        private Player _player;
        /// <summary>
        /// Enemy�X�N���v�g�̃C���X�^���X
        /// </summary>
        private Enemy _enemy;

        /// <summary>
        /// �V�[�����̑S�ẴX�N���v�g�̃C���X�^���X���擾.
        /// </summary>
        private void Awake()
        {
            _fontLoader = "font_loader".FindTag<FontLoader>();
            _player = "player".FindTag<Player>();
            _enemy = "enemy".FindTag<Enemy>();
        }

        /// <summary>
        /// BeforeEntry(), Entry() �̏��ɌĂ�.
        /// </summary>
        private void Start()
        {
            _fontLoader.Entry();
            _player.Entry();
            _enemy.Entry();
        }

        /// <summary>
        /// BeforeFlip(), Flip(), AfterFlip() �̏��ɌĂ�.
        /// </summary>
        private void Update()
        {
            _fontLoader.Flip();
            _player.Flip();
            _enemy.Flip();
        }
    }
}
