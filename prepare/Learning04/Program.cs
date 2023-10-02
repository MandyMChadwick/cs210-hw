using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignmentOne = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(assignmentOne.GetSummary());

        MathAssignment assignmentTwo = new MathAssignment("Mandy Chadwick", "Times Tables", "5.5", "1-25");
        Console.WriteLine(assignmentTwo.GetSummary());
        Console.WriteLine(assignmentTwo.GetHomeworkList());


    }
}