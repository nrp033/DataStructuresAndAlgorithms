namespace DataStructuresAndAlgorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("\n\nEnter the String :  ");
            String str = Console.ReadLine();
            int n = str.Length;
            PermuTation.permute(str, 0, n - 1);


            Console.ReadLine();
        }
    }
}