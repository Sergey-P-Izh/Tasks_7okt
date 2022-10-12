static void Main(string[] args)
{
    string s = "Ароза упала на лапу Азора";
    string ss = "Нажал кабан на баклажан";
    string sss = string.Empty;
    string ssss = string.Empty;

    for (int x = MyLength(s) - 1 ; x >= 0; x--)
    {
        if (s[x].ToString() != " ")
        {
            sss += s[x].ToString().ToLower();
        }
    }

    for (int a = 0; a < MyLength(s); a++)
    {
        if (s[a].ToString() != " ")
        {
             ssss += s[a].ToString().ToLower();
        }
    }
    if (sss = ssss)
    {
        Console.WriteLine("TRUE");
    }
    else 
    {
       Console.WriteLine("FALSE"); 
    }
}
 Console.WriteLine(sss); 
