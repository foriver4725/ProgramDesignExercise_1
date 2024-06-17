using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MainGame.Interface
{
    public interface IEventable
    {
        /// <summary>
        /// 最初のフレームに1回だけ実行される.
        /// </summary>
        public void Entry();

        /// <summary>
        /// 毎フレーム1回ずつ呼ばれる.
        /// </summary>
        public void Flip();
    }
}

