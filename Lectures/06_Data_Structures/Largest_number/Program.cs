int[] arr = new int[] { 1, 2, 3, 4, 5, 4, 3, 2, 1 };

int max = int.MinValue;
int index= -1;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > max)
    {
        max = arr[i];
        index = i;
    }

}
Console.WriteLine(index);
