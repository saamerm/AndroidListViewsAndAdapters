using System;
using System.Collections.Generic;
using System.Linq;

namespace AndroidListViews
{
	public class StudentData
	{
		public static List<Student> Students { get; private set; }
		static StudentData()
		{
			var students = new List<Student>();
			students.Add(new Student() 			{ 				Name = "Aaron K", 				Speciality = "Science" 			}); 			students.Add(new Student() 			{ 				Name = "Nick J", 				Speciality = "English" 			}); 			students.Add(new Student() 			{ 				Name = "Saamer M", 				Speciality = "Math" 			}); 			Students = students.OrderBy(x => x.Name).ToList();
		}
	}
}
