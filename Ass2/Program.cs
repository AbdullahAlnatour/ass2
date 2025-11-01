//Ass 2 part 1

Console.WriteLine("Enter size of numbers: ");

int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter numbers to calculate average: ");

int i = 0;
int[] array1 = new int[size];

for (i = 0; i < size; i++)
{
    array1[i] = Convert.ToInt32(Console.ReadLine());
}
i = 0;

Console.WriteLine($"The average of numbers u entered: {array1.Average()}");
Console.WriteLine($"The max of numbers u entered: {array1.Max()}");

//Ass 2 part 2

Console.WriteLine("Enter size of numbers: ");

int size2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter numbers u want to reverse: ");

int[] array2 = new int[size2];

for (i = 0; i < size2; i++)
{
    array2[i] = Convert.ToInt32(Console.ReadLine());
}
Console.Write("Reverse order of numbers: ");
for (i = size2-1; i >= 0 ; i--)
{
    Console.Write(array2[i]+ " ");
}
Console.WriteLine();

//Ass 2 part 3
Console.WriteLine("Enter text: ");
string ?text = Console.ReadLine();

Dictionary<char, int> freq = new Dictionary<char, int>();
char unique_item=' ';
bool x= false;

foreach (var item in text)
{
    if (freq.ContainsKey(item))
    {
        freq[item]++;
    }
    else
    {
        freq[item] = 1;
    }
}

foreach (var item in text)
{
    if (freq[item] == 1)
    {
        unique_item = item;
        x=true;
        break;
    }
}
if (x)
{
    Console.WriteLine($"The first character unique in {text} word is {unique_item}");
}
else
{
    Console.WriteLine("There's no unique character");
}








