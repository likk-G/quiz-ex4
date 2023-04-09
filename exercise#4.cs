// See https://aka.ms/new-console-template for more information


int[] arr = { 5, 2, 12, 5, 9, 6, 7, 5, 11, 6, 9, 12, 1, 5, 7, 8 };

Array.Sort(arr);


int tmpCount, count = 1, tmpValue = arr[0], value = arr[0];

for(int i=0; i<arr.Length; i++)
{
    tmpCount = 1;
    while(i<arr.Length - 1 && arr[i+1] == arr[i])
    {
        tmpCount++;
        tmpValue = arr[i];
        arr[i] = arr[0];
        i++;
    }
    if (tmpCount > count)
    {
        count = tmpCount;
        value = tmpValue;
    }
}


Console.WriteLine($"value {value} has been used {count} times");

