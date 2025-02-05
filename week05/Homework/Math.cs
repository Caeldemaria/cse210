
using System;

public class Math:Assgniments{
    private string _textBookSection;
    private string _problems;

    public Math(string student,string topic,string textBookSection,string problems):base(student,topic){
          _textBookSection=textBookSection;
           _problems=problems;

    }
    public string  GetSummary(){
        return $"Studente: {_studentName} Tópic : {_topic}";

    }

    public string GetHomework(){
        return $"Section: {_textBookSection} Problems: {_problems}";
    }
}