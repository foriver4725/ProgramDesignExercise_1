using MainGame.Interface;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.AddressableAssets;
using Cysharp.Threading.Tasks;

namespace General
{
    public class FontLoader : MonoBehaviour, IEventable
    {
        // Dynamicなフォントデータ
        private TMP_FontAsset _dynamicFontAsset = null;

        public async UniTask Load()
        {
            // フォントデータのロードが完了するまで、IEventableの処理を全て停止する。
            _dynamicFontAsset = await Addressables.LoadAssetAsync<TMP_FontAsset>("NotoSansJP-Medium SDF_Dynamic");
        }

        public void Entry()
        {
            // テクスチャのクリア
            _dynamicFontAsset.ClearFontAssetData();
        }

        public void Flip()
        {

        }

        // インスタンス破棄時(シーン終了時であることが望ましい)に...
        private void OnDestroy()
        {
            // テクスチャをクリアし...
            if (_dynamicFontAsset != null)
            {
                _dynamicFontAsset.ClearFontAssetData();
            }
            // Addressablesのリリースを行う。
            if (_dynamicFontAsset != null)
            {
                Addressables.Release(_dynamicFontAsset);
            }
        }
    }
}
