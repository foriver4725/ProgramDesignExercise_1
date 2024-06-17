using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace General
{
    public static class GameStateSetter
    {
        /// <summary>
        /// �Q�[���̍ŏ���1����s�����.
        /// �𑜓x��t���X�N���[���AVsync��FPS��ݒ肷��.
        /// </summary>
        [RuntimeInitializeOnLoadMethod]
        public static void SetGameState()
        {
            // �𑜓x�ƃt���X�N���[���̐����ݒ�
            Screen.SetResolution(SO.SO_GameState.Entity.Resolution.x, SO.SO_GameState.Entity.Resolution.y, SO.SO_GameState.Entity.IsFullScreen);

            // Vsync�i�ƃ^�[�Q�b�g�t���[�����[�g�j�̐ݒ�
            if (SO.SO_GameState.Entity.IsVsyncOn)
            {
                QualitySettings.vSyncCount = 1;
            }
            else
            {
                QualitySettings.vSyncCount = 0;
                Application.targetFrameRate = SO.SO_GameState.Entity.TargetFrameRate;
            }
        }
    }
}
