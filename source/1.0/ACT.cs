/* ********************** Anti Cheat tool (for memory hackers only) ********************** */
/* *********************************** Jamius Siam *************************************** */

/// <summary>
/// Anti Cheat Tool's API.	
/// </summary>
public sealed class ACT
{
	
	public static char[] key = new char[10]{'q','w','e','r','t','y','u','i','o','p'};            //Key for encryption (can change it as you wish, but make sure not to repeat an alphabet)
	static char[] orgKey = new char[]{'0','1','2','3','4','5','6','7','8','9'};					// Key for decryption



	/// <summary>
	/// Method for Encrypting given Int to random string. 	
	/// </summary>
	public static string Encrypt (int inputInt)												// Method for Encrypting given Int to random string
	{
		string mainWord = inputInt.ToString ();
		char [] testWord = new char[mainWord.Length];
		testWord = mainWord.ToCharArray ();
		char[] output = new char[testWord.Length];
		
		for (int x = 0; x < testWord.Length; x++) {
			int map = (testWord [x]) - '0';
			output [x] = key [map];
		}
		
		string abs = new string (output);
		return(abs);
	}



	/// <summary>
	/// Method for Decrypting given random String to Int.  	
	/// </summary>
	public static int Decrypt (string inputString)													// Method for Decrypting given random string to int
	{
		char [] testWord = new char[inputString.Length];
		testWord = inputString.ToCharArray ();
		char[] output = new char[testWord.Length];
		
		for (int x = 0; x < testWord.Length; x++) {
			int map = 0;
			for (int y = 0; y < key.Length; y++) {
				if (key [y] == testWord [x])
					map = y;
			}
			output [x] = orgKey [map];
		}
		
		string abs = new string (output);
		int returnValue = int.Parse (abs);
		return(returnValue);
	}


	/// <summary>
	/// Method for adding two encryted strings together (string input).
	/// </summary>
	public static string Add (string a, string b)											// Method for adding two encryted strings together (string input)
	{
		int A = Decrypt (a);
		int B = Decrypt (b);


		string sum = Encrypt (A + B);
		return sum;
	}


	/// <summary>
	/// Method for adding two encryted strings together (int input).
	/// </summary>
	public static string Add (int a, int b)													// Method for adding two encryted strings together (int input)
	{
		string sum = Encrypt (a + b);
		return sum;
	}


	/// <summary>
	/// Method for subtracting two encryted strings together (string input).
	/// </summary>
	public static string Subtract (string a, string b)										// Method for subtracting two encryted strings together (string input)
	{
		int A = Decrypt (a);
		int B = Decrypt (b);
		
		string sum = Encrypt (A - B);
		return sum;
	}


	/// <summary>
	/// Method for subtracting two encryted strings together (int input).
	/// </summary>
	public static string Subtract (int a, int b)											// Method for subtracting two encryted strings together (int input)
	{
		string sum = Encrypt (a - b);
		return sum;
	}

	/// <summary>
	/// Method for multiplying two encryted strings together (string input).
	/// </summary>
	public static string Multiply (string a, string b)										// Method for multiplying two encryted strings together (string input)
	{
		int A = Decrypt (a);
		int B = Decrypt (b);
		
		string sum = Encrypt (A * B);
		return sum;
	}
	
	
	/// <summary>
	/// Method for multiplying two encryted strings together (int input).
	/// </summary>
	public static string Multiply (int a, int b)											// Method for multiplying two encryted strings together (int input)
	{
		string sum = Encrypt (a * b);
		return sum;
	}


	/// <summary>
	/// Method for dividing two encryted strings together (string input).
	/// </summary>
	public static string Divide (string a, string b)										// Method for multiplying two encryted strings together (string input)
	{
		int A = Decrypt (a);
		int B = Decrypt (b);
		
		string sum = Encrypt (A / B);
		return sum;
	}
	
	
	/// <summary>
	/// Method for dividing two encryted strings together (int input).
	/// </summary>
	public static string Divide (int a, int b)											// Method for multiplying two encryted strings together (int input)
	{
		string sum = Encrypt (a / b);
		return sum;
	}
}
