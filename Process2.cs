﻿using System.Diagnostics;// Используем нужное пространство имен для класса Process

    Process[] process = new Process[3];// Массив для процессов
    for (int i = 0; i < process.Length; i++)
    {
        process[i] = new Process();// Создаем объекты класса Process как каждый элемент массива
    }
    // Прописываем пути для запуска приложений (процессов)
    process[0].StartInfo.FileName = "notepad.exe";
    process[1].StartInfo.FileName = "C:\\Program Files\\Microsoft Office\\Office16\\WINWORD.EXE";
    process[2].StartInfo.FileName = "C:\\Program Files\\Microsoft Office\\Office16\\MSPUB.EXE";
    //Запуск приложений (процессов)
    process[0].Start();
    process[1].Start(); 
    process[2].Start();
try {   // Блок проверки исключений
        int milliseconds = 2000;
        Thread.Sleep(milliseconds);//Задержка работы программы (для наглядности)
    foreach (Process p in process)//Перебор элементов
    {
        Console.WriteLine($"Id: {p.Id}");//айдишник
        Console.WriteLine($"Name: {p.ProcessName}");//наименование
        Console.WriteLine($"VirtualMemory: {p.VirtualMemorySize64}");//размер виртуальной памяти64
    }
    foreach (Process p in Process.GetProcesses())
    {
        // выводим id и имя процесса
        Console.WriteLine($"ID: {p.Id}  Name: {p.ProcessName}");
        Process[] vsProcs = Process.GetProcessesByName("devenv");
        foreach (var proc in vsProcs)
            Console.WriteLine($"ID: {proc.Id}");
    }
}

catch (Exception ex)//Обработка исключений
{
    Console.WriteLine($"Ошибка при завершении процесса: {ex.Message}");
}

