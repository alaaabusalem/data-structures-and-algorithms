
namespace array_insert_shift
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] Array = { 1,2,3,4 };
			int Element= 5;
			Console.WriteLine("modifiedArray1");
			int[] modifiedArray = InsertShiftArray(Array, Element);
			for(int i = 0; i < modifiedArray.Length; i++) {

				Console.WriteLine(modifiedArray[i]);	
			}

			int[] Array2 = { 1, 2, 3, 4,5 };
			int Element2 = 6;
			int[] modifiedArray2 = InsertShiftArray(Array2, Element2);

			Console.WriteLine("modifiedArray2");

			for (int i = 0; i < modifiedArray2.Length; i++)
			{

				Console.WriteLine(modifiedArray2[i]);
			}
		}


		public static int[] InsertShiftArray(int[] array, int element)
		{
			int length = array.Length;
			int[] newArray = new int[length + 1];
			int midIndex = 0;
			if (length % 2 !=0)
			{
				midIndex = (length /2)+1 ;
			}
			else { midIndex = (length /2); }	

			for (int i = 0; i < newArray.Length; i++)
			{
				if (i < midIndex)
				{
					newArray[i] = array[i];
				}
				else if (i == midIndex)
				{
					newArray[i] = element;
				}
				else
				{
					newArray[i] = array[i-1];
				}
			}

			return newArray;
		}
	}
}