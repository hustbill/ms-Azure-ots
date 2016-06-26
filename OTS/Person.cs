﻿using System;
using System.Collections;

namespace OTS
{
	
	public class Person
	{
		public string Name;
		public Person[] Acquaintances;

		public Person(string name, Person[] acquaintances)
		{
			if ( String.IsNullOrWhiteSpace( name ) )
			{
				throw new ArgumentException( "Name cannot be null or white space.", "name" );
			}

			this.Name = name;
			this.Acquaintances = acquaintances;
		}

		public bool Mystery( string name )
		{
			if ( String.IsNullOrWhiteSpace( name ) )
			{
				throw new ArgumentException( "Name cannot be null or white space.", "name" );
			}

			Stack<Person> myStack = new Stack<Person>();
			foreach ( Person acquaintance in this.Acquaintances )
			{
				myStack.Push( acquaintance );
			}

			do
			{
				var person = myStack.Pop();

				if ( person.Name.Equals( name ) )
				{
					return true;
				}

				foreach ( Person acquaintance in person.Acquaintances )
				{
					myStack.Push( acquaintance );
				}

			} while ( myStack.Count >= 0 );

			return false;
		}
	}
}

