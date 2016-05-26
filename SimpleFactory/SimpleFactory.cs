using System;

/// <summary>
/// 简单工厂（Simple Factory）模式
/// </summary>
namespace DesignPattern
{
	/// <summary>
	/// 车辆抽象类
	/// </summary>
	public abstract class Car
	{
		/// <summary>
		/// 出发
		/// </summary>
		public abstract void SetOut();

		/// <summary>
		/// 返回
		/// </summary>
		public abstract void GoBack();
	}

	public class Car119:Car
	{

		public override void SetOut()
		{
			Console.WriteLine ("火警出发！救火！");
		}

		public override void GoBack()
		{
			Console.WriteLine ("火警返回！");
		}
	}

	public class Car120:Car
	{
		public override void SetOut()
		{
			Console.WriteLine ("救护车出发！救人！");
		}

		public override void GoBack()
		{
			Console.WriteLine ("救护车返回！");
		}
	}

	public class Car110:Car
	{
		public override void SetOut()
		{
			Console.WriteLine ("警车出发！抓人！");
		}

		public override void GoBack()
		{
			Console.WriteLine ("警车返回！");
		}
	}

	public class CarFactory
	{
		public Car CreateCar(string CarType)
		{
			if (CarType == "119") {
				return new Car119 ();
			} else if (CarType == "120") {
				return new Car120 ();
			}
			else
			{
				return new Car110();
			}
		}
	}
}

