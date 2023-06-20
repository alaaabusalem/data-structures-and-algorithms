namespace Binary_Search
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int answer=BinarySearch(new int[] { 5, 10, 25, 30, 55, 78, 99 }, 6);
			Console.WriteLine(answer);
		}
	

    public static int BinarySearch(int[] array, int input) 
	{
        int left = 0;
			int right = array.Length - 1;
			bool test=false;
			while (!test)
			{
				int middel = (left + right) / 2;
				if(array[middel] == input) {
					return middel;
				}
				else if(array[middel] > input) {
				right = middel-1;	
				}
				else if(array[middel] <input){
				left = middel+1;
				}
				else { test=true; break; }	
			}
			return 0;
    }
}
}