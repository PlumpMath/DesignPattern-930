using System;

namespace DesignPattern
{
	/// <summary>
	/// 车辆类
	/// </summary>
	public class CarNew
	{
		/// <summary>
		/// 出发
		/// </summary>
		public virtual void SetOut()
		{
			
		}


		/// <summary>
		/// 返回
		/// </summary>
		public virtual void GoBack()
		{
			
		}

		public static CarNew CreateCar(string CarType)
		{
			if (CarType == "119") {
				return new CarNew119 ();
			} else if (CarType == "120") {
				return new CarNew120 ();
			}
			else
			{
				return new CarNew110();
			}
		}
	}

	public class CarNew119:CarNew
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

	public class CarNew120:CarNew
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

	public class CarNew110:CarNew
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
}

