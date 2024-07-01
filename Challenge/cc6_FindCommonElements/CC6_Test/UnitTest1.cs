using cc6_FindCommonElements;
using System.Collections.Generic;

namespace CC6_Test
{
    public class UnitTest1
    {
        [Fact]
        public void CommonElements_Test()
        {

            Program.list.Clear();
            int[] arr1 = new[] { 1, 2, 3, 0 };
            int[] arr2 = new[] { 2, 3, 4, 9 };

           
            int[] arr5 = Program.CommonElements(arr1, arr2);

           Assert.Equal(2,arr5.Length);
          
        }

        [Fact]
        public void CommonElemen_Test()
        {

            Program.list.Clear();
            int[] arr3 = new[] { 79, 8, 15 };
            int[] arr4 = new[] { 23, 79, 8 };

            int[] arr6 = Program.CommonElements(arr3, arr4);

            Assert.Equal(2, arr6.Length);
        }
    }
}