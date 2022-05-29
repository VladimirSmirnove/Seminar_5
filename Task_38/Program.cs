// Задайте массив вещественных чисел. Найдите
// разницу между максимальным и минимальным
// элементов массива.
Console.Write("Введите количество элементов массива: ");
int elementsCount = int.Parse(Console.ReadLine()); // Задаем переменную (тип int) для количество элементов массива
double [] myArray = new double[elementsCount]; // Создаем массив myArray (тип double ) c присвоением количества элементов массива
for (int i=0; i<elementsCount;i++) // цикл for: в первой части создает переменную i (тип int) и присваивает начальное значение "0", во второй части, условие i<elementsCount, третья часть цикла, если условие выполняется то переменная i увеличивается на единицу
{
  Console.Write($"Введите элемент массива под индексом {i}:\t");
  myArray[i] = double.Parse(Console.ReadLine()); // Вводим элементы массива (тип double)
}
Console.Write("Вывод массива: [");
for (int i=0; i<elementsCount; i++)
{
  Console.Write($"{myArray[i]} "); // Выводим массив
}
Console.WriteLine("]");
double minArray = myArray[0]; // задаем переменную (тип double) с присвоением массива с индексом "0"
double maxArray = myArray[0]; // задаем переменную (тип double) с присвоением массива с индексом "0"
for (int i = 1; i < myArray.Length; i++)
{
  if (myArray[i] < minArray)
  {
      minArray = myArray[i];
  }
  if (myArray[i] > maxArray)
  {
      maxArray = myArray[i];
  }
}
double result = maxArray - minArray;
Console.WriteLine($"Максимальный элемент массива: {maxArray}");
Console.WriteLine($"Минимальный элемент массива: {minArray}");
Console.WriteLine($"{maxArray} - {minArray} = {result}");
 



