using System.Reflection.Metadata.Ecma335;

public class WritingAssignment : Assignment
{
    private string _title;
    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;

    }
    public string GetWritingInformation()
    {
        string studentName = getStudentName();
        return $"{_title} by {studentName}";
    }
}




/*    

    public string GetWritingInformation()
    {
        // Notice that we are calling the getter here because _studentName is private in the base class
        string studentName = GetStudentName();

        return $"{_title} by {studentName}";
    }*/