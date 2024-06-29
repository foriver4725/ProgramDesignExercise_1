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
        /// IEventable�̃C���X�^���X
        /// </summary>
        public IEventable FontLoader { get; set; }
        public IEventable SO_Loader { get; set; }
        public IEventable Player { get; set; }
        public IEventable Enemy { get; set; }

        /// <summary>
        /// �V�[�����̑S�Ă�IEventable�̃C���X�^���X���擾
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
        /// BeforeEntry(), Entry() �̏��ɌĂ�
        /// </summary>
        private async void Start()
        {
            // ���[�h���s��
            await ((FontLoader)FontLoader).Load();
            await ((SO_Loader)SO_Loader).Load();

            // �Q�[���̏�Ԃ�ݒ肷��
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
        /// BeforeFlip(), Flip(), AfterFlip() �̏��ɌĂ�
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
