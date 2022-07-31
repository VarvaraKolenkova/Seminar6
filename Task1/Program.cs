//Количество положительных элементов введенного массива
void GetArray(string[] args)
{
    int size;
    Console.WriteLine("Введите число элементов массива: ");
    size = Convert.ToInt32(Console.ReadLine());
    
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
       Console.WriteLine("Введите каждый элемент массива в виде целых положительных и отрицательных чисел по очереди: ");
       array[i] = int.Parse(Console.ReadLine());
    }        
    Console.WriteLine(String.Join(", ", array));
    
    void QuantityPositiveNumbers(int[] array)
    {
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) count+=1;
    }
    Console.WriteLine($"Количество положительных элементов массива: {count}");
    }
    QuantityPositiveNumbers(array);
}
GetArray(args);
