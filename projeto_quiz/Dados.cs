using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_quiz
{
    class Dados
    {
        public static int Acerto = 0;
        public static int Erro = 0;

        public static void Acertou()
        {
            Acerto++;
        }

        public static void Errou()
        {
            Erro++;
        }

        public static int getAcertos()
        {
            return Acerto;
        }

        public static int getErro()
        {
            return Erro;
        }

    }
}
