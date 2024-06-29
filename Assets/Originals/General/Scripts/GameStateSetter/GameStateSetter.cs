using General.SO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace General
{
    public static class GameStateSetter
    {
        /// <summary>
        /// �𑜓x��t���X�N���[���AVsync��FPS��ݒ肷��
        /// </summary>
        public static void SetGameState(
            Vector2Int resolution, bool isFullScreen, bool isVsyncOn, byte targetFrameRate
            )
        {
            // �𑜓x�ƃt���X�N���[���̐����ݒ�
            Screen.SetResolution(resolution.x, resolution.y, isFullScreen);

            // Vsync�i�ƃ^�[�Q�b�g�t���[�����[�g�j�̐ݒ�
            if (isVsyncOn)
            {
                QualitySettings.vSyncCount = 1;
            }
            else
            {
                QualitySettings.vSyncCount = 0;
                Application.targetFrameRate = targetFrameRate;
            }
        }
    }
}
