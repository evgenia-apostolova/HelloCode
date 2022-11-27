// Type 1
/*
void Method1()
{
    Console.WriteLine("Author ...");
}
Method1();
*/

// Type 2
/*
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2(msg: "Message text");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
    Console.WriteLine(msg);
    i++;
    }
}
Method21(msg: "Text", count: 4);
*/
// Type 3
/*
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);

// Type 4
string Method4(int count, string c)
{
    int i = 0;
    string result = "";
    for ( int i = 0; i < count; i++)
    while (int i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "asdf");
Console.WriteLine(res);
*/

string Method4(int count, string text)
{
    string result = "";

for (int i = 0; i <count; i++)
    {
        result = result + text;
    }
    return result;
}

string res = Method4(10, "z");
Console.WriteLine(res);

