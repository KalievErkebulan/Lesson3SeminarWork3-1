Console.Clear();
int n = Convert.ToInt32(Console.ReadLine());

void Cube(int[] n)
{
    int length = n.Length;
    int index = 0;
    while(index < length)
    {
        n[index] = Convert.ToInt32(Math.Pow(index,3));
        index++;
    }
}

void PrintArray(int[] m)
{
    int count = m.Length;
    int counter = 0;
    while(counter<count)
    {
        Console.Write(m [counter] + " ");
        counter++;
    }
}

int [] array = new int[n + 1];
Cube(array);
PrintArray(array);  