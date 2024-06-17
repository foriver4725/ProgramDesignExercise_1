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
        /// Playerスクリプトのインスタンス
        /// </summary>
        private Player _player;

        /// <summary>
        /// シーン内の全てのスクリプトのインスタンスを取得.
        /// </summary>
        private void Awake()
        {
            _player = "player".FindTag<Player>();
        }

        /// <summary>
        /// BeforeEntry(), Entry() の順に呼ぶ.
        /// </summary>
        private void Start()
        {
            _player.Entry();
        }

        /// <summary>
        /// BeforeFlip(), Flip(), AfterFlip() の順に呼ぶ.
        /// </summary>
        private void Update()
        {
            _player.Flip();
        }
    }
}
