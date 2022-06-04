Write a function that will check if two given characters are the same case.

    If either of the characters is not a letter, return -1
    If both characters are the same case, return 1
    If both characters are letters, but not the same case, return 0

Examples

'a' and 'g' returns 1

'A' and 'C' returns 1

'b' and 'G' returns 0

'B' and 'g' returns 0

'0' and '?' returns -1

Possible Solutions
    Convert each character to its UTF-16 value. Lowercase characters fall within one range and uppercase within another. (lowercase 97-122, uppercase 65-90)
    If both characters fall within the uppercase or lowercase range return a 1 if they are not same case return a 0. 
    If one or either of the characters falls outside both ranges return -1. 
    https://www.fileformat.info/info/charset/UTF-16/list.htm

    Find a C# method that does the comparison and then use the result from that to produce the numbers. 


Divide the problem
    Create a method that returns the UTF-16 value of a single character. DONE
    Update this method to return a 1 if the charcter is uppercase, a 0 if the character is lowercase and a -1 if it is not a letter. DONE   
    Update this method to work with 2 chars, returning the value for each in a single int.  
    Update this method to compare the 2 numbers and produce the final result number which is then returned. 
    Consider if the entire method could be simplified to take out the number conversion step.


