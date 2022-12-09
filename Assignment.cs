// C# program to demonstrate the working
// of Assignment Operators
using System;
namespace Assignment {
	
class GFG {
	
	// Main Function
	static void Main(string[] args)
	{
		
			// initialize variable x
			// using Simple Assignment
			// Operator "="
			int x = 15;
			
			// it means x = x + 10
			x += 10;
			Console.WriteLine("Add Assignment Operator: " + x);
			
			// initialize variable x again
			x = 20;
			
			// it means x = x - 5
			x -= 5;
			Console.WriteLine("Subtract Assignment Operator: " + x);
			
			// initialize variable x again
			x = 15;
			
			// it means x = x * 5
			x *= 5;
			Console.WriteLine("Multiply Assignment Operator: " + x);
			
			// initialize variable x again
			x = 25;
			
			// it means x = x / 5
			x /= 5;
			Console.WriteLine("Division Assignment Operator: " + x);
			
			// initialize variable x again
			x = 25;
			
			// it means x = x % 5
			x %= 5;
			Console.WriteLine("Modulo Assignment Operator: " + x);
			
			// initialize variable x again
			x = 8;
			
			// it means x = x << 2
			x <<= 2;
			Console.WriteLine("Left Shift Assignment Operator: " + x);
			
			// initialize variable x again
			x = 8;
			
			// it means x = x >> 2
			x >>= 2;
			Console.WriteLine("Right Shift Assignment Operator: " + x);
			
			// initialize variable x again
			x = 12;
			
			// it means x = x >> 4
			x &= 4;
			Console.WriteLine("Bitwise AND Assignment Operator: " + x);
			
			// initialize variable x again
			x = 12;
			
			// it means x = x >> 4
			x ^= 4;
			Console.WriteLine("Bitwise Exclusive OR Assignment Operator: " + x);
			
			// initialize variable x again
			x = 12;
			
			// it means x = x >> 4
			x |= 4;
			Console.WriteLine("Bitwise Inclusive OR Assignment Operator: " + x);
		
	}
}
}
