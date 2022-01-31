class Program

{
static void Resize(ref int [] array, int newSize)
{
int[] newArray = new int[newSize];

for (int i = 0; i < array.Length && i < newArray.Length;i++)
    newArray[i] = array[i];

    array = newArray;
    
}
static void Main(string[]args)
{
int[] myArray = {1,3,4,5,6,6};
   
     Resize(ref myArray, 3);

} 

}


