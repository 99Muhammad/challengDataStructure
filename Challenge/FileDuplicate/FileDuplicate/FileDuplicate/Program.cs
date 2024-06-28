namespace cc_FindDuplicateInArray
{
    public class Program
    {
        static List<int> lsDuplicatedValues = new List<int>();


        public static bool isValueDuplicated(int[] arr, int value, int index)
        {
            for (int i = index; i < arr.Length; i++)
            {
                if (arr[i] == value)
                    return true;
            }
            return false;
        }

        public static int[] FindDuplicates(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (isValueDuplicated(arr, arr[i], i + 1))
                {
                    lsDuplicatedValues.Add(arr[i]);
                }
            }

            return lsDuplicatedValues.ToArray();
        }

        public static void PrintArrayElements(int[] arr)
        {

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "  ");
            }
        }

        static void Main(string[] args)
        {

            int[] arr = new int[] { 5, 10, 16, 20, 10, 16 };

            int[] arrDuplicatValues = FindDuplicates(arr);


            Console.Write("Duplicate Elements are :");


            PrintArrayElements(arrDuplicatValues);

        }
    }
}
