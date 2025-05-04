using System;

public class RolandoDado
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Digite o numero de lados do dado que voce quer rolar: ");
        int lados = Convert.ToInt32(Console.ReadLine());
        Random dado = new Random();
        Console.WriteLine("Rolou: "+dado.Next(1,lados+1));
    }
}