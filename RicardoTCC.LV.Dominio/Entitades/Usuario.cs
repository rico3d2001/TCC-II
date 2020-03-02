using RicardoTCC.LV.Dominio.ObjetosValor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicardoTCC.LV.Dominio.Entitades
{
    public class Usuario:Entidade
    {
        public Login Login { get; set; }
        public Senha Senha { get; set; }
        public bool IsVerficador { get; set; }
    }
}
