using System.Diagnostics;
try
{
    Process process = new Process();
    process.StartInfo.FileName = "notepad.exe";
    for (int i = 0; i < 2; i++)
    {
        Process.Start(process.StartInfo);
    }
}
catch (Exception ex)
{
    Console.WriteLine("Произошла ошибка: " + ex.Message);
}