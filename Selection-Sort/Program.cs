// Selection Sort Check
#nullable disable
Console.Clear();

List<int> mynums = new List<int> { 3, 4, 2, 5, 7, 1 };
List<string> cars = new List<string> { "Ram", "Ford", "Subaru", "Honda", "Hyundai", "Acura" };

int selectionSort<T>(IList<T> aList) where T : IComparable
{
    for (int i = 0; i < aList.Count - 1; i++)
    {
        int min_pos = i;
        for (int j = i + 1; j < aList.Count; j++)
        {
            int compare = aList[min_pos].CompareTo(aList[j]);
            if (compare == 1)
            {
                min_pos = j;
            }
        }
        T el = aList[min_pos];
        aList[min_pos] = aList[i];
        aList[i] = el;
    }
    return -1;
}


int mynumSort = selectionSort(mynums);
int carsSort = selectionSort(cars);

for (int i = 0; i < mynums.Count; i++)
{
    Console.WriteLine(mynums[i]);
}

Console.WriteLine();

foreach (string car in cars)
{
    Console.WriteLine(car);
}
