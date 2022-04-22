int[,] a;
int[,] b;
int z, x, q, w;
Console.WriteLine("Введите количество строк и столбцов массивов. Количество строк первого массива и столбцов второго массива должны совпадать.");
z = Convert.ToInt32(Console.ReadLine());
x = Convert.ToInt32(Console.ReadLine());
q = Convert.ToInt32(Console.ReadLine());
w = Convert.ToInt32(Console.ReadLine());
if (x == q)
{
    a = new int[z, x];
    b = new int[q, w];

    Console.WriteLine("Введите элементы первого массива");
    for (int i = 0; i < z; i++)
    {
        for (int j = 0; j < x; j++)
        {
            a[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }
    Console.WriteLine("Введите элементы второго массива");
    for (int i = 0; i < q; i++)
    {
        for (int j = 0; j < w; j++)
        {
            b[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }

    int[,] c = new int[z, w];
    for(int i = 0; i < z; i++)
    {
        for(int j = 0; j < w; j++)
        {
            for (int k = 0; k <x; k++)
            {
                c[i, j] += a[i, k] * b[k,j]; 
            }
        }
    }
    Console.WriteLine("Первая матрица");
    for (int i = 0; i < z; i++)
    {
        for (int j = 0; j < x; j++)
        {
            Console.Write(a[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine("Вторая матрица");
    for (int i = 0; i < q; i++)
    {
        for (int j = 0; j < w; j++)
        {
            Console.Write(b[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine("Результирующая матрица");
    for (int i = 0; i < z; i++)
    {
        for (int j = 0; j < w; j++)
        {
            Console.Write(c[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
else
{
    Console.WriteLine("Условия не соблюдены");
}