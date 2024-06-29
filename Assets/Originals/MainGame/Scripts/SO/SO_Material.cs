using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MainGame.SO
{
    [CreateAssetMenu(fileName = "SO_Material", menuName = "SO/SO_Material")]
    public class SO_Material : ScriptableObject
    {
        [Header("ƒvƒŒƒCƒ„[‚Ì‘Ì")] public Material PlayerBody;
        [Header("“G‚Ì‘Ì")] public Material EnemyBody;
    }
}
