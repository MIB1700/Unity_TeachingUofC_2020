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
    public static class MRExtensionMethods
    {
/*******************************************************************/
//
//      Miscs.
//
/*******************************************************************/
        public static void ColorTo(this Light myLight, Color toColor)
        {
            myLight.color = toColor;
        }
/*******************************************************************/
        /// <summary>
        /// Change alpha of this colour
        /// </summary>
        /// <returns>new Color</returns>
        /// <param name="c">Color</param>
        /// <param name="a">The new alpha component.</param>
        public static Color WithAlpha(this Color c, float a)
        {
            return new Color(c.r, c.g, c.b, a);
        }
/*******************************************************************/
    /// <summary>
    ///
    /// </summary>
    /// <param name="oldValue"></param>
    /// <param name="oldMin"></param>
    /// <param name="oldMax"></param>
    /// <param name="newMin"></param>
    /// <param name="newMax"></param>
    /// <returns></returns>
        public static float Scale(this float oldValue, float oldMin, float oldMax, float newMin, float newMax)
        {
            float oldRange = oldMax - oldMin;
            float newRange = newMax - newMin;
            float newValue = (((oldValue - oldMin) * newRange) / oldRange) + newMin;

            return newValue;
        }
/*******************************************************************/
        public static float ScaleClamp(this float oldValue, float oldMin, float oldMax, float newMin, float newMax)
        {
            float oldRange = oldMax - oldMin;
            float newRange = newMax - newMin;
            float newValue = (((oldValue - oldMin) * newRange) / oldRange) + newMin;

            return Mathf.Clamp(newValue, newMin, newMax);
        }
/*******************************************************************/
        /// <summary>
        /// Looks at a given target.
        /// </summary>
        /// <param name="self">Transform from which to look.</param>
        /// <param name="target">Target GameObject to look at.</param>
        public static void LookAt(this Transform self, GameObject target)
        {
            self.LookAt(target.transform);
        }
/*******************************************************************/
        /// <summary>
        /// Looks at a given target.
        /// </summary>
        /// <param name="self">Transform from which to look.</param>
        /// <param name="target">Target transform to look at.</param>
        public static void LookAt(this Transform self, Transform target)
        {
            self.LookAt(target);
        }
/*******************************************************************/
        /// <summary>
        /// Looks at a given target.
        /// </summary>
        /// <param name="self">GameObject from which to look.</param>
        /// <param name="target">Target GameObject to look at.</param>
        public static void LookAt(this GameObject self, GameObject target)
        {
            self.transform.LookAt(target);
        }
/*******************************************************************/
        /// <summary>
        /// Rotation of this object to target
        /// </summary>
        /// <returns>Quaternion needed to look at target.</returns>
        /// <param name="self">Starting Transform.</param>
        /// <param name="target">Target Position (Vector3).</param>
        public static Quaternion GetLookAtRotation(this Transform self, Vector3 target)
        {
            return Quaternion.LookRotation(target - self.position);
        }
/*******************************************************************/
        /// <summary>
        /// Rotation of this object to target
        /// </summary>
        /// <returns>Quaternion needed to look at target.</returns>
        /// <param name="self">Starting Transform.</param>
        /// <param name="target">Target Position (Transform).</param>
        public static Quaternion GetLookAtRotation(this Transform self, Transform target)
        {
            return GetLookAtRotation(self, target.position);
        }
/*******************************************************************/
         /// <summary>
        /// Rotation of this object to target
        /// </summary>
        /// <returns>Quaternion needed to look at target.</returns>
        /// <param name="self">Starting Transform.</param>
        /// <param name="target">Target Position (Transform).</param>
        public static Quaternion GetLookAtRotation(this GameObject self, GameObject target)
        {
            return GetLookAtRotation(self.transform, target.transform.position);
        }
/*******************************************************************/
    }
}