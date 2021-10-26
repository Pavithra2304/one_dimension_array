using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onedimension_array_assignment
{
	class Program
	{
		public static void salaryDetails()
		{
			float[] salary;
			Console.WriteLine("How many Employee details do yo want to Enter:");
			int n = Convert.ToInt32(Console.ReadLine());
			salary = new float[n];
			Console.WriteLine("Please Enter salaries:");
			for (int i=0;i<n;i++)
			{
				salary[i] = float.Parse(Console.ReadLine());
			}
			Console.WriteLine(salary);
			foreach(float item in salary)
			{
				Console.WriteLine(item);
			}
			
			float large = salary.Max();
			Console.WriteLine("The maximum Salary is :" + large);
			
			float min = salary.Min();
			Console.WriteLine("The minimum Salary is:" + min);
			
			float avg = salary.Average();
			Console.WriteLine("The Average salary is:" + avg);
			Console.Read();
		}

		static void Main(string[] args)
		{
			salaryDetails();
		}
	}
}
