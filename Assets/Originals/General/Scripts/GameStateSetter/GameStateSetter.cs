using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace General
{
    public static class GameStateSetter
    {
        /// <summary>
        /// ゲームの最初に1回実行される.
        /// 解像度やフルスクリーン、VsyncやFPSを設定する.
        /// </summary>
        [RuntimeInitializeOnLoadMethod]
        public static void SetGameState()
        {
            // 解像度とフルスクリーンの是非を設定
            Screen.SetResolution(SO.SO_GameState.Entity.Resolution.x, SO.SO_GameState.Entity.Resolution.y, SO.SO_GameState.Entity.IsFullScreen);

            // Vsync（とターゲットフレームレート）の設定
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
