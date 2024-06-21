using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace General.SO
{
    [CreateAssetMenu(fileName = "SO_GameState", menuName = "SO/SO_GameState")]
    public class SO_GameState : ScriptableObject
    {
        [Header("解像度")] public Vector2Int Resolution;
        [Header("フルスクリーンにするか")] public bool IsFullScreen;
        [Header("Vsyncをオンにするか")] public bool IsVsyncOn;
        [Header("Vsyncがオフの時、ターゲットフレームレート")] public byte TargetFrameRate;



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
