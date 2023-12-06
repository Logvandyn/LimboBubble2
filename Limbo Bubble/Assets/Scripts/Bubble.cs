using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Logan Van Dyne
 * 12/5/23
 * Bubble Shrink
 */

public class Bubble : MonoBehaviour
{
    public static Bubble instance;
    //How long the bubble lasts 
    public float Duration = 5f;

    // Make it shrink down to it's final size before deletion
    public Vector3 EndScale = Vector3.one * .5f;

    //Starting size (object transform)
    Vector3 Scale;

    // Linear interpolation time (start at 0, end at 1 /)
    float t = 0;

    void OnEnable()
    {
        // initialize  in OnEnable (Replace with awake or start depending on what happens with spawning)
        instance = this;
        Scale = transform.localScale;
        t = 0;
    }

    void Update()
    {
        // Divide deltaTime by the duration to stretch out the time it takes for t to go from 0 to 1.
        t += Time.deltaTime / Duration;

        // Interpolate from base scale to the end scale 
        Vector3 newScale = Vector3.Lerp(Scale, EndScale, t);
        transform.localScale = newScale;

        if (t > 1) //if time is over, detroy bubble
        {
            End(); //(this) destroys the script, not the game bubble itself
        }
    }

    public void End()
    {
        Destroy(this.gameObject);
    }
}
