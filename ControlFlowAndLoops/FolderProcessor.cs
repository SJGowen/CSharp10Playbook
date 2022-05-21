/// <summary>
/// Loop Design
/// * 'foreach' for sequences
/// * 'for' if you need to user the index of a list
/// * 'do' if the loop must execute at least once
/// * 'for' is equivalent to 'while' 
///   Use whichever gives simplest code in each situation
/// 
/// For complex loops
/// * yield return to separate iteration logic from results processing
/// 
/// </summary>

namespace ControlFlowAndLoops;

public static class FolderProcessor
{
     public static void DisplayParentNames_While(string filePath)
    {
        Console.WriteLine($"Passed in directory = {filePath}");
        var folder = new DirectoryInfo(Path.GetDirectoryName(filePath)!);
        while (folder != null)
        {
            Console.WriteLine(folder.Name);
            folder = folder.Parent;
        }
    }

    /// <summary>
    /// For loops with non-trivial iteration logic:
    /// * Consider letting the loop just return results
    ///   (for example with yield return)
    /// * Let the caller deal with processing the loop results
    /// </summary>
    public static IEnumerable<string> EnumParentName_While(string filePath)
    {
        var folder = new DirectoryInfo(Path.GetDirectoryName(filePath)!);
        while (folder != null)
        {
            yield return folder.Name;
            folder = folder.Parent;
        }
    }

    /// <summary>
    /// for loops and while loops are completely equivalent!
    /// It is just that with a for loop you put the loop initialisation,
    /// the termination condition and increment your way through the loop;
    /// all in one place (the braces following the for).
    /// 
    /// Alternatively the initialisation can go outside the loop as below.
    /// </summary>
    public static IEnumerable<string> EnumParentName_For(string filePath)
    {
        var folder = new DirectoryInfo(Path.GetDirectoryName(filePath)!); // Can be used inline
        for (; folder != null; folder = folder.Parent)
        {
            yield return folder.Name;
        }
    }

    /// <summary>
    /// do loops guarantee to run the loop body at least once.
    /// </summary>
    public static IEnumerable<string> EnumParentName_Do(string filePath)
    {
        var folder = new DirectoryInfo(Path.GetDirectoryName(filePath)!);
        do
        {
            yield return folder.Name;
            folder = folder.Parent;
        } while (folder != null);
    }
}
