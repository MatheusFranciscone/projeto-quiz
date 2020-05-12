using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        public static int PontAcerto = 0;
        public static int PontErro = 0;

        //Acertos e Erros
        public static void Acertou()
        {
            Acerto++;

        }
        public static void Errou()
        {
            Erro++;

        }

        //Pontuação 
        public static void PontErrou()
        {
            PontErro -= 5;

        }
        public static void PontAcertou()
        {
            PontAcerto += 10;

        }

        //Gets

        public static int getAcertos()
        {
            return Acerto;
        }

        public static int getErro()
        {
            return Erro;
        }

        public static int getPontAcerto()
        {
            return PontAcerto;
        }

        public static int getPontErro()
        {
            return PontErro;
        }
    }
}
