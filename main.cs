using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
  }
}
class Genotype {
	public string genotype;
	public static Generation operator +(Genotype f1, Genotype f2) 
   {
      var foo = // some logic to generate a result
      return foo;
		 }
}
class Generation {
	public string First;
	public string Second;
	public Generation(Genotype f1,Genotype f2) {
		
	}
}