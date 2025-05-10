namespace Problem_Solving_Techniques;

internal class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 2, 7, 8, 18, 20, 24, 29, 36, 40, 45, 51, 53, 60, 65, 69, 77, 81, 85, 91, 97 };
        int target = 65;

        Console.WriteLine("---------------------Brute Force------------------");
        BruteForce(numbers,target);

        Console.WriteLine("-----------Dvide and Conquer (binary search example => iterative approach)-------------");
        DivideAndConqurIterative(numbers,target);
        
        Console.WriteLine("-----------Dvide and Conquer (binary search example => Recursive approach)-------------");
        DivideAndConquerRecursive(numbers, target, 0, numbers.Length - 1);



    }

    static void BruteForce(int[] numbers, int target)
    {
       
        // Problem : search for target value in the array 
        // Technique : try all possible solutions => try every thing , used for small inputs 
      

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

    static void DivideAndConqurIterative(int[] numbers , int target)
    {
        // Break into small parts , solve each , then combine
        // Probelm is Binary Search : used when the data is sorted, and for random access(arrays) => log(n)

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

    static void DivideAndConquerRecursive(int[] source ,int target, int left , int right)
    {
        // Break into small parts , solve each , then combine
        // Probelm is Binary Search : used when the data is sorted, and for random access(arrays) => log(n)

        if (left > right)
        {
            Console.WriteLine($"element was not found at index");
            return;
        }

        int mid = (left + right) / 2;

            if (source[mid] == target) {
                Console.WriteLine($"element was found at index {mid}");
                return;    
                    }
            

            if (target < source[mid])
                DivideAndConquerRecursive(source, target, left, mid - 1);


            else if (target > source[mid])
                DivideAndConquerRecursive(source, target, mid + 1, right);
        }
       

    

}
