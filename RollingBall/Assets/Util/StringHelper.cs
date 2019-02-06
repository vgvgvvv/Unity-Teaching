using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public static class StringHelper {

	//C#的语法糖——扩展方法
	public static string Vec2Str(this Vector3 vec)
	{
		StringBuilder builder = new StringBuilder();
		builder.Append(vec.x).Append(",").Append(vec.y).Append(",").Append(vec.z);
		return builder.ToString();
	}

	public static Vector3 ParseVec3(string vecStr)
	{
		var vecArr = vecStr.Split(',');
		if (vecArr.Length < 3)
		{
			throw new Exception("解析Vector3失败！字符串为" + vecStr);
		}
		return new Vector3(float.Parse(vecArr[0]), float.Parse(vecArr[1]), float.Parse(vecArr[2]));
	}
}
