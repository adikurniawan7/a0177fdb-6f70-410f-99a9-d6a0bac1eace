using LongestIncreasingSubsequence.Test.TestData;

namespace LongestIncreasingSubsequence.Test;

public class MainTests
{
    [Theory]
    [MemberData(nameof(StringCases))]
    public void FindLongestIncreasingSubsequence_StringInput_ReturnsExpected(string input, int[] expected)
    {
        var result = Main.FindLongestIncreasingSubsequence(input);
        Assert.Equal(expected, result);
    }

    [Theory]
    [MemberData(nameof(ConvertStringCases))]
    public void ConvertStringToArrayOfInteger_ReturnsExpected(string input, int[] expected)
    {
        var result = Main.ConvertStringToArrayOfInteger(input);
        Assert.Equal(expected, result);
    }

    [Theory]
    [MemberData(nameof(Cases))]
    public void FindLongestIncreasingSubsequence_ReturnsExpected(int[] input, int[] expected)
    {
        var result = Main.FindLongestIncreasingSubsequence(input);
        Assert.Equal(expected, result);
    }

    public static IEnumerable<object[]> StringCases
    {
        get
        {
            // edge cases
            yield return new object[] { "", Array.Empty<int>() };
            yield return new object[] { "     ", Array.Empty<int>() };
            yield return new object[] { "ABC DEF", Array.Empty<int>() };
            yield return new object[] { "99999999999999999999", Array.Empty<int>() };
            yield return new object[] { "99999999999999999999 123", new int[] { 123 } };
            yield return new object[] { "1", new int[] { 1 } };
            yield return new object[] { "1 2 3 4 5", new int[] { 1, 2, 3, 4, 5 } };
            yield return new object[] { "   1     2     3     4     5    ", new int[] { 1, 2, 3, 4, 5 } };
            yield return new object[] { "a 2 c 4 e", new int[] { 2, 4 } };
            yield return new object[] { "5 4 3 2 1", new int[] { 5 } };

            // testdata
            yield return new object[] { LisTestData.StringTestData1, LisTestData.OutputTestData1 };
            yield return new object[] { LisTestData.StringTestData2, LisTestData.OutputTestData2 };
            yield return new object[] { LisTestData.StringTestData3, LisTestData.OutputTestData3 };
            yield return new object[] { LisTestData.StringTestData4, LisTestData.OutputTestData4 };
            yield return new object[] { LisTestData.StringTestData5, LisTestData.OutputTestData5 };
            yield return new object[] { LisTestData.StringTestData6, LisTestData.OutputTestData6 };
            yield return new object[] { LisTestData.StringTestData7, LisTestData.OutputTestData7 };
            yield return new object[] { LisTestData.StringTestData8, LisTestData.OutputTestData8 };
            yield return new object[] { LisTestData.StringTestData9, LisTestData.OutputTestData9 };
            yield return new object[] { LisTestData.StringTestData10, LisTestData.OutputTestData10 };
            yield return new object[] { LisTestData.StringTestData11, LisTestData.OutputTestData11 };
        }
    }

    public static IEnumerable<object[]> ConvertStringCases
    {
        get
        {
            // edge cases
            yield return new object[] { "", Array.Empty<int>() };
            yield return new object[] { "     ", Array.Empty<int>() };
            yield return new object[] { "ABC DEF", Array.Empty<int>() };
            yield return new object[] { "99999999999999999999", Array.Empty<int>() };
            yield return new object[] { "99999999999999999999 123", new int[] { 123 } };
            yield return new object[] { "1", new int[] { 1 } };
            yield return new object[] { "1 2 3 4 5", new int[] { 1, 2, 3, 4, 5 } };
            yield return new object[] { "   1     2     3     4     5    ", new int[] { 1, 2, 3, 4, 5 } };
            yield return new object[] { "a 2 c 4 e", new int[] { 2, 4 } };
            yield return new object[] { "5 4 3 2 1", new int[] { 5, 4, 3, 2, 1 } };

            // testdata
            yield return new object[] { LisTestData.StringTestData1, LisTestData.TestData1 };
            yield return new object[] { LisTestData.StringTestData2, LisTestData.TestData2 };
            yield return new object[] { LisTestData.StringTestData3, LisTestData.TestData3 };
            yield return new object[] { LisTestData.StringTestData4, LisTestData.TestData4 };
            yield return new object[] { LisTestData.StringTestData5, LisTestData.TestData5 };
            yield return new object[] { LisTestData.StringTestData6, LisTestData.TestData6 };
            yield return new object[] { LisTestData.StringTestData7, LisTestData.TestData7 };
            yield return new object[] { LisTestData.StringTestData8, LisTestData.TestData8 };
            yield return new object[] { LisTestData.StringTestData9, LisTestData.TestData9 };
            yield return new object[] { LisTestData.StringTestData10, LisTestData.TestData10 };
            yield return new object[] { LisTestData.StringTestData11, LisTestData.TestData11 };
        }
    }

    public static IEnumerable<object[]> Cases
    {
        get
        {
            // edge cases
            yield return new object[] { LisTestData.Empty, Array.Empty<int>() };
            yield return new object[] { LisTestData.One, new int[] { 1 } };
            yield return new object[] { LisTestData.Ascending, new int[] { 1, 2, 3, 4, 5, 6, 7 } };
            yield return new object[] { LisTestData.Descending, new int[] { 7 } };
            yield return new object[] { LisTestData.TwoAscending, new int[] { 1, 2 } };
            yield return new object[] { LisTestData.TwoDescending, new int[] { 2 } };
            yield return new object[] { LisTestData.AllSame, new int[] { 7 } };

            // test data
            yield return new object[] { LisTestData.TestData1, LisTestData.OutputTestData1 };
            yield return new object[] { LisTestData.TestData2, LisTestData.OutputTestData2 };
            yield return new object[] { LisTestData.TestData3, LisTestData.OutputTestData3 };
            yield return new object[] { LisTestData.TestData4, LisTestData.OutputTestData4 };
            yield return new object[] { LisTestData.TestData5, LisTestData.OutputTestData5 };
            yield return new object[] { LisTestData.TestData6, LisTestData.OutputTestData6 };
            yield return new object[] { LisTestData.TestData7, LisTestData.OutputTestData7 };
            yield return new object[] { LisTestData.TestData8, LisTestData.OutputTestData8 };
            yield return new object[] { LisTestData.TestData9, LisTestData.OutputTestData9 };
            yield return new object[] { LisTestData.TestData10, LisTestData.OutputTestData10 };
            yield return new object[] { LisTestData.TestData11, LisTestData.OutputTestData11 };
        }
    }
}
