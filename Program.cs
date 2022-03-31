Console.WriteLine(ReverseAndNot(12345));

static string ReverseAndNot(int i)
{  
    return String.Join("", i.ToString().Reverse()) + i.ToString();
}