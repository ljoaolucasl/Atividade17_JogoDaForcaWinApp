using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade17_JogoDaForca.WinForm.Compartilhado
{
    public static class Extension
    {
        public static string AdicionarEspacosEntreLetras(this string str)
        {
            string newStr = "";

            for (int i = 0; i < str.Length; i++)
            {
                newStr += str[i];

                if (i < str.Length - 1)
                    newStr += " ";
            }

            return newStr;
        }

        public static string TranformarLetrasEmTracos(this string str)
        {
            char[] newChar = str.ToCharArray();

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                    newChar[i] = '_';
            }

            return new string(newChar);
        }
    }
}
