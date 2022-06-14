using System;

public class Class7
{
	public static void Main1(string[] args)
	{
		int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
		int sum = 0;
		for (int i = 0; i < a.Length; i = i + 2)
		{
			sum = a[i] + a[i + 1];
			Console.WriteLine(sum);
		}
	}
}

//public class Student
//{
//	int aid;
//	string name;
//	int salary;

//	public void setaid(int a)
//	{ this.aid = Aid; }
//	public string getname()
//	{ return Aid; }
//	public void setname(string Ename)
//	{ this.name= Ename; }
//	public string getname()
//	{ return name; }
//	public void setsalary(int payment)
//    {
//		this.salary = payment;
//    }
//	public int getsalary()
//	{ return salary; }
//}
//class Test
//{
//	static void Main(string[] args)
//    {
//		Student s = new Student();
//		s.setAid(1);
//		Console.WriteLine(s.getAid());
//		s.setname("Aditya");
//		Console.WriteLine(s.getname());
//		s.setsalary(30000);
//		Console.WriteLine(s.getsalary());
//    }
//}