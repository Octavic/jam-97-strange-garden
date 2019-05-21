﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Utils 
{
	public static Vector3 WithY(this Vector3 v, float y)
	{
		return new Vector3(v.x, y, v.z);
	}
}
