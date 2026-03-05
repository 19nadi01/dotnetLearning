using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning;

public class Loops
{
	public static List<string> names = new List<string> { "Leo", "Maria", "Ted", "Morris" };


	// WHILE-LOOP
	public static void WhileLoop()
	{
		var index = 0;
		while (index < names.Count)
		{
			Console.WriteLine(names[index].ToString());
			index++;
		}
	}

	//DO-WHILE-LOOP
	public static void DoWhileLoop()
	{
		var index = 0;
		do
		{
			Console.WriteLine(names[index].ToString());
			index++;
		} while (index < names.Count);
	}

	//FOR_LOOP
	public static void ForLoop()
	{
		for (var i = 0; i < names.Count; i++)
		{
			Console.WriteLine(names[i]);
		}
	}

	//FOR-EACH-LOOP
	public static void ForEachLoop()
	{
		foreach (var name in names)
		{
			Console.WriteLine(name);
		}
	}

	//FOR-EACH-LOOP with jumping statments
	public static void ForEachLoopWithJumpingStatmets()
	{
		foreach (var name in names)
		{
			if (name == "Leo")
			{
                Console.WriteLine("Checking continue key word: jumping to the next iteration");
				//will skip the rest of the code in this iteration and go to the nest iteration
				continue;
			}
			if (name == "Ted")
			{
				//will exit the loop
				break;
			}
			Console.WriteLine(name);
		}
	}


}
