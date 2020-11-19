using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// https://docs.microsoft.com/en-us/dotnet/csharp/codedoc
// https://www.youtube.com/watch?v=mr5xkf6zSzk

//TODO:
//  organize code
//  document
//  remove useless stuff
//  figure out consistency

/// <summary>
/// The main MRExtensionsMethods class
/// Uses the MR.CustomExtensions namespace
///
/// Don't forget to use:
///     using MR.CustomExtensions
/// in your code!
/// </summary>
namespace MR.CustomExtensions
{
    public static class MRExtensionMethods_GameObjects
    {
/*******************************************************************/
//
//                    GameObject Functions
//
/*******************************************************************/

#region
        /// <summary>
        /// Removes a component from the current Gameobject.
        /// </summary>
        /// <param name="obj">GameObject from which to remove Component.</param>
        /// <param name="immediate">If set to <c>true</c> destroy immediatly otherwise wait until end of next frame.</param>
        /// <typeparam name="Component">The Component to be removed.</typeparam>
        public static void RemoveComponent<Component>(this GameObject obj, bool immediate = false)
        {
            // Component component = obj.GetComponent<Component>();

            // if (component != null)
            // {
            //     if (immediate)
            //     {
            //         Object.DestroyImmediate(component as Object, true);
            //     }
            //     else
            //     {
            //         Object.Destroy(component as Object);
            //     }
            // }

            //TryGetComponent returns true if found and assigns Component to the "out" variable
            if (obj.TryGetComponent(out Component component)){

                if (immediate)
                {
                    Object.DestroyImmediate(component as Object, true);
                }
                else
                {
                    Object.Destroy(component as Object);
                }
            }
        }
/*******************************************************************/
        public static void ScaleAllRight(this GameObject obj, float scale)
        {
            //---------------------------------------------------
            //(bigSize / 2.0) - (originalSize / 2.0)

            Vector3 origSize = obj.transform.localScale;
            Vector3 bigSize = origSize * scale;

            obj.transform.localScale = bigSize;

            obj.transform.position = obj.transform.position + ((bigSize * 0.5f) - (origSize * 0.5f));
            //---------------------------------------------------
        }
/*******************************************************************/
        /// <summary>
        /// Scale GameObject to the right only
        /// </summary>
        /// <param name="obj">GameObject to scale</param>
        /// <param name="scale">scaling factor</param>
        public static void ScaleXRight(this GameObject obj, float scale)
        {
            //---------------------------------------------------
            //(bigSize / 2.0) - (originalSize / 2.0)

            Vector3 origSize = obj.transform.localScale;
            Vector3 bigSize = origSize.MultX(scale);

            obj.transform.localScale = bigSize;

            obj.transform.position = obj.transform.position + ((bigSize * 0.5f) - (origSize * 0.5f));
            //---------------------------------------------------
        }
/*******************************************************************/
        /// <summary>
        /// Remove GameObject from List, then destroy it
        /// </summary>
        /// <param name="obj">GameObject to destroy and look for in list.</param>
        /// <param name="list">list of GameObjects.</param>
        /// <param name="time">time until GO is destroyed.</param>
        /// <example>
        /// <code>
        ///  List<GameObject> enemies;
        ///  enemy.DestroyRemoveFromList(enemies, 1f);
        /// </code>
        /// </example>
        public static void DestroyRemoveFromList(this GameObject obj, List<GameObject> list, float timeToDeath)
        {
            list.Remove(obj);

            //destroy the object regardless of if it was in the list
            Object.Destroy(obj, timeToDeath);
        }
/*******************************************************************/
 /// <summary>
        /// Remove GameObject from List, then destroy it
        /// </summary>
        /// <param name="obj">GameObject to destroy and look for in list.</param>
        /// <param name="list">list of GameObjects.</param>
        /// <param name="time">time until GO is destroyed.</param>
        /// <example>
        /// <code>
        ///  List<GameObject> enemies;
        ///  enemies.DestroyRemoveFromList(enemy, 1f);
        /// </code>
        /// </example>
         public static void DestroyRemoveFromList(this List<GameObject> list, GameObject obj, float timeToDeath)
        {
            if (list.Remove(obj))
            {
                //destroy the object ONLY if it was in the list
                Object.Destroy(obj, timeToDeath);
            }
        }
/*******************************************************************/
        public static void ColorTo(this GameObject go, Color toColor)
        {
            go.GetComponent<Renderer>().material.color = toColor;
        }
/*******************************************************************/
        public static void ColorTo(this Material mat, Color toColor)
        {
            mat.color = toColor;
        }
/*******************************************************************/

#endregion
    }
}