using System;

class ReverseNumber{
	public static void Main(String [] args){
		string myNumber;
		Console.WriteLine("ENTER YOUR NUMBER");
		myNumber=Console.ReadLine();
		char[] array=myNumber.ToCharArray();
		Array.Reverse(array);
		string reverseString=new String(array);
		int reversedNumber = Convert.ToInt32(reverseString);		
		Console.WriteLine("The number in reverse is " + reversedNumber);
	}
}