using Geometrique;
using System;

class Program
{
    static void Main()
    {
        // Classe Point
        Console.WriteLine("Classe Point :");
        Point o = new Point(0, 0);
        Point a = new Point(2, 2);
        Point b = new Point(2, 2);

        Console.WriteLine($"O{o}");
        Console.WriteLine($"A{a}");
        Console.WriteLine($"B{b}");

        if (a.Equals(b))
            Console.WriteLine("A et B sont égaux");
        else
            Console.WriteLine("A et B sont différents");

        if (a.Equals(o))
            Console.WriteLine("A et O sont égaux");
        else
            Console.WriteLine("A et O sont différents");

        Console.WriteLine();

        // Classe Cercle
        Console.WriteLine("Classe Cercle :");
        Cercle c = new Cercle(a, 10);
        Console.WriteLine($"Centre : {c.Position}, Rayon : {c.Rayon}");
        Console.WriteLine($"Perimetre : {c.Perimetre():0.###############}");
        Console.WriteLine($"Aire : {c.Aire():0.###############}");
        Console.WriteLine();

        // Classe Rectangle
        Console.WriteLine("Classe Rectangle :");
        Rectangle r = new Rectangle(a, 40, 10);
        Console.WriteLine($"Centre : {r.Position}, Longueur : {r.Longueur}, Largeur : {r.Largeur}");
        Console.WriteLine($"Perimetre : {r.Perimetre():0.###############}");
        Console.WriteLine($"Aire : {r.Aire():0.###############}");
    }
}
