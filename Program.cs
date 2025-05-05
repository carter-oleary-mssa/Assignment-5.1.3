int[] arr1 = { 1, 2, 3, 1 };
int[] arr2 = { 1, 2, 3, 4 };
int[] arr3 = { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };
Console.WriteLine(CheckForDuplicates(arr1));
Console.WriteLine(CheckForDuplicates(arr2));
Console.WriteLine(CheckForDuplicates(arr3));

bool CheckForDuplicates(int[] arr)
{
    List<int> check = new List<int>();
    foreach(int i  in arr)
    {
        if (check.Contains(i)) return true;
        check.Add(i);
    }
    return false;
}