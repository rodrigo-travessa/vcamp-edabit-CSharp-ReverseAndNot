using System;
using System.Linq;
public class Program
{
    public static string ReverseAndNot(int i) {
        
        return String.Join("", i.ToString().Reverse()) + i.ToString();
			
		}
}
