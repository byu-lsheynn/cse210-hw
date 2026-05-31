using System;
using System.Text;

public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(new string('-', 30));
        sb.AppendLine($"Title: {_title} by {_studentName}");

        return sb.ToString();
    }
}