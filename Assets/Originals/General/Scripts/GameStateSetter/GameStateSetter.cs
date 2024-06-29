using General.SO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace General
{
    public static class GameStateSetter
    {
        /// <summary>
        /// 解像度やフルスクリーン、VsyncやFPSを設定する
        /// </summary>
        public static void SetGameState(
            Vector2Int resolution, bool isFullScreen, bool isVsyncOn, byte targetFrameRate
            )
        {
            // 解像度とフルスクリーンの是非を設定
            Screen.SetResolution(resolution.x, resolution.y, isFullScreen);

            // Vsync（とターゲットフレームレート）の設定
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
