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
    public static class MRExtensionMethods_Vectors
    {
/*******************************************************************/
//
//                      Vector Functions
//
/*******************************************************************/
#region
        /// <summary>
        /// Get x and y from Vector3.
        /// </summary>
        /// <returns>new Vector2.</returns>
        /// <param name="v">Vector3</param>
        public static Vector2 xy(this Vector3 v)
        {
            return new Vector2(v.x, v.y);
        }
/*******************************************************************/
        /// <summary>
        /// Get random Vector3 from given min and max.
        /// </summary>
        ///<remark>
        /// uses Unityengine.Random.Range
        ///</remark>
        /// <returns>
        /// random Vector3
        ///</returns>
        /// <param name="v">Vector3</param>
        /// <param name="min">min random value</param>
        /// <param name="max">max random value</param>
        public static Vector3 Random(this Vector3 v, Vector3 min, Vector3 max)
        {
            v = new Vector3(UnityEngine.Random.Range(min.x, max.x), UnityEngine.Random.Range(min.y, max.y), UnityEngine.Random.Range(min.z, max.z));
            return v;
        }
/*******************************************************************/
        /// <summary>
        /// Replace x in Vector3
        /// </summary>
        /// <returns>New Vector3</returns>
        /// <param name="v">Vector3</param>
        /// <param name="x">The x replacement</param>
        public static Vector3 WithX(this Vector3 v, float x)
        {
            return new Vector3(x, v.y, v.z);
        }
/*******************************************************************/
        /// <summary>
        /// Replace y in Vector3
        /// </summary>
        /// <returns>New Vector3.</returns>
        /// <param name="v">Vector3.</param>
        /// <param name="y">The y replacement.</param>
        public static Vector3 WithY(this Vector3 v, float y)
        {
            return new Vector3(v.x, y, v.z);
        }
/*******************************************************************/
        /// <summary>
        /// Replace z in Vector3
        /// </summary>
        /// <returns>New Vector3.</returns>
        /// <param name="v">Vector3.</param>
        /// <param name="z">The z replacement.</param>
        public static Vector3 WithZ(this Vector3 v, float z)
        {
            return new Vector3(v.x, v.y, z);
        }
/*******************************************************************/
        /// <summary>
        /// Adds the x to Vector3.x
        /// </summary>
        /// <returns>New Vector3.</returns>
        /// <param name="v">V.</param>
        /// <param name="x">The value to add to x.</param>
        public static Vector3 AddX(this Vector3 v, float x)
        {
            return new Vector3(v.x + x, v.y, v.z);
        }
/*******************************************************************/
        /// <summary>
        /// Adds the y to Vector3.y
        /// </summary>
        /// <returns>New Vector3.</returns>
        /// <param name="v">V.</param>
        /// <param name="y">The value to add to y.</param>
        public static Vector3 AddY(this Vector3 v, float y)
        {
            return new Vector3(v.x, v.y + y, v.z);
        }
/*******************************************************************/
        /// <summary>
        /// Adds the z to Vector3.z
        /// </summary>
        /// <returns>New Vector3.</returns>
        /// <param name="v">V.</param>
        /// <param name="z">The value to add to z.</param>
        public static Vector3 AddZ(this Vector3 v, float z)
        {
            return new Vector3(v.x, v.y, v.z + z);
        }
/*******************************************************************/
        /// <summary>
        /// Multiply Vector3.x by x
        /// </summary>
        /// <returns>new Vector3</returns>
        /// <param name="v">V.</param>
        /// <param name="x">The value to multiply to x.</param>
        public static Vector3 MultX(this Vector3 v, float x)
        {
            return new Vector3(v.x * x, v.y, v.z);
        }
/*******************************************************************/
        /// <summary>
        /// Multiply Vector3.y by y
        /// </summary>
        /// <returns>New Vector3.</returns>
        /// <param name="v">V.</param>
        /// <param name="y">The value to multiply to y.</param>
        public static Vector3 MultY(this Vector3 v, float y)
        {
            return new Vector3(v.x , v.y * y, v.z);
        }
/*******************************************************************/
        /// <summary>
        /// Multiply Vector3.z by z
        /// </summary>
        /// <returns>New Vector3.</returns>
        /// <param name="v">V.</param>
        /// <param name="z">The value to multiply to z .</param>
        public static Vector3 MultZ(this Vector3 v, float z)
        {
            return new Vector3(v.x, v.y, v.z * z);
        }
/*******************************************************************/
        /// <summary>
        /// Divide Vector3.x by x
        /// </summary>
        /// <returns>new Vector3</returns>
        /// <param name="v">Vector3.</param>
        /// <param name="x">The value to divide Vector3.x by.</param>
        public static Vector3 DivX(this Vector3 v, float x)
        {
            try {

                return new Vector3(v.x / x, v.y, v.z);
            }
            catch (System.DivideByZeroException) {
                Debug.LogError($"Division of {v.x} by zero.");
            }

            return Vector3.zero;
        }
/*******************************************************************/
        /// <summary>
        /// Divide Vector3.y by y
        /// </summary>
        /// <returns>New Vector3.</returns>
        /// <param name="v">V.</param>
        /// <param name="y">The value to divide Vector3.y by.</param>
        public static Vector3 DivY(this Vector3 v, float y)
        {
             try {

                return new Vector3(v.x, v.y / y, v.z);
            }
            catch (System.DivideByZeroException) {
                Debug.LogError($"Division of {v.y} by zero.");
            }

            return Vector3.zero;
        }
/*******************************************************************/
        /// <summary>
        /// Divide Vector3.z by z
        /// </summary>
        /// <returns>New Vector3.</returns>
        /// <param name="v">V.</param>
        /// <param name="z">The value to divide Vector3.y by.</param>
        public static Vector3 DivZ(this Vector3 v, float z)
        {
            try {

                return new Vector3(v.x, v.y, v.z / z);
            }
            catch (System.DivideByZeroException) {
                Debug.LogError($"Division of {v.z} by zero.");
            }

            return Vector3.zero;
        }
/*******************************************************************/
        /// <summary>
        /// Center of Volume described by a Vector3.
        /// </summary>
        /// <returns>The center of Vector3 .</returns>
        /// <param name="v">Vector3</param>
        public static Vector3 Center(this Vector3 v)
        {
            return new Vector3(v.x + v.x * 0.5f, v.y + v.y * 0.5f, v.z + v.z * 0.5f);
        }
/*******************************************************************/
    public static Vector3 Flattened(this Vector3 vector)
	{
		return new Vector3(vector.x, 0f, vector.z);
	}
/*******************************************************************/
	public static float DistanceFlat(this Vector3 origin, Vector3 destination)
	{
		return Vector3.Distance(origin.Flattened(), destination.Flattened());
	}
/*******************************************************************/
#endregion
    }
}