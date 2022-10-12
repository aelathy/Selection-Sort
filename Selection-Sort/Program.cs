// Selection Sort
#nullable disable
Console.Clear();

List<int> mynums = new List<int> { 3, 4, 2, 5, 7, 1 };
List<string> cars = new List<string> { "Ram", "Ford", "Subaru", "Honda", "Hyundai", "Acura" };

int selectionSort(List<int> aList)
{
    for (int i = 0; i < aList.Count - 1; i++)
    {
        int min_pos = i;
        for (int j = i + 1; j < aList.Count; j++)
        {
            if (aList[j] < aList[min_pos])
            {
                min_pos = j;
            }
        }
        int el = aList[min_pos];
        aList[min_pos] = aList[i];
        aList[i] = el;
    }
    return -1;
}

int sort = selectionSort(mynums);
for (int i = 0; i < mynums.Count; i++)
{
    Console.WriteLine(mynums[i]);
}