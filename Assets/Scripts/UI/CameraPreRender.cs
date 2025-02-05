﻿using UnityEngine;
using System.Collections;

public class CameraPreRender : MonoBehaviour
{
    public delegate void PreCullEvent();
    public static PreCullEvent onPreCull;

    void OnPreCull()
    {
        if (onPreCull != null)
        {
            onPreCull();
        }
    }
}
