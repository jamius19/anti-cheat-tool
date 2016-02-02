# anti-cheat-tool for Unity3D #
### A script for protection from memory hackers like GameCIH, Game Guardian, Cheat Engine and so on.... ###

********************************************************************
This is a simple Anti cheating system for protection from memory hacking tools for Unity3D Game engine...

Just download the package file from **unitypackages** foler and import it on your project!
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

* Encryption Tools.
  * ACT.Encrypt(int inputInt) : Takes an Int input, returns it as a string! Random!
  * ACT.Decrypt(int inputString): Takes an String input, returns as the original Int.


* Arithmetic Tools​
  * ACT.Add(int a, int b): Takes two ints and add them. Then returns the value as a encrypted string!
  * ACT.Add(string a, string b): Takes two strings and add them. Then returns the value as a encrypted string!
  * ACT.Subtract(int a, int b): Takes two ints and Subtract them. Then returns the value as a encrypted string!
  * ACT.Subtract(string a, string b): Takes two strings and Subtract them. Then returns the value as a encrypted string!
  * ACT.Multiply(int a, int b): Takes two ints and multiply them. Then returns the value as a encrypted string!
  * ACT.Multiply(string a, string b): Takes two strings and multiply them. Then returns the value as a encrypted string!
  * ACT.Divide(string a, string b): Takes two ints and divide them. Then returns the value as a encrypted string!
  * ACT.Divide(string a, string b): Takes two strings and divide them. Then returns the value as a encrypted string!




**The whole script is documented, so you won't become confused when using them! :)**
