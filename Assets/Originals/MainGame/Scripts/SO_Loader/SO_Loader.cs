using Cysharp.Threading.Tasks;
using General.SO;
using MainGame.Interface;
using MainGame.SO;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace MainGame
{
    public class SO_Loader : MonoBehaviour, IEventable
    {
        /// <summary>
        /// このシーンで使うSO
        /// </summary>
        public static SO_GameState SO_GameState { get; private set; }
        public static SO_Material SO_Material { get; private set; }

        public async UniTask Load()
        {
            // SOのロードが全て完了するまで、IEventableの処理を全て停止する。
            SO_GameState = await Addressables.LoadAssetAsync<SO_GameState>("SO_GameState");
            SO_Material = await Addressables.LoadAssetAsync<SO_Material>("SO_Material");
        }

        public void Entry()
        {

        }

        public void Flip()
        {

        }

        // インスタンス破棄時(シーン終了時であることが望ましい)に...
        private void OnDestroy()
        {
            // Addressablesのリリースを行う。
            if (SO_GameState != null) Addressables.Release(SO_GameState);
            if (SO_Material != null) Addressables.Release(SO_Material);
        }
    }
}
