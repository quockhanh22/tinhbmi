using System;
using System.Text;

namespace bai1
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.OutputEncoding = Encoding.UTF8;
			double height;
			double weight;
			double bmi;
			//Chiều cao: cm
			//Cân nặng: kg
			Console.WriteLine("Nhập chiều cao : ");
			height = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Nhập cân nặng : ");
			weight = Convert.ToDouble(Console.ReadLine());
			height = height / 100;
			bmi = weight / (height * height);
			Console.WriteLine("BMI của bạn là:{0}", Math.Round(bmi, 4));
			if (bmi < 18.5)
				Console.WriteLine("Thiếu cân");
			else if (bmi >= 18.5 && bmi < 25)
				Console.WriteLine("Bình thường");
			else if (bmi >= 25 && bmi < 30)
				Console.WriteLine("Thừa cân");
			else if (bmi >= 30)
				Console.WriteLine("Béo phì");

		}
	}
}