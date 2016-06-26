using System;
using System.Collections;

namespace OTS
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string name = "Hua"; 
			Person[] acquaintance =  {new Person("bob", new Person[] {new Person("Alice", new Person[0])})};

			Person person = new Person( name, acquaintance);

			string target = "bob";
			Console.WriteLine( person.Mystery( target )); // true 
		}
	}
}
