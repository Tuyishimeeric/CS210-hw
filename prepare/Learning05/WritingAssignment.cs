public class WritingAssignment : Assignment
{
    private string writingTopic;

    public WritingAssignment(string studentName, string topic, string writingTopic)
        : base(studentName, topic) // Call the base class constructor
    {
        this.writingTopic = writingTopic;
    }

    public string GetWritingInformation()
    {
        return $"{GetStudentName()} - Writing Topic: {writingTopic}"; // Accessing studentName through the Get method
    }
}
