namespace challengDataStructure
{
    public class Program
    {
        
        public static int[] RemoveMiddleValue(int[] arr)
        {
            int[] NewArr;
            int index = arr.Length / 2;
            int CountEven = index - 1;
            int IndexNew = 0;

            if(arr.Length==0)
            {
                return arr;
            }

            if (arr.Length % 2 != 0)
            {
                NewArr = new int[arr.Length - 1];
                for (int i = 0; i < arr.Length; i++)
                {
                    if (i == index)
                    {

                        continue;
                    }
                    else
                    {
                        NewArr[IndexNew] = arr[i];
                        IndexNew++;
                    }

                }
            }
            else
            {
                
                NewArr = new int[arr.Length - 2];
                for (int i = 0; i < arr.Length; i++)
                {

                    if (i == CountEven)
                    {

                        continue;
                    }
                    else if (i == CountEven + 1)
                    {
                        continue;
                    }
                    else
                    {
                        NewArr[IndexNew] = arr[i];
                        IndexNew++;
                    }

                }
            }

            return NewArr;

        }

        public static void PrintArrayElement(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} , ");
            }
            Console.WriteLine();
        }

        private static int[] MiddleValue(int[] arr, int value)
        {
            int[] arr2 = new int[arr.Length + 1];
            int middle = (arr.Length / 2) + 1;
            if (arr.Length % 2 == 0)
            {
                middle = (arr.Length / 2);
            }
            Console.WriteLine(middle);
            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == middle)
                {
                    arr2[index++] = value;
                    arr2[index++] = arr[i];
                    continue;
                }
                arr2[index++] = arr[i];
            }
            return arr2;
        }


        static void Main(string[] args)
        {

            int[] arr = new int[] { 7, 9, 13, 25, 5, 17 };
            int[] NewArr;

            Console.WriteLine("Array element before modified :");
            PrintArrayElement(arr);

            NewArr = RemoveMiddleValue(arr);

            Console.WriteLine("Array element after modified :");
            PrintArrayElement(NewArr);

        }

    }
}
