using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MainGame.SO
{
    [CreateAssetMenu(fileName = "SO_Material", menuName = "SO/SO_Material")]
    public class SO_Material : ScriptableObject
    {
        [Header("�v���C���[�̑�")] public Material PlayerBody;
        [Header("�G�̑�")] public Material EnemyBody;
    }
}
