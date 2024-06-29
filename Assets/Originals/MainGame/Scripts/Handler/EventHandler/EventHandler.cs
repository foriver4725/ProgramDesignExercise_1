using General;
using MainGame.Ex;
using MainGame.Interface;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MainGame.EventHandler
{
    public class EventHandler : MonoBehaviour
    {
        public static EventHandler Instance { get; set; } = null;

        /// <summary>
        /// IEventableのインスタンス
        /// </summary>
        public IEventable FontLoader { get; set; }
        public IEventable SO_Loader { get; set; }
        public IEventable Player { get; set; }
        public IEventable Enemy { get; set; }

        /// <summary>
        /// シーン内の全てのIEventableのインスタンスを取得
        /// </summary>
        private void Awake()
        {
            if (Instance == null) Instance = this;
            else Destroy(gameObject);

            FontLoader = "loader/font_loader".FindTag<IEventable>();
            SO_Loader = "loader/so_loader".FindTag<IEventable>();
            Player = "player".FindTag<IEventable>();
            Enemy = "enemy".FindTag<IEventable>();
        }

        /// <summary>
        /// BeforeEntry(), Entry() の順に呼ぶ
        /// </summary>
        private async void Start()
        {
            // ロードを行う
            await ((FontLoader)FontLoader).Load();
            await ((SO_Loader)SO_Loader).Load();

            // ゲームの状態を設定する
            GameStateSetter.SetGameState(
                MainGame.SO_Loader.SO_GameState.Resolution,
                MainGame.SO_Loader.SO_GameState.IsFullScreen,
                MainGame.SO_Loader.SO_GameState.IsVsyncOn,
                MainGame.SO_Loader.SO_GameState.TargetFrameRate
                );

            FontLoader.Entry();
            SO_Loader.Entry();
            Player.Entry();
            Enemy.Entry();
        }

        /// <summary>
        /// BeforeFlip(), Flip(), AfterFlip() の順に呼ぶ
        /// </summary>
        private void Update()
        {
            FontLoader.Flip();
            SO_Loader.Flip();
            Player.Flip();
            Enemy.Flip();
        }
    }
}
