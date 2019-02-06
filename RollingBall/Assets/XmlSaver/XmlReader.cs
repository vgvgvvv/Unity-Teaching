using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using UnityEditor;
using UnityEngine;

public class XmlReader
{

	public static readonly string SavePath = Path.Combine(Application.streamingAssetsPath, "ShootBall.xml");

	private static readonly string PrefabPath = "XmlBox";

	private static GameObject _prefab;
	public static GameObject Prefab
	{
		get
		{
			if (_prefab == null)
			{
				_prefab = Resources.Load<GameObject>(PrefabPath);
			}
			return _prefab;
		}
	}

	private static Transform _boxRoot;
	
	public static Transform BoxRoot
	{
		get
		{
			if (_boxRoot == null)
			{
				_boxRoot = GameObject.Find("Boxs").transform;
			}
			return _boxRoot;
		}
	}

	public static void CreateSceneFromXml()
	{
		XmlDocument xdoc = new XmlDocument();
		xdoc.Load(SavePath);

		XmlElement root = xdoc.DocumentElement;
		var nodes = root.ChildNodes;
		foreach (XmlElement node in nodes)
		{
			try
			{
				var posStr = node.GetAttribute("pos");
				var posVec = StringHelper.ParseVec3(posStr);

				var eulerStr = node.GetAttribute("euler");
				var eulerVec = StringHelper.ParseVec3(eulerStr);

				var scaleStr = node.GetAttribute("scale");
				var scaleVec = StringHelper.ParseVec3(scaleStr);


				GameObject go = GameObject.Instantiate(Prefab);
				
				go.transform.SetParent(BoxRoot);
				go.transform.position = posVec;
				go.transform.eulerAngles = eulerVec;
				go.transform.localScale = scaleVec;
			}
			catch (Exception e)
			{
				Debug.LogException(e);
				continue;
			}
			

		}
	}
	
}
