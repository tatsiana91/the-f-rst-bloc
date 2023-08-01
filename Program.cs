string[] Array = new string[3];
System.Console.WriteLine("Введите : ");
FillArray(Array);
PrintArray(Array);
System.Console.WriteLine();
System.Console.WriteLine("Новый массив:");

void FillArray(string[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        Array[i] = Console.ReadLine() ?? "";
    }
}
void PrintArray(string[] Array)
{
  
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write(Array[i] + " ");
    }
}
int SecondArray(string[] Array)
{
    int count = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i].Length <= 3)
        {
            count++;
        }
    }
    return count;
}
string[] TransferElements(string[] Array)
{
    string[] Array1 = new string[SecondArray(Array)];
    for (int i = 0,j=0; i < Array.Length; i++)
    {
        if (Array[i].Length <= 3)
        {
            Array1[j]=Array[i];
            j++;
        }
    }
    return Array1;
}
if (SecondArray(Array) == 0) { System.Console.WriteLine("[]"); }
else
{
    string[] Array1 = TransferElements(Array);
    PrintArray(Array1);
}


