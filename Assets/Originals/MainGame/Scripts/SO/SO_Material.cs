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



        public const string PATH = "SO_Material";

        private static SO_Material _entity;
        public static SO_Material Entity
        {
            get
            {
                if (_entity == null)
                {
                    _entity = Resources.Load<SO_Material>(PATH);

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
