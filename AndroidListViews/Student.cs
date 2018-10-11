using System;
namespace AndroidListViews
{
	public class Student
	{
		public string Name { get; set; }

		public string Speciality { get; set; }

		public override string ToString()
		{
			return Name + " " + Speciality;
		}
	}
}
