# anti-cheat-tool
A script for protection from memory hackers like GameCIH, Game Guardian, Cheat Engine and so on....


*****************************************************************
This is a simple Anti cheating system for protection from memory hacking tools! 
Its free!!! 

Just download the attached unitypackage file and import it on your project!
Now you can access the api's via the ACT class....

The idea behind it is simple enough!....
You give it an integer, it converts it into a random string!
Yap...
Not easy to hack strings with memory hackers like Cheat Engine, SB Game Tools, Game CIH....
(checked with Game CIH and SB Game Tools)
You can choose the key for encryption!
Moreover there's some basic Arithmetic tools for you to securely process Arithmetic calculation!
You can combine them for more complicated use of course! :)


Methods in this tool..... (by string, I refer to encrypted string)

Encryption Tools​
1. ACT.Encrypt(int inputInt) : Takes an Int input, returns it as a string! Random!​
2. ACT.Decrypt(int inputString): Takes an String input, returns as the original Int.


Arithmetic Tools​
3. ACT.Add(int a, int b): Takes two ints and add them. Then returns the value as a encrypted string!
4. ACT.Add(string a, string b): Takes two strings and add them. Then returns the value as a encrypted string!
5.ACT.Subtract(int a, int b): Takes two ints and Subtract them. Then returns the value as a encrypted string!
6.ACT.Subtract(int a, int b): Takes two strings and Subtract them. Then returns the value as a encrypted string!
5.ACT.Multiply(int a, int b): Takes two ints and multiply them. Then returns the value as a encrypted string!
6.ACT.Multiply(int a, int b): Takes two strings and multiply them. Then returns the value as a encrypted string!
5.ACT.Divide(int a, int b): Takes two ints and divide them. Then returns the value as a encrypted string!
6.ACT.Divide(int a, int b): Takes two strings and divide them. Then returns the value as a encrypted string!


The whole script is documented, so you won't become confused when using them! :)
