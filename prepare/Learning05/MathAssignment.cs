public class MathAssignment : Assignment
{
    private string homeworkList;

    public MathAssignment(string studentName, string topic, string homeworkList)
        : base(studentName, topic) // Call the base class constructor
    {
        this.homeworkList = homeworkList;
    }

    public string GetHomeworkList()
    {
        return homeworkList;
    }
}