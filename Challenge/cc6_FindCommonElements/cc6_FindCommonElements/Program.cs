namespace cc6_FindCommonElements
{
    public class Program
    {

        public static List<int> list = new List<int>();
        public static bool isExisit(int[] arr2,int value)
        {
            for (int i = 0; i < arr2.Length; i++)
            {
                if(arr2[i] == value)
                    return true;



            }
            return false;
        }

        public static int [] CommonElements(int []arr1, int[]arr2)
        {
           
            for (int i = 0; i < arr1.Length; i++) 
                {
                if (isExisit(arr2, arr1[i]))
                {
                    list.Add(arr1[i]);
                }
                }
           
            return list.ToArray();
        }

        public static void PrintArrayElements(int[]arr)
        {
            Console.Write($"Common elements is : ");
            for (int i = 0;i < arr.Length;i++)
            {
                Console.Write(arr[i]+" , ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {

            int[] arr1 = new[] { 79, 8, 15 };
            int[] arr2 = new[] { 23, 79, 8 };
            int[] arr3 = new int[list.Count]; 
            arr3 = CommonElements(arr1, arr2);

           if(arr3.Length!=0)
            {
                PrintArrayElements(arr3);
                
            }
            else
            {
                Console.WriteLine("No Common elemnts!");
            }

        }
    }
}
