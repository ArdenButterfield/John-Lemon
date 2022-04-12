using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    // Which material gets controlled by this color-changing script?
    public ParticleSystem ps; 

    // What are the two colors that we will interpolate between?
    Vector4 color1 = new Vector4(0.298f, 0.428f, 0.678f, 1.0f); // Blueish
    Vector4 color2 = new Vector4(0.298f, 0.678f, 0.656f, 1.0f); // Greenish

    // How fast will we interpolate between them?
    float shift_speed = 2.0f;

    // Update is called once per frame
    void Update()
    {
        float step = GetStep();
        // Linear interpolation between the two colors
        Vector4 curr_color_vector = color1 * step + color2 * (1 - step);
        Color current_color = curr_color_vector;
        // Set the particle color to the chosen color.
        var main = ps.main;
        main.startColor = current_color;
    }

    float GetStep()
    {
        return (Mathf.Sin(Time.time * shift_speed) * 0.5f) + 1.0f;
    }
}
