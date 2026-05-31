using System;
using System.Text;

public class Assignment
{
    protected string _studentName;
    private string _topic;

    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    public string GetSummary()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(" ===== SUMMARY ===== ");
        sb.AppendLine($"Student Name: {_studentName}");
        sb.AppendLine($"Topic: {_topic}");

        return sb.ToString();
    }
}
