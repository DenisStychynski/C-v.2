int number = new Random().Next(0, 2);
int[] array = new int[8];
FillArray(array);
PrintArray(array);
void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 2);


    }

}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }


}
