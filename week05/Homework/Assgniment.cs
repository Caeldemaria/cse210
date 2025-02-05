using System;

public class Assgniments{
    protected string _studentName;
    protected string _topic;

    public Assgniments(string student, string topic ){
        _studentName=student;
        _topic=topic;

    }

    public string GetSummary(){
        return $"{_studentName} - {_topic}";
    }
}