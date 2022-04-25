using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject2
{
    internal class MaiorIdade
    {
        public bool VerificandoSeoUsuarioEMaiorDeIdade(int Idade)
        {
            var user = new User();
            if (Idade > user.Age)
            {
                return true;
            }
            return false;
        }
    }
}
