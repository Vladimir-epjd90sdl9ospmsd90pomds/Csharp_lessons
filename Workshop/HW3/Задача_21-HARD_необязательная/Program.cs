// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними
//  в N-мерном пространстве. Сначала задается N с клавиатуры, потом задаются координаты точек.


Console.Clear();
Console.WriteLine("Введите кол-во измерений");
int num = Convert.ToInt32(Console.ReadLine());
int[] arrayA = new int[num];
int[] arrayB = new int[num];

for (int i = 0; i < arrayA.Length; i++)
{

    Console.WriteLine($"Введите координату {i + 1}-ого измерения точки А");
    arrayA[i] = Convert.ToInt32(Console.ReadLine());

}

for (int i = 0; i < arrayA.Length; i++)
{

    Console.WriteLine($"Введите координату {i + 1}-ого измерения точки B");
    arrayB[i] = Convert.ToInt32(Console.ReadLine());

}

void lengthCalculate(int[] arrayA, int[] arrayB)
{
    double length = arrayA[0] - arrayB[0];
    for (int i = 1; i < arrayA.Length; i++)
    {

        length = Math.Sqrt(Math.Pow(length, 2) + Math.Pow(arrayA[i] - arrayB[i], 2));
    }

    Console.WriteLine($"Длина отрезка: {length}");
}

lengthCalculate(arrayA, arrayB);