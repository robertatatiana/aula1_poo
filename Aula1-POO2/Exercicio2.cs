using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1_POO2
{
    internal class Exercicio2
    {
    }
    public abstract class Funcionario
    {
        public abstract void getBonificacao();
    }

    public abstract class Secretaria
    {
        public abstract void getBonificacao();
    }

    public class SecretariaAdministrativa : Secretaria
    {
        public override void getBonificacao()
        {
            //..
        }
    }

    public class SecretariaAgencia : Secretaria
    {
        public override void getBonificacao()
        {
            //..
        }
    }

    public class Presidente : Funcionario
    {
        public override void getBonificacao()
        {
            //..
        }
    }

    public class Gerente : Funcionario
    {
        public override void getBonificacao()
        {
            //..
        }
    }

    public class Diretor : Gerente
    {

    }
}
