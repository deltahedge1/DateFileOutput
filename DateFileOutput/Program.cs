// See https://aka.ms/new-console-template for more information
using System;
using System.IO;

string? DirectoryPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
string OutputPath = Path.Combine(DirectoryPath, "..", "..", "..", "txt_output", "output.txt");

DateTime currentDateTime = DateTime.Now;
string formattedDateTime = currentDateTime.ToString("yyyy-MM-dd HH:mm:ss");

Console.WriteLine(Path.GetFullPath(OutputPath));
Console.WriteLine($"current time is {formattedDateTime}");

using (StreamWriter writer = new StreamWriter(OutputPath))
{
    writer.WriteLine(formattedDateTime);
}