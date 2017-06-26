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
			Articulo art1=new Articulo(2,"A",20,5,2,(float) 12.3,1);
			Articulo art2=new Articulo(3,"A",20,5,2,(float) 12.3,1);
			Articulo art3=new Articulo(4,"A",20,5,2,(float) 12.3,1);
			Articulo art4=new Articulo(5,"A",20,5,2,(float) 12.3,1);
			
			ManejarListaArticulos listaArt = new ManejarListaArticulos();
			
			listaArt.agregarArticulo(art);
			listaArt.agregarArticulo(art2);
			listaArt.agregarArticulo(art4);
			listaArt.agregarArticulo(art1);
			listaArt.agregarArticulo(art3);
			
			Console.WriteLine("Hello World!");
			
			listaArt.todosLosArticulos();
			
			Console.WriteLine("_______");
			
			listaArt.eliminarArticulo(2);
			
			listaArt.todosLosArticulos();
			
			art1.Nombre = "b";
			
			listaArt.modificarArticulo(art1);
			
			Console.WriteLine("-----");
			
			listaArt.todosLosArticulos();
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}