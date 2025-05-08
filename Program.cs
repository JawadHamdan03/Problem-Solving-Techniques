namespace Problem_Solving_Techniques;

internal class Program
{
    static void Main(string[] args)
    {
        BruteForce();
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





}
