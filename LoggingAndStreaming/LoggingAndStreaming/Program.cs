#define Test
using System;
using System.IO;
using System.Diagnostics;
namespace LoggingAndStreaming
{
	class Program
	{
		static void Main(string[] args)
		{

			//Console.WriteLine("Hello World!");
			//var name = Console.ReadLine();
			//Console.WriteLine($"Hello, {name}, it is now {DateTime.Now}");
			//File.WriteAllText("hello.txt", text, UnicodeEncoding);
			/*
			string text = "Hello out there";
			File.WriteAllText("Hello.txt", text);
			string readText =
				File.ReadAllText("Hello.txt");
			Console.WriteLine(readText);
			File.AppendAllText("Hello.txt", text);

			string[] lines = { "Mary had a little lamb","Its fleece was white as snow",
			"Everywhere that Mary went", "The lamb was sure to go"};

			File.WriteAllLines("Mary.txt", lines);
			string[] readLines = File.ReadAllLines("Mary.txt");
			foreach (var line in readLines)
			{
				Console.WriteLine(line);
			}

			Debug.WriteLine("Debug - This is a Debug item");
			Trace.WriteLine("Trace - This is a trace item");
			
			Console.WriteLine($"This is being logged at time {DateTime.Now}");
			TextWriterTraceListener twt1 = new
				TextWriterTraceListener(File.Create("TraceOutput.txt"));
			Trace.Listeners.Add(twt1);
			for (int i = 0; i < 3; i++)
			{
				Console.WriteLine(i);
				Debug.WriteLine($"Debug - the value of i is {i}");
				Trace.WriteLine($"Trace - the value of i is {i}");
				Debug.WriteLineIf(i == 2, $"\nReached Maximum value of i: {i} at {DateTime.Now}");
				Trace.Assert(i > 0, $"i is not greater than zero: {i}");

			}
			Trace.Flush();
			*/
			string path = @"LiveForever.txt";
			using (StreamWriter sr = File.AppendText(path))
			{
				sr.WriteLine("Live - Forever");

			}
			using (StreamReader sr = File.OpenText(path))
			{
				String s = "";
				while ((s = sr.ReadLine()) != null)
				{
					Console.WriteLine(s);
				}
			}

		}
	}
}
