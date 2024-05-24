using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioDeCodigoAvanadeII.Models
{
    public class AttributesGuardian
    {
    public static bool VerificarAtributo(string atributo, int valorMinimo, int valorMaximo, int valorAtributo)
    {
        if(valorAtributo >= valorMinimo && valorAtributo <= valorMaximo) return true;
        return false;
    }

    }
}