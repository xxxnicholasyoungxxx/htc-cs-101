# Extra Challenges

## ASCII Art
[ASCII art](https://en.wikipedia.org/wiki/ASCII_art) is a graphic design technique that uses computers for presentation and consists of pictures pieced together from the 95 printable (from a total of 128) characters defined by the ASCII Standard.

Follow this guide to create some ASCII Art of your own: https://www.ludd.ltu.se/~vk/pics/ascii/junkyard/techstuff/tutorials/Joan_Stark.html

Then, make a C# program that will output your ASCII art to the Console!

## Random Numbers
Find out how to create a Random integer.

Some good places to find information like this:
- http://stackoverflow.com
- http://msdn.microsoft.com

Look for C# / .NET framework answers. Then, complete the exercises below:

1. Output a random number between 0 and 25 to the Console
    - Note: The probability of a number outputting is a [Uniform distribution](https://en.wikipedia.org/wiki/Uniform_distribution_(continuous))
1. Output two random numbers, each between 1 and 6 to the Console (die roll)
1. Output the sum of both die roll random numbers
    - Note: The probability of a given sum outputting is no longer uniform
1. Which sum is most likely to appear? Which is least likely?

### Random Password
Use your random numbers to create a random password consisting of alphabetic characters. Do not use control flow statements or loops to accomplish this. Learn about the following concepts before starting to write your program:

- `char` type in C#
    - https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/char
- Numeric representations of characters
    - ASCII Character Codes: https://msdn.microsoft.com/en-us/library/60ecse8t(v=vs.71).aspx
- Converting numeric values to `char` values
    - https://docs.microsoft.com/en-us/dotnet/api/system.convert.tochar?view=netframework-4.7.2
- `ToString` method for `char` values
    - https://docs.microsoft.com/en-us/dotnet/api/system.char.tostring?view=netframework-4.7.2

Your program should create a password that meets the following criteria:
- At least six characters in length
- At least one lowercase letter
- At least one uppercase letter
- At least one number