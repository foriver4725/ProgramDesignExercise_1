using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace General.SO
{
    [CreateAssetMenu(fileName = "SO_GameState", menuName = "SO/SO_GameState")]
    public class SO_GameState : ScriptableObject
    {
        [Header("�𑜓x")] public Vector2Int Resolution;
        [Header("�t���X�N���[���ɂ��邩")] public bool IsFullScreen;
        [Header("Vsync���I���ɂ��邩")] public bool IsVsyncOn;
        [Header("Vsync���I�t�̎��A�^�[�Q�b�g�t���[�����[�g")] public byte TargetFrameRate;



        public const string PATH = "SO_GameState";

        private static SO_GameState _entity;
        public static SO_GameState Entity
        {
            get
            {
                if (_entity == null)
                {
                    _entity = Resources.Load<SO_GameState>(PATH);

                    if (_entity == null)
                    {
                        Debug.LogError(PATH + " not found");
                    }
                }

                return _entity;
            }
        }
    }
}
