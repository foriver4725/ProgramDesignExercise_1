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
        /// FontLoaderスクリプトのインスタンス
        /// </summary>
        private FontLoader _fontLoader;
        /// <summary>
        /// Playerスクリプトのインスタンス
        /// </summary>
        private Player _player;
        /// <summary>
        /// Enemyスクリプトのインスタンス
        /// </summary>
        private Enemy _enemy;

        /// <summary>
        /// シーン内の全てのスクリプトのインスタンスを取得.
        /// </summary>
        private void Awake()
        {
            _fontLoader = "font_loader".FindTag<FontLoader>();
            _player = "player".FindTag<Player>();
            _enemy = "enemy".FindTag<Enemy>();
        }

        /// <summary>
        /// BeforeEntry(), Entry() の順に呼ぶ.
        /// </summary>
        private void Start()
        {
            _fontLoader.Entry();
            _player.Entry();
            _enemy.Entry();
        }

        /// <summary>
        /// BeforeFlip(), Flip(), AfterFlip() の順に呼ぶ.
        /// </summary>
        private void Update()
        {
            _fontLoader.Flip();
            _player.Flip();
            _enemy.Flip();
        }
    }
}
