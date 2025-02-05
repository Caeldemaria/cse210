using System;

public class Writing: Assgniments{
    
    
    private string _title;

    public Writing (string student,string topic,string title): base (student,topic){

_title=title;
    }
    public string GetSummary(){
        return $"Studente: {_studentName} Tópic : {_topic}";
    }
    public string GetWritingInformation(){
        return $"{_title} by {_studentName}";
    }
}