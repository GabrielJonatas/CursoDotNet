using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioDeCodigoAvanadeII.Models
{
    public class DamageCounter
    {
        public static int Counter(int attack, int defense) {
            int damage = attack - defense;
            if (damage < 0) return 0;
            return damage;
        } 
    }
}