namespace Problem_Solving_Techniques;

internal class Program
{
    static void Main(string[] args)
    {
        BruteForce();
        DivideAndConqur();
    }


    static void BruteForce()
    {
        Console.WriteLine("---------------------Brute Force------------------");
        // Problem : search for target value in the array 
        // Technique : try all possible solutions => try every thing , used for small inputs 
        int[] numbers = { 1,3,5,7,9};
        int target = 5;

        foreach(int n in numbers)
        {
            if (n==target)
            {
                Console.WriteLine("target found \n");
                return;
            }
        }
        Console.WriteLine("target not found \n");
    }

    static void DivideAndConqur()
    {
        Console.WriteLine("-----------Dvide and Conquer (binary search example => iterative approach)-------------");
        // Break into small parts , solve each , then combine
        // Probelm is Binary Search : used when the data is sorted, and for random access(arrays) => log(n)
        int[] numbers = {2,7,8,18,20,24,29,36,40,45,51,53,60,65,69,77,81,85,91,97 };
        int target = 65;

        int left = 0, right = numbers.Length - 1;
       

        while (left <= right)
        {
            int mid = (left + right) / 2;

            if (target == numbers[mid])
            {
                Console.WriteLine($"the Target was found at index {mid}");
                return;
            }
            else if (target > numbers[mid])
            {
                left = mid + 1;
                mid = (left + right) / 2;
            }
            else { 
                right = mid - 1;
                mid = (left + right) / 2;
            }
            
        }
        Console.WriteLine("Target was not found ");
    }



}
