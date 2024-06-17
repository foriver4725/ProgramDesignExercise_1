using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MainGame.Ex
{
    public static class Tag
    {
        public static GameObject FindTag(this string tagName)
        {
            return GameObject.FindGameObjectWithTag(tagName);
        }

        public static T FindTag<T>(this string tagName)
        {
            return GameObject.FindGameObjectWithTag(tagName).GetComponent<T>();
        }
    }
}
