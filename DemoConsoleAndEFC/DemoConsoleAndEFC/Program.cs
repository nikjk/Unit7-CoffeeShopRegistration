//



using DemoConsoleAndEFC;

using (SchoolContext db = new SchoolContext())
{
    // Create new student
    Student studentToAdd = new Student();
    studentToAdd.Name = "Sally";


    // Add to the database
    db.Students.Add(studentToAdd);

    // Save changes meade to the database
    db.SaveChanges();
}// Connection Closes