namespace LongestIncreasingSubsequence;

public class Main
{
    public static int[] FindLongestIncreasingSubsequence(string input)
    {
        var numbers = ConvertStringToArrayOfInteger(input);

        return FindLongestIncreasingSubsequence(numbers);
    }

    public static int[] ConvertStringToArrayOfInteger(string input)
    {
        var substrings = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        List<int> numbers = [];
		foreach (var substring in substrings)
        {
            if (int.TryParse(substring, out var number))
            {
                numbers.Add(number);
            }
        }
        return numbers.Count > 0 ? [.. numbers] : [];
    }

    public static int[] FindLongestIncreasingSubsequence(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0) return [];
        if (numbers.Length == 1) return [numbers[0]];

        var result = new List<int> { numbers[0] };
        var current = new List<int> { numbers[0] };

        for (var i = 0; i < numbers.Length; i++)
        {
            if (current.Last() < numbers[i])
            {
                current.Add(numbers[i]);
                // compare
                if (current.Count > result.Count)
                {
                    result = [.. current];
                }
            }
            else if (i < numbers.Length - 1)
            {
                // reset
                current.Clear();
                current.Add(numbers[i]);
            }
        }

        return [.. result];    
    }
}
