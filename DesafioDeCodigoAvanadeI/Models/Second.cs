using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

class Second
{
    public void ListOfitens(string newItemI,string newItemII,string newItemIII)
    {
        // Lista para armazenar os itens
        List<string> itens = new List<string>();

        // TODO: Solicite os itens ao usuário
            itens.Add(newItemI);
            itens.Add(newItemII);
            itens.Add(newItemIII);

        // Exibe a lista de itens
        Console.WriteLine("Lista de itens:");
        foreach (string item in itens)
        {
            Console.WriteLine($"- {item}");
        }
    }
}