// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
int[] nums = new int[10];
int contN = 0, countP = 0, Count = 0;
for (int i = 0; i < nums.Length - 1; i++)
{
    Console.WriteLine("Enter number " + (i + 1));
    nums[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < nums.Length - 1; i++)
{
    if (nums[i] < 0)
    {
        contN++;
    }
    else if (nums[i] > 0)
    {
        countP++;
    }
    else
    {
        Count++;
    }
}
Console.WriteLine("Number of negatives : " + contN);
Console.WriteLine("Number of Posetives : " + countP);
Console.WriteLine("Number of Zeros : " + Count);

