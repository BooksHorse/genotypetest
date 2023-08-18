using System;

class Program
{
    public static void Main(string[] args)
    {
        var father = new Genotype("Ll");
        var mother = new Genotype("Ll");
        var parents = father + mother;
        Console.WriteLine(string.Join(",", parents.Mix()));
    }
}
class Genotype
{
    public string Alleles;
    public static Generation operator +(Genotype f1, Genotype f2)
    {
        var generation = new Generation(f1, f2);
        return generation;
    }
    public Genotype(string alleles)
    {
        Alleles = alleles;
    }
    public override string ToString()
    {
        return Alleles;
    }
}
class Generation
{
    public string First;
    public string Second;
    public Generation(Genotype f1, Genotype f2)
    {
        First = f1.Alleles;
        Second = f2.Alleles;
    }
    public string[] Mix()
    {
        var result = new string[4];
        result[0] = $"{First[0]}{Second[0]}";
        result[1] = $"{First[0]}{Second[1]}";
        result[2] = $"{First[1]}{Second[0]}";
        result[3] = $"{First[1]}{Second[1]}";
        return result;
    }
    public override string ToString()
    {
        return First + Second;
    }
}