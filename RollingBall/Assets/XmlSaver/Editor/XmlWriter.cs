using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using UnityEditor;
using UnityEngine;

public class XmlWriter {

	public static readonly string SavePath = Path.Combine(Application.streamingAssetsPath, "ShootBall.xml");

	[MenuItem("Learn/Xml Saver/Save Scene")]
	public static void Save()
	{
		var boxRoot = GameObject.Find("Boxs");

		var childCount = boxRoot.transform.childCount;

		//创建XmlDocument
		XmlDocument xdoc = new XmlDocument();
		//创建根节点
		var root = xdoc.CreateElement("Root");
		xdoc.AppendChild(root);
		for (int i = 0; i < childCount; i++)
		{
			var child = boxRoot.transform.GetChild(i);
			var childEle = xdoc.CreateElement("box");
			childEle.SetAttribute("pos", child.position.Vec2Str());
			childEle.SetAttribute("euler", child.eulerAngles.Vec2Str());
			childEle.SetAttribute("scale", child.localScale.Vec2Str());
			root.AppendChild(childEle);
		}
		xdoc.Save(SavePath);
		AssetDatabase.Refresh();
	}

	
}
