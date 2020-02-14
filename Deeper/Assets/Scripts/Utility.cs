﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Utility
{
    public static Vector3 GetVector3(this Vector2 vector2, float z = 0)
    {
        return new Vector3(vector2.x, vector2.y, z);
    }
}
