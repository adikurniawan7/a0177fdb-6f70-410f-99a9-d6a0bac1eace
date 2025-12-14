# Find Longest Increasing Subsequence
a function that takes one string input of any number of integers separated by single whitespace. 
The function then outputs the longest increasing subsequence (increased by any number) present in that sequence. 
If more than 1 sequence exists with the longest length, output the earliest one
e.g.,  
Input
``` 
6 1 5 9 2
6 2 4 3 1 5 9
6 2 4 6 1 5 9 2
```
Output
```
1 5 9
1 5 9
2 4 6
```
## Target Framework
.NET 9.0
## Running Tests
Open PowerShell then run:
```bash
dotnet test
```
Alternatively, open solution in Visual Studio, then run all test (ctrl + R, A)

## Implementation Details
Main file consist of 3 functions:
`int[] FindLongestIncreasingSubsequence(string input)` 
* Takes a string as input
* Convert string input to array of integer by calling `ConvertStringToArrayOfInteger` function
* Find longesst increasing subsequence by calling overloaded method `FindLongestIncreasingSubsequence(int[] numbers)`
* return result from `FindLongestIncreasingSubsequence(int[] numbers)`
* edge cases handled:
  * input empty array will return empty array
  * input single element will return that element itself
  * will return first occurence if there are more than 1 sequence with equal most length

`int[] ConvertStringToArrayOfInteger(string input)`
* Takes a string as input
* Split string based on space, and remove empty entries
* For each substring `TryParse` to integer
* Return array of integer

`int[] FindLongestIncreasingSubsequence(int[] numbers)`
* Takes array of integer as input
* Go through each element and compare last number with current number
* If last number is smaller than current number, add to the current pool
* else clear current pool

## Contributing

Pull requests are welcome. For major changes, please open an issue first
to discuss what you would like to change.

Please make sure to update tests as appropriate.

## License

[MIT](https://choosealicense.com/licenses/mit/)
