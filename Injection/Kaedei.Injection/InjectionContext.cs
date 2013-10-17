using System;
using System.Collections.Generic;

namespace Kaedei.Injection
{
	public class InjectionContext
	{
		private static readonly Lazy<InjectionContext> m_defaultContext = new Lazy<InjectionContext>();

		public static InjectionContext Default
		{
			get { return m_defaultContext.Value; }
		}

		private Dictionary<Type, Type> m_types = new Dictionary<Type, Type>();
		private HashSet<Type> m_reusableTypes = new HashSet<Type>();
		private Dictionary<Type, object> m_reusableObjects = new Dictionary<Type, object>();

		/// <summary>
		/// 获取已绑定的对象
		/// </summary>
		public T GetObject<T>()
		{
			var type = typeof(T);
			return (T)GetObject(type);
		}

		/// <summary>
		/// 获取已绑定的对象
		/// </summary>
		public object GetObject(Type type)
		{
			if (!m_types.ContainsKey(type))
				throw new KeyNotFoundException(type.FullName);
			var targetType = m_types[type];
			if (m_reusableTypes.Contains(type))
			{
				if (m_reusableObjects.ContainsKey(type))
				{
					return m_reusableObjects[type];
				}
				else
				{
					var newObject = Activator.CreateInstance(targetType);
					m_reusableObjects[type] = newObject;
					return newObject;
				}
			}
			return Activator.CreateInstance(targetType);
		}

		/// <summary>
		/// 绑定需注入的类型
		/// </summary>
		public void Bind<T1, T2>(bool reusable = false)
		{
			Bind(typeof(T1), typeof(T2), reusable);
		}

		private void Bind(Type memberType, Type initializedType, bool reusable = false)
		{
			if (memberType == null)
				throw new ArgumentNullException("memberType");
			if (initializedType == null)
				throw new ArgumentNullException("initializedType");
			m_types[memberType] = initializedType;
			if (reusable)
			{
				m_reusableTypes.Add(memberType);
			}
		}
	}
}