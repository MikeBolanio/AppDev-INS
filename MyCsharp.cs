using System;
					
public class MyCsharp
{
	public static void Main(string[] args)
	{
		Console.WriteLine("What's your name?");
		String name = Console.ReadLine();
		
		Console.WriteLine("How old are you?");
		int age = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("Hello " + name);
		Console.WriteLine("You are " + age + " years old");
		
		Console.ReadKey();
	}
}
