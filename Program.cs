Console.WriteLine("Введите количество элементов в массиве строк: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] arr1 = new string[size];

for (int i = 0; i < size; i++)
{
    Console.Write("Введите элемент массива: ");
    string result = Console.ReadLine()!;
    arr1[i] = result;
}
Console.WriteLine();
Console.Write("Введенный массив: [");
Console.Write(string.Join(",", arr1));
Console.Write("]");

int count = 0;
int max = 3;


for (int i = 0; i < arr1.Length; i++)
{
    if (arr1[i].Length <= max)
    {
        count++;
    }
}
Console.WriteLine();


