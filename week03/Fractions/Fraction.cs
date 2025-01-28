using System;
using System.Diagnostics;

public class Fraction{
    private int _top;
    private int _bottom;

    public Fraction(){
        _top=1;
        _bottom=1;
    }
    public Fraction(int WholeNumber){
        _top=WholeNumber;
        _bottom=1;
    }
    public Fraction(int top, int bottom){
        _top=top;
        _bottom=bottom;
    }
    
    public  string GetFractionsString(){
        return  $"{_top}/{_bottom}";
    }
    public double GetDecimal(){
        return (double)_top/(double)_bottom;
    }
}