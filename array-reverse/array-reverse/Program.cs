namespace array_reverse
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] Array = new int[] {1,2,3,4};
			Array = Reverse(Array);
			for(int i=0; i<Array.Length; i++)
			{
				Console.WriteLine(Array[i]);	
			}	
			
		}

		static int[] Reverse(int[] arr)
		{
			if (arr == null)
			{
				return null;
			}

			else
			{
				int[] newArr = new int[arr.Length];
				int Index = 0;
				for(int i=arr.Length-1; i>=0; i--)
				{
					newArr[Index] = arr[i];
					Index++;	
				}
				return newArr;
			}
		}
	}
}