// Задача 3*. Найдите сумму произведений пар чисел в одномерном целочисленном массиве. 
//            Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
//            Если кол-во элементов нечетное, то элемент посередине не учитывать.
//            Результат сложения вывести на экран.1, 3, 8, 3, 2 -> 118, 3, 4, 2 -> 28
// 1. Создать функцию, заполняющий массив.
// 2. Создать функцию, где цикл будет находить произведение пары чисел из массива 
//    и записывать в другой массив результаты 
// 3. Создать функцию, где цикл будет складывать в сумму полученные произведения, 
//    которые находятся в массиве.
// 4. Создать массив на 7 чисел
// 5. Применить функции в порядке: 
//           заполнить массив, найти произведение пар чисел, найти сумму произведений пары чисел. 
// 6. Вывести сумму произведений пары чисел на экран.

// 1. 
void FillArray(int[] arg)
{
   int len = arg.Length;
   for (int i = 0; i < len; i++)
   {
       arg[i] = new Random().Next(-100, 100);
   }
}

// 2. 
int[] ProductPairNum(int[] arg)
{
    int len = arg.Length;
    int[] result = new int[len];
    for (int i = 0; i < len - 1; i++, len--)
    {
        result[i] = arg[i] * arg[len - 1];
    }
    return result;
}

// 3. 
int SumProductPairNum(int[] arg)
{
    int size = arg.Length;
    int result = 0;
    for (int i = 0; i < size; i++)
    {
        result = result + arg[i];
    }
    return result;
}
// 4.
int[] array = new int[7];

// 5.
FillArray(array);
int[] product = ProductPairNum(array);
int sum = SumProductPairNum(product);

// 6. 
Console.WriteLine(sum);