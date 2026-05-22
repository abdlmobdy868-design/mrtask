namespace ConsoleApp_maintasks
{
    internal class FileNa77me

    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ');

            for (int i = 0; i < arr.Length; i++)
                for (int j = 0; j < arr.Length; j++)
                
                if (arr[i].Length > 5)
                        throw new Exception("String length exceeds 5 characters.");



        }
        }


    }
}
