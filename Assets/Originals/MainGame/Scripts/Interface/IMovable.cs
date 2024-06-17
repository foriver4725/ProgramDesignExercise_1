using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MainGame.Interface
{
    public interface IMovable
    {
        /// <summary>
        /// 一瞬で、ある地点に瞬間移動する.
        /// </summary>
        /// <param name="target">目標地点の座標</param>
        public void WarpTo(Vector3 target);

        /// <summary>
        /// ある地点に向かって、一定量移動する.
        /// </summary>
        /// <param name="target">目標地点の座標</param>
        /// <param name="speed">移動量</param>
        public void MoveTo(Vector3 target, float moveAmount);
    }
}
