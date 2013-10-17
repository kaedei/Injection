using System;

namespace Kaedei.Injection
{
	/// <summary>
	/// 将属性标记为注入属性
	/// </summary>
	[AttributeUsage(AttributeTargets.Property)]
	public class InjectAttribute : Attribute
	{

	}
}