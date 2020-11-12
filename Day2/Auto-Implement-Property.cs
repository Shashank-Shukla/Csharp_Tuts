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
  }
}
