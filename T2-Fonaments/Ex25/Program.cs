namespace Ex25
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = { 3, 4, 1 };

            SortArrayAscending(numbers);

            Console.WriteLine(string.Join(", ", numbers));
        }

        /// <summary>
        /// Ordena un array d'enters de manera ascendent.
        /// </summary>
        static void SortArrayAscending(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        Swap(ref array[i], ref array[j]);
                    }
                }
            }
        }

        /// <summary>
        /// Intercanvia el valor de dos enters.
        /// </summary>
        static void Swap(ref int first, ref int second)
        {
            int temp = first;
            first = second;
            second = temp;
        }
    }
}
