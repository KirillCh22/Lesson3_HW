﻿// Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите разницу между максимальным и минимальным элементов массива.
// * массив [2.2 0.4 9.11 7.2 78.98] => 78.58
// * массив [1.22 4.5 3.33] => 3.28


// Делаем отсутуп
Console.WriteLine("");

//-----------  ПРОСИМ ПОЛЬЗОВАТЕЛЯ ВВЕСТИ ЧИСЛО, КОТОРОЕ БУДЕТ ЯВЛЯТЬСЯ РАЗМЕРОМ МАССИВА ---------------------------------
Console.Write("Введите количество цифр в массиве: ");
int size_arr = Convert.ToInt32(Console.ReadLine());

//------------  ИНИЦИАЛИЗИРУЕМ НОВЫЙ МАССИВ  ------------------------------
double[] array = new double[size_arr]; 

//====================  АЛГОРИТМ ПО ЗАПОЛНЕНИЮ НОВОГО МАССИВА  ==========================
Console.WriteLine("");
for(int i = 0; i < size_arr; i++)
{
    Console.Write("Введите вещественное число с ненулевой дробной частью {0}: " , i + 1);
    array[i] = Convert.ToDouble(Console.ReadLine());
}

Console.WriteLine("");          // ДЕЛАЕМ ОТСТУП

//======================  ВЫВОД НАШЕГО МАССИВА НА ЭКРАН  ===============================
Console.Write("Massiv array = [");
for(int i = 0; i < size_arr; i++)
{
    if (i == size_arr-1) Console.Write(array[i] + "]");
    else Console.Write(array[i] + ", ");
}

// -------------  СОЗДАЕМ ПЕРЕМЕННЫЕ MAX И MIN В КОТОРЫХ БУДУТ ХРАНИТЬСЯ НАШИ ЗНАЧЕНИЯ  ------------------------------
double max_value = array[0];
double min_value = array[0];

//============================  АЛГОРИТМ ПО ПОЛУЧЕНИЮ MAX И MIN ЧИСЛА В МАССИВЕ  ===================================
for(int i = 1; i < size_arr; i++)     // НАЧИНАЕМ С 1, ПОТОМУ ЧТО ЗНАЧЕНИЯ ПОД ИНДЕКСОМ 0 УЖЕ ПРИСВОЕНЫ MAX И MIN ПРИ ИНИЦИАЛИЗАЦИИ ПЕРЕМЕННЫХ
{
    if(array[i] >= max_value) max_value = array[i];
    else if (array[i]<= min_value) min_value = array[i];
}

//--------------------  ВЫВОД НА ЭКРАН МАКСИМАЛЬНОГО ЗНАЧЕНИЯ МАССИВА И МИНИМАЛЬНОГО ЗНАЧЕНИЯ  ----------------------------------
Console.WriteLine("");
Console.WriteLine("max_value = " + max_value);
Console.WriteLine("min_value = " + min_value);


//------------------ ИНИЦИАЛИЗИРУЕМ ПЕРЕМЕННУЮ ДЛЯ ХРАНЕНИЯ РЕЗУЛЬТАТА ВЫЧИТАНИЯ MAX ИЗ MIN -------------------------
double result = max_value - min_value;
// ------------------  ВЫВОД НА ЭКРАН РЕЗУЛЬТАТА -------------------------------------------
Console.WriteLine("Max - Min = " + result);




