using System.Reflection;
using ControlFlowAndLoops;

List<string> languages = new() { "C#", "F#", "VB", "C++", "Python", "Delphi" };

Sequences.DisplayListWithIndex_ForEach(languages);

string filePath = Assembly.GetExecutingAssembly()!.Location;
Console.WriteLine($"Entry assembly is {Path.GetFileName(filePath)}");
Console.WriteLine("Folders are:");
foreach (string folder in FolderProcessor.EnumParentName_For(filePath).Reverse())
{
    Console.WriteLine(folder);
}
