bool[] nums = new bool[1000001];
int largest = -1;

for (int i = 0; i < 1000000; i++)
{
    nums[i] = true;
}

for (int i = 2; i < nums.Length -2; i++)
{
    if (nums[i] == true)
    {
        largest = i;
        for (int j = i; j <= nums.Length - 2; j += i)
        {
            nums[j] = false;
        }
    }

}
Console.WriteLine(largest);