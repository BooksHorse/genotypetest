using System;

class Program {
  public static void Main (string[] args) {
		var a = new Genotype("aa");
		var b = new Genotype("AA");
		var c = a+b;
    Console.WriteLine (c.GetAllele());
  }
}
class Genotype {
	public string Alleles;
	public static Generation operator +(Genotype f1, Genotype f2) 
   {
      var generation = new Generation(f1,f2);
      return generation;
		 }
	public Genotype(string alleles) {
		Alleles=alleles;
	}
	public override string ToString()
    {
        return Alleles;
    }
}
class Generation {
	public string First;
	public string Second;
	public Generation(Genotype f1,Genotype f2) {
		First=f1.Alleles;
		Second=f2.Alleles;
	}
	public char[] GetAllele() {
		return (First+Second).ToCharArray();
	}
	public override string ToString()
    {
        return First+Second;
			}
}