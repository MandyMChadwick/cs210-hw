class Activity
{
    private string _string;
    private string _description;
    private int _duration;

    Activity()
    {

    }

    public void DisplayStartingMessage()
    {
        string activityName = "activity";
        Console.Write($"Welcome to the {activityName} ");
    }


    public void DisplayEndingMessage()
    {
        Console.WriteLine("You have completed {activity} {duration}");
    }

    public void ShowSpinner(int seconds)
    {

    }

    public void ShowCountDown(int seconds)
    {

    }


}