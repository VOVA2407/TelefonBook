/*
 * Created by SharpDevelop.
 * User: Admin
 * Date: 16.05.2017
 * Time: 16:15
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace TelefonBook
{
	public class phoneBook
	{
		string name;
		public string Name { get; set; }
		public string Surname { get; set;}
		public string Adress { get; set;}
		
		public string Name1
		{
			get {return name;}
			set {name = value;}
		}
		
		public phoneBook()
		{
			name = "Нет данных";
		}
	}
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			phoneBook Book = new phoneBook();
			// TODO: Implement Functionality Here
			Book.Name1 = "Телефонная книга";
			Book.Name = "Vladimir";
			Book.Surname = "Iakovlev";
			Book.Adress = "Sportivnaya";
			Console.WriteLine("{0} {1} {2}", Book.Name, Book.Surname, Book.Adress);
			Console.WriteLine("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}