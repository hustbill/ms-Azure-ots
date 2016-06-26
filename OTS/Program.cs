using System;
using System.Collections;

namespace OTS
{
	class MainClass
	{
		public static void Main (string[] args)
		{// 把 while ( myStack.Count >＝ 0 );   改为 while ( myStack.Count > 0 );
			Person alice = new Person("Alice", new Person[0]);
			Person mark = new Person("Mark", new Person[0]);
			Person hua = new Person("Hua", new Person[] {mark});
			Person bob = new Person("Bob", new Person[] {alice, mark, hua}) ;

			string name = "Tony";
			Person[] acquaintance = new Person[] { alice, mark, hua, bob };
			Person person = new Person( name, acquaintance);

			string[] targets = { "Alice", "Mark", "Hua", "Bob" , "Tom"};
			for (int i = 0; i < targets.Length; i++) {
				Console.WriteLine( person.Mystery( targets[i] )); // True, True, True, True, False
			}
		}
	}
}
