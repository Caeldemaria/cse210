using System;

public class resume{
public string _name;
public List <Jobs> _Job= new List<Jobs>();

public void Display(){
    Console.WriteLine($"Name: {_name} ");
    Console.WriteLine("Jobs: ");

    foreach (Jobs Jobs in _Job ){
        Jobs.Display();
    }
}
}