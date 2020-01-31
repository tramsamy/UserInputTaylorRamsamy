using System;

namespace UserInputTaylorRamsamy
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hi, this is Taylor Ramsamy!");
			Console.WriteLine("Please type something. Then click the enter key.");
			Console.ReadLine();
			Console.WriteLine("Please type something else out. Then click the enter key.");
			string TypedComment;
			TypedComment = Console.ReadLine();
			Console.WriteLine("The statement you have just typed is:" + TypedComment);

		}
	}
}
