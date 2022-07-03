string[] word1 = { "hello", "2", "world", ":-)" };
string[] word2 = { "1234", "1567", "-2", "computer science" };
string[] word3 = { "Russia", "Denmark", "Kazan" };
string[] word4 = { "Hav", "world", "e a", "nic", "e", "hello", "7845", "day", "!" };

int SearchSize(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) count++;
    }
    return count;
}

string[] ThreeSymbolWord(string[] arr, int size)
{
    string[] newArray = new string[size];

    int j = 0;
    int i = 0;

    while (i < arr.Length)
    {
        if (arr[i].Length <= 3)
        {
            newArray[j] = arr[i];
            i++;
            j++;
        }
        else i++;
    }
    return newArray;
}

void PrintMassiv(string[] wrd)
{
    Console.Write("[ ");
    for (int i = 0; i < wrd.Length; i++) Console.Write(wrd[i] + " ");
    Console.Write("]");
}

int s = SearchSize(word4);
string[] massiv = ThreeSymbolWord(word4, s);

PrintMassiv(word4);
Console.Write(" -> ");
PrintMassiv(massiv);
