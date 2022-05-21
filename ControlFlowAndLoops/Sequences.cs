namespace ControlFlowAndLoops;

/// <summary>
/// To process a collection or sequence:
/// * Almost always prefer 'foreach'
/// * 'for' is only possible for an indexed collection
/// ** Prefer 'for' if you need to use the index
/// ** Must use 'for' to modify items
/// </summary>
public static class Sequences
{
    public static void DisplaySequence_ForEach(IEnumerable<string> strings)
    {
        foreach (string s in strings)
        {
            Console.WriteLine(s);
        }
    }

    public static void DisplayList_For(IReadOnlyList<string> strings)
    {
        for (int i = 0; i < strings.Count; i++)
        {
            Console.WriteLine(strings[i]);
        }
    }

    public static void DisplayFirstN_ForEach(IReadOnlyList<string> strings, int maxToDisplay)
    {
        foreach(string s in strings.Take(maxToDisplay)) // relies on linq
        {
            Console.WriteLine(s);
        }
    }

    public static void DisplayFirstN_For(IReadOnlyList<string> strings, int maxToDisplay)
    {
        for (int i = 0; i < strings.Count && i < maxToDisplay; i++)
        {
            Console.WriteLine(strings[i]);
        }
    }

    public static void DisplayListWithIndex_For(IReadOnlyList<string> strings)
    {
        for (int i = 0; i < strings.Count; i++)
        {
            Console.WriteLine($"{i + 1}: {strings[i]}");
        }
    }

    public static void DisplayListWithIndex_ForEach(IReadOnlyList<string> strings)
    {
        int i = 1;
        foreach(string s in strings)
        {
            Console.WriteLine($"{i++}: {s}");
        }
    }
}
