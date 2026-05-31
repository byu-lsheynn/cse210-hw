using System;
using System.Text;

public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(new string('-', 30));
        sb.AppendLine($"Section: {_textbookSection}");
        sb.AppendLine($"Problems: {_problems}");

        return sb.ToString();
    }
}