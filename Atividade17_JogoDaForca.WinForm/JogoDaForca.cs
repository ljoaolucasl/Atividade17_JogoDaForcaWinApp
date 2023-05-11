using Atividade17_JogoDaForca.WinForm.Compartilhado;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade17_JogoDaForca.WinForm
{
    public class JogoDaForca
    {
        public string palavraSecreta;
        public char letraEscolhida;
        public bool acertou = true;
        public int contadorErros = 1;

        public void GerarPalavraAleatoria()
        {
            int numeroAleatorio;

            string[] palavrasSecretas = { "CASTELO", "REI", "RAINHA", "PRINCESA", "PRINCIPE", "ESPADA", "ARMADURA", "CAVALEIRO", "BRUXA",
                "MAGO", "DRAGÃO", "TROLL", "FLORESTA", "FEITICEIRO", "CERCO", "ARQUEIRO", "LANCEIRO", "FORTALEZA", "SOLDADO",
                "CABELO", "BALÃO", "ESTRADA", "PEDRA", "DRUIDA", "VELA", "MURALHA", "EQUILIBRIO", "ORACULO", "CANHÃO",
                "CARRUAGEM", "ALDEÃO", "COROA", "CATAPULTA", "FORTUNA", "GUERREIRO", "CERVEJA", "LENDÁRIO", "MÍTICO",
                "FANTÁSTICO", "ÉPICO", "HERÓI", "MEDIEVAL", "BATALHA", "ACORDEÃO", "FIDELIDADE", "GUILHOTINA", "FOGO"};

            Random GerarNumeroAleatorio = new();

            numeroAleatorio = GerarNumeroAleatorio.Next(0, 47);

            palavraSecreta = palavrasSecretas[numeroAleatorio];
        }

        public string VerificarSeLetraCerta(string palavraSecretaEscondida)
        {
            acertou = false;

            char[] palavraSecretaChar = (palavraSecreta.AdicionarEspacosEntreLetras()).ToCharArray();
            char[] newPalavraSecretaChar = palavraSecretaEscondida.ToCharArray();

            for (int i = 0; i < palavraSecretaChar.Length; i++)
            {
                if (VerificaLetra(palavraSecretaChar[i]))
                {
                    newPalavraSecretaChar[i] = palavraSecretaChar[i];
                    acertou = true;
                }
            }

            if (acertou == false)
                contadorErros++;

            return new string(newPalavraSecretaChar);
        }

        public bool VerificaSePalavraAcertada(string palavraSecreta)
        {
            return palavraSecreta == this.palavraSecreta.AdicionarEspacosEntreLetras();
        }

        public bool VerificaSeGameOver()
        {
            return contadorErros == 6;
        }

        private bool VerificaLetra(char palavraSecretaChar)
        {
            return String.Compare(palavraSecretaChar.ToString(), letraEscolhida.ToString(), CultureInfo.CurrentCulture, CompareOptions.IgnoreNonSpace) == 0;
        }
    }
}
