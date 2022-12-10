// C# program to illustrate set operations
using System;
using System.Collections.Generic;

class GFG {

	static public void Main()
	{

		// Creating HashSet
		// Using HashSet class
		HashSet<string> myhash1 = new HashSet<string>();

		// Add the elements in HashSet
		// Using Add method
		myhash1.Add("C");
		myhash1.Add("C++");
		myhash1.Add("C#");
		myhash1.Add("Java");
		myhash1.Add("Ruby");

		// Creating another HashSet
		// Using HashSet class
		HashSet<string> myhash2 = new HashSet<string>();

		// Add the elements in HashSet
		// Using Add method
		myhash2.Add("PHP");
		myhash2.Add("C++");
		myhash2.Add("Perl");
		myhash2.Add("Java");

		// Using UnionWith method
		myhash1.UnionWith(myhash2);
		foreach(var ele in myhash1)
		{
			Console.WriteLine(ele);
		}
	}
}
