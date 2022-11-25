Console.Clear();
void FillArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
            Console.Write($"{array[i]} ");
    }
}

string[] ex1 = {"1", "22", "333", "4444", "333"};
string[] ex2 = new string[ex1.Length];

FillArray (ex1, ex2);
PrintArray(ex2);