namespace UnequalConsecutiveCharacters
{
    public class SequenceAnalyzer
    {
        public static int CountUnequalConsecutiveCharacters(string sequence)
        {
            if (string.IsNullOrEmpty(sequence))
            {
                return 0;
            }
            sequence = sequence.ToLower();
            int count = 1;
            int maxCount = 1;
            for (int i = 1; i < sequence.Length; i++)
            {
                if (sequence[i] != sequence[i - 1])
                {
                    count++;
                    maxCount = int.Max(count, maxCount);
                }
                else
                {
                    count = 1;
                }
            }
            return maxCount;
        }

        public static int CountConsecutiveLetters(string sequence)
        {
            if (string.IsNullOrEmpty(sequence))
            {
                return 0;
            }
            sequence = sequence.ToLowerInvariant();
            int count = 1;
            int maxCount = 1;
            for (int i = 1; i < sequence.Length; i++)
            {
                if (char.IsLetter(sequence[i]) && char.IsLetter(sequence[i - 1]) && sequence[i] == sequence[i - 1])
                {
                    count++;
                    maxCount = int.Max(count, maxCount);
                }
                else
                {
                    count = 1;
                }
            }
            return maxCount;
        }
        public static int CountConsecutiveNumbers(string sequence)
        {
            if (string.IsNullOrEmpty(sequence))
            {
                return 0;
            }
            int count = 1;
            int maxCount = 1;
            for (int i = 1; i < sequence.Length; i++)
            {
                if (char.IsDigit(sequence[i]) && char.IsDigit(sequence[i - 1]) && sequence[i] == sequence[i - 1])
                {
                    count++;
                }
                else
                {
                    count = 1;
                }
                maxCount = int.Max(count, maxCount);
            }
            return maxCount;
        }
    }
    public static class Program
    {
        public static void Main(string[] args)
        {
        }
    }
}