namespace b3task
{
    internal class Program
    {
        static void Main(string[] args)
        {



            string dna = Console.ReadLine();
            string mostFrequentSequence = "";
            int highestCount = 0;

            for (int start = 0; start <= dna.Length - 3; start++)
            {
                for (int length = 3; start + length <= dna.Length; length++)
                {
                    string currentSequence = dna.Substring(start, length);
                    int count = CountOccurrences(dna, currentSequence, length);

                    if (count > highestCount || (count == highestCount && currentSequence.Length > mostFrequentSequence.Length))
                    {
                        mostFrequentSequence = currentSequence;
                        highestCount = count;
                    }
                }
            }

            Console.WriteLine(highestCount > 1 ? $"{mostFrequentSequence} {highestCount}" : "-1");
        }

        static int CountOccurrences(string dna, string sequence, int length)
        {
            int count = 0;

            for (int i = 0; i <= dna.Length - length; i++)
            {
                if (dna.Substring(i, length) == sequence)
                {
                    count++;
                    i += length - 1; // Skip overlapping sequences
                }
            }

            return count;
        }
    }
}
