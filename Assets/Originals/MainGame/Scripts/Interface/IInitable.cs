using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MainGame.Interface
{
    public interface IInitable
    {
        /// <summary>
        /// 座標の初期化.
        /// </summary>
        /// <param name="position">座標</param>
        public void InitPosition(Vector3 position);

        /// <summary>
        /// マテリアルの初期化.
        /// </summary>
        /// <param name="material">マテリアル</param>
        public void InitMaterial(Material material);
    }
}
