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
    public static class MRExtensionMethods_IEnumerators
    {
/*******************************************************************/
//
//                    IEnumerator Functions
//
/*******************************************************************/
#region
        /// <summary>
        /// Moves the GameObject to new position over seconds.
        /// </summary>
        /// <param name="objectToMove">Object to move.</param>
        /// <param name="end">end position.</param>
        /// <param name="seconds">time in secs.</param>
        /// <example>
        /// <code>
        /// StartCoroutine(player.transform.position.MoveOverSeconds(targetPosition, 10f));
        /// </code>
        /// </example>
        public static IEnumerator MoveTo(this GameObject objectToMove, Vector3 end, float seconds)
        {

            float elapsedTime = 0;
            Vector3 startingPos = objectToMove.transform.position;
            WaitForEndOfFrame eof = new WaitForEndOfFrame();

            while (elapsedTime < seconds)
            {
                Vector3 lerper = Vector3.Lerp(startingPos, end, (elapsedTime / seconds));
                objectToMove.transform.position = lerper;

                elapsedTime += Time.deltaTime;
                yield return eof;
            }
            objectToMove.transform.position = end;

        }
/*******************************************************************/
        public static IEnumerator MoveTo(this GameObject objectToMove, Vector3 end, float seconds, float delay)
        {

            float elapsedTime = 0;
            Vector3 startingPos = objectToMove.transform.position;
            WaitForEndOfFrame eof = new WaitForEndOfFrame();

            yield return new WaitForSeconds(delay);

            while (elapsedTime < seconds)
            {
                Vector3 lerper = Vector3.Lerp(startingPos, end, (elapsedTime / seconds));
                objectToMove.transform.position = lerper;

                elapsedTime += Time.deltaTime;
                yield return eof;
            }
            objectToMove.transform.position = end;
        }
/*******************************************************************/
        /// <summary>
        /// Moves/Interpolates Vector3 to new value over seconds.
        /// </summary>
        /// <param name="vectorToMove">Vector3 to change.</param>
        /// <param name="end">Vector3 to move to.</param>
        /// <param name="seconds">time in secs to move to new Vector3.</param>
        /// <example>
        /// <code>
        /// StartCoroutine(currentPosition.MoveOverSeconds(targetPosition, 10f, 2f));
        /// </code>
        /// </example>
        public static IEnumerator MoveTo(this Vector3 vectorToMove, Vector3 end, float seconds, float delay)
        {

            float elapsedTime = 0;
            Vector3 startingPos = vectorToMove;
            WaitForEndOfFrame eof = new WaitForEndOfFrame();

            yield return new WaitForSeconds(delay);

            while (elapsedTime < seconds)
            {
                Vector3 lerper = Vector3.Lerp(startingPos, end, (elapsedTime / seconds));
                vectorToMove = lerper;

                elapsedTime += Time.deltaTime;
                yield return eof;
            }
            vectorToMove = end;
        }
/*******************************************************************/
        public static IEnumerator MoveTo(this Vector3 vectorToMove, Vector3 end, float seconds)
        {

            float elapsedTime = 0;
            Vector3 startingPos = vectorToMove;
            WaitForEndOfFrame eof = new WaitForEndOfFrame();

            while (elapsedTime < seconds)
            {
                Vector3 lerper = Vector3.Lerp(startingPos, end, (elapsedTime / seconds));
                vectorToMove = lerper;

                elapsedTime += Time.deltaTime;
                yield return eof;
            }
            vectorToMove = end;

        }
/*******************************************************************/
        /// <summary>
        /// Moves the GameObject to new LOCAL position over seconds.
        /// </summary>
        /// <param name="objectToMove">Object to move.</param>
        /// <param name="end">end position in LOCAL coordinate system.</param>
        /// <param name="seconds">time in secs.</param>
        /// <example>
        /// <code>
        /// StartCoroutine(player.transform.localPosition.MoveOverSecondsLocal(localTargetPosition, 10f));
        /// </code>
        /// </example>
        public static IEnumerator MoveToLocal(this GameObject objectToMove, Vector3 end, float seconds)
        {

            float elapsedTime = 0;
            Vector3 startingPos = objectToMove.transform.localPosition;
            WaitForEndOfFrame eof = new WaitForEndOfFrame();
            while (elapsedTime < seconds)
            {
                Vector3 lerper = Vector3.Lerp(startingPos, end, (elapsedTime / seconds));
                objectToMove.transform.localPosition = lerper;

                elapsedTime += Time.deltaTime;
                yield return eof;
            }
            objectToMove.transform.localPosition = end;

        }
/*******************************************************************/
  public static IEnumerator MoveToLocal(this GameObject objectToMove, Vector3 end, float seconds, bool die)
        {

            float elapsedTime = 0;
            Vector3 startingPos = objectToMove.transform.localPosition;
            WaitForEndOfFrame eof = new WaitForEndOfFrame();
            while (elapsedTime < seconds)
            {
                Vector3 lerper = Vector3.Lerp(startingPos, end, (elapsedTime / seconds));
                objectToMove.transform.localPosition = lerper;

                elapsedTime += Time.deltaTime;
                yield return eof;
            }
            objectToMove.transform.localPosition = end;

             if (die)
                yield return eof;
                Object.Destroy(objectToMove, 0f);
        }
/*******************************************************************/
        public static IEnumerator MoveToLocal(this GameObject objectToMove, Vector3 end, float seconds, float delay)
        {
            yield return new WaitForSeconds(delay);

            float elapsedTime = 0;
            Vector3 startingPos = objectToMove.transform.localPosition;
            WaitForEndOfFrame eof = new WaitForEndOfFrame();

            while (elapsedTime < seconds)
            {
                Vector3 lerper = Vector3.Lerp(startingPos, end, (elapsedTime / seconds));
                objectToMove.transform.localPosition = lerper;

                elapsedTime += Time.deltaTime;
                yield return eof;
            }
            objectToMove.transform.localPosition = end;

        }
/*******************************************************************/
        /// <summary>
        /// Moves GameObject then destroy it.
        /// </summary>
        /// <param name="objectToMove">GameObject to move.</param>
        /// <param name="end">End position for GO.</param>
        /// <param name="seconds">Time in secs.</param>
        /// <param name="list">List of Gos.</param>
        /// <example>
        /// <code>
        /// StartCoroutine(player.transform.position.MoveTo(targetPosition, 10f, true));
        /// </code>
        /// </example>
        public static IEnumerator MoveTo(this GameObject objectToMove, Vector3 end, float seconds, bool die)
        {
            float elapsedTime = 0;
            Vector3 startingPos = objectToMove.transform.position;
            WaitForEndOfFrame eof = new WaitForEndOfFrame();

            while (elapsedTime < seconds)
            {
                Vector3 lerper = Vector3.Lerp(startingPos, end, (elapsedTime / seconds));
                objectToMove.transform.position = lerper;

                elapsedTime += Time.deltaTime;
                yield return eof;
            }

            objectToMove.transform.position = end;

            if (die)
                yield return eof;
                Object.Destroy(objectToMove, 0f);
        }
/*******************************************************************/
        /// <summary>
        /// Rotate GameObject over seconds.
        /// </summary>
        /// <param name="objectToRotate">GameObject to rotate.</param>
        /// <param name="end">rotate to this Quaternion.</param>
        /// <param name="seconds">time in secs over which to rotate.</param>
        /// <example>
        /// <code>
        /// StartCoroutine(player.transform.rotation.RotateOverSeconds(rotateTo, 2f));
        /// </code>
        /// </example>
        public static IEnumerator RotateTo(this GameObject objectToRotate, Quaternion end, float seconds)
        {
            float elapsedTime = 0;
            Quaternion startingRotation = objectToRotate.transform.rotation;
            WaitForEndOfFrame eof = new WaitForEndOfFrame();

            while (elapsedTime < seconds)
            {
                Quaternion lerper = Quaternion.Lerp(startingRotation, end, (elapsedTime / seconds));
                objectToRotate.transform.rotation = lerper;

                elapsedTime += Time.deltaTime;
                yield return eof;
            }
            objectToRotate.transform.rotation = end;

        }
/*******************************************************************/
        /// <summary>
        /// Rotate GameObject over seconds.
        /// </summary>
        /// <param name="objectToRotate">GameObject to rotate.</param>
        /// <param name="end">rotate to this Quaternion.</param>
        /// <param name="seconds">time in secs over which to rotate.</param>
        public static IEnumerator RotateTo(this Quaternion objectToRotate, Quaternion end, float seconds)
        {
            float elapsedTime = 0;
            Quaternion startingRotation = objectToRotate;
            WaitForEndOfFrame eof = new WaitForEndOfFrame();
            while (elapsedTime < seconds)
            {
                Quaternion lerper = Quaternion.Lerp(startingRotation, end, (elapsedTime / seconds));
                objectToRotate = lerper;

                elapsedTime += Time.deltaTime;
                yield return eof;
            }
            objectToRotate = end;
        }
/*******************************************************************/
        public static IEnumerator RotateTo(this GameObject objectToRotate, Vector3 end, float seconds)
        {
            float elapsedTime = 0;
            Quaternion startingRotation = objectToRotate.transform.rotation;
            Quaternion endRotation = Quaternion.Euler(end);

            WaitForEndOfFrame eof = new WaitForEndOfFrame();
            while (elapsedTime < seconds)
            {

                Quaternion lerper = Quaternion.Lerp(startingRotation, endRotation, (elapsedTime / seconds));
                objectToRotate.transform.rotation = lerper;

                elapsedTime += Time.deltaTime;
                yield return eof;
            }
            objectToRotate.transform.rotation = endRotation;
        }
/*******************************************************************/
        /// <summary>
        /// Rotate LOCAL Quaternion over seconds.
        /// </summary>
        /// <param name="objectToRotate">Quaternion to rotate.</param>
        /// <param name="end">rotate to this LOCAL Quaternion.</param>
        /// <param name="seconds">time in secs over which to rotate.</param>
        public static IEnumerator RotateToLocal(this GameObject objectToRotate, Quaternion end, float seconds)
        {
            float elapsedTime = 0;
            Quaternion startingRotation = objectToRotate.transform.localRotation;
            WaitForEndOfFrame eof = new WaitForEndOfFrame();
            while (elapsedTime < seconds)
            {
                Quaternion lerper = Quaternion.Lerp(startingRotation, end, (elapsedTime / seconds));

                objectToRotate.transform.localRotation = lerper;

                elapsedTime += Time.deltaTime;
                yield return eof;
            }
            objectToRotate.transform.localRotation = end;

        }
/*******************************************************************/
 public static IEnumerator RotateToLocal(this GameObject objectToRotate, Vector3 end, float seconds)
        {
            float elapsedTime = 0;
            Quaternion startingRotation = objectToRotate.transform.localRotation;
            Quaternion endRotation = Quaternion.Euler(end);

            WaitForEndOfFrame eof = new WaitForEndOfFrame();
            while (elapsedTime < seconds)
            {
                Quaternion lerper = Quaternion.Lerp(startingRotation, endRotation, (elapsedTime / seconds));

                objectToRotate.transform.localRotation = lerper;

                elapsedTime += Time.deltaTime;
                yield return eof;
            }

            objectToRotate.transform.localRotation = endRotation;
        }
/*******************************************************************/
        /// <summary>
        /// Rotates the GameObject over seconds; start after initial delay.
        /// </summary>
        /// <param name="objectToRotate">GameObject to rotate.</param>
        /// <param name="end">Final Quaternion.</param>
        /// <param name="seconds">Time in secs for rotation.</param>
        /// <param name="delay">Delay in secs before starting rotation.</param>
        public static IEnumerator RotateTo(this GameObject objectToRotate, Quaternion end, float seconds, float delay)
        {
            float elapsedTime = 0;
            Quaternion startingRotation = objectToRotate.transform.rotation;
            WaitForEndOfFrame eof = new WaitForEndOfFrame();

            yield return new WaitForSeconds(delay);

            while (elapsedTime < seconds)
            {
                Quaternion lerper = Quaternion.Lerp(startingRotation, end, (elapsedTime / seconds));
                objectToRotate.transform.rotation = lerper;

                elapsedTime += Time.deltaTime;
                yield return eof;
            }
            objectToRotate.transform.rotation = end;

        }
/*******************************************************************/
        /// <summary>
        /// Rotates the GameObject over seconds in LOCAL system; start after initial delay.
        /// </summary>
        /// <param name="objectToRotate">GameObject to rotate.</param>
        /// <param name="end">Final Quaternion.</param>
        /// <param name="seconds">Time in secs for rotation.</param>
        /// <param name="delay">Delay in secs before starting rotation.</param>
        public static IEnumerator RotateToLocal(this GameObject objectToRotate, Quaternion end, float seconds, float delay)
        {
            float elapsedTime = 0;
            Quaternion startingRotation = objectToRotate.transform.localRotation;
            WaitForEndOfFrame eof = new WaitForEndOfFrame();

            yield return new WaitForSeconds(delay);

            while (elapsedTime < seconds)
            {
                Quaternion lerper = Quaternion.Lerp(startingRotation, end, (elapsedTime / seconds));
                objectToRotate.transform.localRotation = lerper;

                elapsedTime += Time.deltaTime;
                yield return eof;
            }

            objectToRotate.transform.localRotation = end;
        }
/*******************************************************************/
        /// <summary>
        /// Scales GameObject over seconds.
        /// </summary>
        /// <param name="objectToScale">GameObject to scale.</param>
        /// <param name="end">Final size for GO.</param>
        /// <param name="seconds">Time in secs.</param>
        public static IEnumerator ScaleTo(this GameObject objectToScale, Vector3 end, float seconds)
        {
            float elapsedTime = 0;
            Vector3 start = objectToScale.transform.localScale;
            WaitForEndOfFrame eof = new WaitForEndOfFrame();

            while (elapsedTime < seconds)
            {
                objectToScale.transform.localScale = Vector3.Lerp(start, end, (elapsedTime / seconds));
                elapsedTime += Time.deltaTime;

                yield return eof;
            }

            objectToScale.transform.localScale = end;
        }
/*******************************************************************/
        /// <summary>
        /// Scales GameObject over seconds with delay.
        /// </summary>
        /// <param name="objectToScale">GameObject to scale.</param>
        /// <param name="end">Final size for GO.</param>
        /// <param name="seconds">Time in secs.</param>
        /// <param name="delay">Delay before starting scaling.</param>
        public static IEnumerator ScaleTo(this GameObject objectToScale, Vector3 end, float seconds, float delay)
        {
            float elapsedTime = 0;
            Vector3 start = objectToScale.transform.localScale;
            WaitForEndOfFrame eof = new WaitForEndOfFrame();

            yield return new WaitForSeconds(delay);

            while (elapsedTime < seconds)
            {
                objectToScale.transform.localScale = Vector3.Lerp(start, end, (elapsedTime / seconds));
                elapsedTime += Time.deltaTime;

                yield return eof;
            }
            objectToScale.transform.localScale = end;

        }
/*******************************************************************/
        public static IEnumerator ScaleTo(this GameObject objectToScale, Vector3 end, float seconds, bool die)
        {
            float elapsedTime = 0;
            Vector3 start = objectToScale.transform.localScale;
            WaitForEndOfFrame eof = new WaitForEndOfFrame();

            while (elapsedTime < seconds)
            {
                objectToScale.transform.localScale = Vector3.Lerp(start, end, (elapsedTime / seconds));
                elapsedTime += Time.deltaTime;

                yield return eof;
            }
            objectToScale.transform.localScale = end;

            if (die)
                yield return eof;
                Object.Destroy(objectToScale, 0f);
        }
/*******************************************************************/
        public static IEnumerator LightIntensity(this Light light, float endLight, float seconds)
        {
            float elapsedTime = 0;
            float startingLight = light.intensity;
            WaitForEndOfFrame eof = new WaitForEndOfFrame();

            while (elapsedTime < seconds)
            {
                light.intensity = Mathf.Lerp(startingLight, endLight, (elapsedTime / seconds));
                elapsedTime += Time.deltaTime;
                yield return eof;
            }
            light.intensity = endLight;
        }
/*******************************************************************/
        public static IEnumerator IntensityPulse(this Light light, float endLight, float seconds)
        {
            float elapsedTime = 0;
            float startingLight = light.intensity;

            WaitForEndOfFrame eof = new WaitForEndOfFrame();

            while (elapsedTime < (seconds * 0.5))
            {
                light.intensity = Mathf.Lerp(startingLight, endLight, (elapsedTime / seconds));
                elapsedTime += Time.deltaTime;
                yield return eof;
            }
            light.intensity = endLight;

            while (elapsedTime >= (seconds * 0.5) && elapsedTime < seconds)
            {
                light.intensity = Mathf.Lerp(endLight, startingLight, (elapsedTime / seconds));
                elapsedTime += Time.deltaTime;
                yield return eof;
            }
            light.intensity = startingLight;
        }
/*******************************************************************/
        public static IEnumerator LightRange(this Light light, float endRange, float seconds)
        {
            float elapsedTime = 0;
            float startingRange = light.range;
            WaitForEndOfFrame eof = new WaitForEndOfFrame();

            while (elapsedTime < seconds)
            {
                light.range = Mathf.Lerp(startingRange, endRange, (elapsedTime / seconds));
                elapsedTime += Time.deltaTime;
                yield return new WaitForEndOfFrame();
            }

            light.range = endRange;
        }
/*******************************************************************/
        public static IEnumerator ColorPulse(this Light myLight, Color toColor, float seconds)
        {
            float elapsedTime = 0;
            Color startingColor = myLight.color;
            WaitForEndOfFrame eof = new WaitForEndOfFrame();

            while (elapsedTime < (seconds * 0.5))
            {
                myLight.color = Color.Lerp(startingColor, toColor, (elapsedTime / seconds));
                elapsedTime += Time.deltaTime;
                yield return eof;
            }
            myLight.color = toColor;

            while (elapsedTime >= (seconds * 0.5) && elapsedTime < seconds)
            {
                myLight.color = Color.Lerp(toColor, startingColor, (elapsedTime / seconds));
                elapsedTime += Time.deltaTime;
                yield return eof;
            }
            myLight.color = startingColor;
        }
/*******************************************************************/
        public static IEnumerator ColorPulse(this Material myMat, Color toColor, float seconds)
        {
            float elapsedTime = 0;
            Color startingColor = myMat.color;

            WaitForEndOfFrame eof = new WaitForEndOfFrame();

            while (elapsedTime < (seconds * 0.5))
            {
                myMat.color = Color.Lerp(startingColor, toColor, (elapsedTime / seconds));
                elapsedTime += Time.deltaTime;
                yield return eof;
            }
            myMat.color = toColor;

            while (elapsedTime >= (seconds * 0.5) && elapsedTime < seconds)
            {
                myMat.color = Color.Lerp(toColor, startingColor, (elapsedTime / seconds));
                elapsedTime += Time.deltaTime;
                yield return eof;
            }
            myMat.color = startingColor;
        }
/*******************************************************************/
        public static IEnumerator ColorTo(this Light start, Color end, float seconds)
        {
            float elapsedTime = 0;
            Color startColor = start.color;
            WaitForEndOfFrame eof = new WaitForEndOfFrame();

            while (elapsedTime < seconds)
            {
                start.color = Color.Lerp(startColor, end, (elapsedTime / seconds));
                elapsedTime += Time.deltaTime;
                yield return eof;
            }

            start.color = end;
        }
/*******************************************************************/
        public static IEnumerator ColorTo(this Material start, Color end, float seconds)
        {
            float elapsedTime = 0;
            Color startColor = start.color;
            WaitForEndOfFrame eof = new WaitForEndOfFrame();

            while (elapsedTime < seconds)
            {
                start.color = Color.Lerp(startColor, end, (elapsedTime / seconds));
                elapsedTime += Time.deltaTime;
                yield return eof;
            }

            start.color = end;
        }
/*******************************************************************/
        public static IEnumerator ColorTo(this GameObject start, Color end, float seconds)
        {
            float elapsedTime = 0;
            Material mat = start.GetComponent<Renderer>().material;
            Color startColor = mat.color;
            WaitForEndOfFrame eof = new WaitForEndOfFrame();

            while (elapsedTime < seconds)
            {
                mat.color = Color.Lerp(startColor, end, (elapsedTime / seconds));
                elapsedTime += Time.deltaTime;
                yield return eof;
            }

            mat.color = end;
        }
/*******************************************************************/
#endregion
/*******************************************************************/
    }
}