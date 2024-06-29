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
        // Dynamic�ȃt�H���g�f�[�^
        private TMP_FontAsset _dynamicFontAsset = null;

        public async UniTask Load()
        {
            // �t�H���g�f�[�^�̃��[�h����������܂ŁAIEventable�̏�����S�Ē�~����B
            _dynamicFontAsset = await Addressables.LoadAssetAsync<TMP_FontAsset>("NotoSansJP-Medium SDF_Dynamic");
        }

        public void Entry()
        {
            // �e�N�X�`���̃N���A
            _dynamicFontAsset.ClearFontAssetData();
        }

        public void Flip()
        {

        }

        // �C���X�^���X�j����(�V�[���I�����ł��邱�Ƃ��]�܂���)��...
        private void OnDestroy()
        {
            // �e�N�X�`�����N���A��...
            if (_dynamicFontAsset != null)
            {
                _dynamicFontAsset.ClearFontAssetData();
            }
            // Addressables�̃����[�X���s���B
            if (_dynamicFontAsset != null)
            {
                Addressables.Release(_dynamicFontAsset);
            }
        }
    }
}
