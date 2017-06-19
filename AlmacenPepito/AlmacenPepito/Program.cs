/*
 * Created by SharpDevelop.
 * User: franco
 * Date: 1/6/2017
 * Time: 19:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace AlmacenPepito
{
	class Program
	{
		public static void Main(string[] args)
		{
			Articulo art=new Articulo(1,"A",20,5,2,(float) 12.3,1);
			Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}