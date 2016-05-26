using System;

namespace DesignPattern
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("简单工厂（Simple Factory）模式");
			Console.WriteLine ("----------------------------------");

			CarFactory carFactory = new CarFactory ();

			Car car = carFactory.CreateCar ("119");
			car.SetOut ();

			car = carFactory.CreateCar ("110");
			car.SetOut ();

			car.GoBack ();


			CarNew.CreateCar ("120").SetOut ();
			CarNew.CreateCar ("120").GoBack ();

			Console.ReadKey ();
		}
	}
}
