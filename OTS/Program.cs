﻿using System;
using System.Collections;

namespace OTS
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			 Console.WriteLine ("Hello World!");
			string name = "Hua"; 
			Person[] acquaintance =  {new Person("bob", new Person[0])};

			Person person = new Person( name, acquaintance);
			Console.WriteLine( person.Mystery( name ));

		}

		public static void StackEample() {

			Stack st = new Stack();

			st.Push('A');
			st.Push('M');
			st.Push('G');
			st.Push('W');

			Console.WriteLine("Current stack: ");
			foreach (char c in st)
			{
				Console.Write(c + " ");
			}

			Console.WriteLine();

			st.Push('V');
			st.Push('H');
			Console.WriteLine("The next poppable value in stack: {0}", st.Peek());
			Console.WriteLine("Current stack: ");
			foreach (char c in st)
			{
				Console.Write(c + " ");
			}

			Console.WriteLine();

			Console.WriteLine("Removing values ");
			st.Pop();
			st.Pop();
			st.Pop();

			Console.WriteLine("Current stack: ");
			foreach (char c in st)
			{
				Console.Write(c + " ");
			}
	}
}