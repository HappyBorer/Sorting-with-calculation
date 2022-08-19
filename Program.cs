int[] array = {0, 2, 4, 10, 20, 5, 6, 1, 2};

//CountingSort(array);
CountingSortExtended(array);
Console.WriteLine(string.Join(", ", array));

void CountingSort(int[] inputArray)
{
    int[] counters = new int[10];
    for (int i = 0; i < inputArray.Length; i++)
    {
        // counters[inputArray[i]]++;
        int ourNumber = inputArray[i];
        counters[ourNumber]++;
    }

    int index = 0;
    for (int i = 0; i < counters.Length; i++)
    {
        for (int j = 0; j < counters[i]; j++)
        {
            inputArray[index] = i;
            index++;   
        }
    }
} 

void CountingSortExtended(int[] inputArray)
{
    int max = inputArray.Max();

    int[] counters = new int[max + 1];
    for (int i = 0; i < inputArray.Length; i++)
    {
        counters[inputArray[i]]++;
    }

     int index = 0;
    for (int i = 0; i < counters.Length; i++)
    {
        for (int j = 0; j < counters[i]; j++)
        {
            inputArray[index] = i;
            index++;   
        }
    }
}




