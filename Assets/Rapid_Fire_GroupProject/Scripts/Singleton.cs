﻿using UnityEngine;
using System.Collections;

namespace RapidFire
{
	public abstract class SingletonMonobehaviour<T> : MonoBehaviour where T : MonoBehaviour
	{
		static T instance;

		public static T Instance
		{
			get
			{
				if (null == instance)
				{
					instance = FindObjectOfType(typeof(T)) as T;
					if (null == instance)
					{
						GameObject obj = new GameObject(typeof(T).Name);
						instance = obj.AddComponent<T>();
					}
				}

				return instance;
			}
		}
	}


	public abstract class Singleton<T> where T : class, new()
	{
		static T instance;

		public static T Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new T();
				}

				return instance;
			}
		}
	}
}
