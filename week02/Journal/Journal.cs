using System;

public class Journal  
{  
    private List<Entry> _entries = new List<Entry>();  

    public void AddEntry(Entry newEntry)  
    {  
        _entries.Add(newEntry);  
    }  

    public void DisplayAll()  
    {  
        foreach (var entry in _entries)  
        {  
            entry.Display();  
            Console.WriteLine(); // Espaco entre entradas  
        }  
    }  

    public void SaveToFile(string file)  
    {  
        using (StreamWriter writer = new StreamWriter(file))  
        {  
            foreach (var entry in _entries)  
            {  
                writer.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");  
            }  
        }  
    }  

    public void LoadFromFile(string file)  
    {  
        if (File.Exists(file))  
        {  
            _entries.Clear();  
            foreach (var line in File.ReadAllLines(file))  
            {  
                var parts = line.Split('|');  
                if (parts.Length == 3)  
                {  
                    var entry = new Entry(parts[0], parts[1], parts[2]);  
                    _entries.Add(entry);  
                }  
            }  
        }  
    }  
}  