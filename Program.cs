int[] array = {-10, -5, -9, 0, 2, 5, 1, 3, 1, 0, 1};

//CountingSort(array);
//CountingSortExtended(array);
CountingSortExtendedNegetive(array);
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

void CountingSortExtendedNegetive(int[] inputArray)
{
    int max = inputArray.Max();
    int min = inputArray.Min();

    int offset = -min;
    int[] counters = new int[max + offset + 1];
    for (int i = 0; i < inputArray.Length; i++)
    {
        counters[inputArray[i] + offset]++;
    }

     int index = 0;
    for (int i = 0; i < counters.Length; i++)
    {
        for (int j = 0; j < counters[i]; j++)
        {
            inputArray[index] = i - offset;
            index++;   
        }
    }
}



