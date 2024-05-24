using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExemploExplorando.models;

namespace ExemploExplorando.models
{
    public class LeituraArquivo
    {
        public (bool Success, string[] Lines, int LinesQuantity) LerArquivo(string caminho) 
        {
            try {
                string[] linhas = File.ReadAllLines(caminho);
                return (true, linhas, linhas.Count());
            } catch (Exception) 
            {
                return (false, new string[0], 0);
            }
        }
    }
}