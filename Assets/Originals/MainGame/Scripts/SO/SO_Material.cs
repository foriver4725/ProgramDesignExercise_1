using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MainGame.SO
{
    [CreateAssetMenu(fileName = "SO_Material", menuName = "SO/SO_Material")]
    public class SO_Material : ScriptableObject
    {
        [Header("プレイヤーの体")] public Material PlayerBody;
        [Header("敵の体")] public Material EnemyBody;
    }
}
