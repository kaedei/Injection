Injection
=========

A simple IOC/DI framework of .NET. Really easy to use.

只有100行的.NET IOC/DI框架！你只需要在属性上加上[Inject]就可以了，非常容易使用！

使用方法：
先创建一个基类，在构造函数中执行注入操作
```
public abstract class InjectedController : IInjectable
{
	public InjectedController()
	{
		this.Inject();
	}

	public InjectionContext InjectionContext { get; set; }
}
```


然后让一个类继承它，并建立含有[Inject]特性的属性。
```
public class Controller : InjectedController
{
	[Inject]
	public IService MyService { get; set; } 
}
```

最后在程序初始化时绑定接口和实现，就完成啦！！就是这么简单>_<
```
private static void RegisterBinding()
{
	InjectionContext.Default.Bind<IService, ServiceImpl>();
}
```


作者：Kaedei
http://blog.sina.com.cn/kaedei

