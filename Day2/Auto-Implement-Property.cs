// An example of auto implement property

using System;
using System.Collections.Generic;
using System.Linq;

public class Course{
  public string title {get; set;}   // Microsoft's Auto Implement property.
  public int duration {get; set;}   // We don't need to define any getter or setter implicitely.
}

public class CourseDetails
{
  public static void Main()
  {
    Course ob1 = new Course;

    // Style-1:::
    ob1.title = "Software Engineering";
    ob1.duration = 4;

    //Style-2:::
    Course ob2 = new Course {title = "C-Sharp", duration = 5};
    Course ob3 = new Course {title = "Cpp", duration = 3};
    
    // Dynamic Array -> Collections
    // List, style 1
    List<Course> courselist = new List<Course>();
    courselist.Add(ob1);
    courselist.Add(ob2);
    courselist.Add(ob3);

    //Style-2, on the fly!!
    courselist.Add(new Course {title = "Java", duration = 6});
    courselist.Add(new Course {title = "Microservices", duration = 7});

    foreach(Course i in courselist)
      Console.WriteLine($"Course-Name: {i.title} of {i.duration} weeks");
  }
}
