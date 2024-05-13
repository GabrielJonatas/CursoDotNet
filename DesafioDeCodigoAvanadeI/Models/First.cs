using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

class First
{
    public void Saque(int saldoTotal, int valorSaque)
    {
        int saldo;
        
        if(valorSaque <= saldoTotal) {
          saldo = saldoTotal - valorSaque;
          Console.WriteLine($"Saque realizado com sucesso. Novo saldo: {saldo}");
        } else {
          Console.WriteLine("Saldo insuficiente. Saque nao realizado!");
        }
        
    }
}