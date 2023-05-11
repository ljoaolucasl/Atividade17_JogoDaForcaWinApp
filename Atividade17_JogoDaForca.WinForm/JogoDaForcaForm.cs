using Atividade17_JogoDaForca.WinForm.Compartilhado;

namespace Atividade17_JogoDaForca.WinForm
{
    public partial class JogoDaForcaForm : Form
    {
        private JogoDaForca jogoDaForca = new JogoDaForca();

        public JogoDaForcaForm()
        {
            InitializeComponent();
        }

        private void ObterChute(object? sender, EventArgs e)
        {
            txtChute.Focus();

            if (txtChute.Text == "")
                return;

            jogoDaForca.letraEscolhida = Convert.ToChar(txtChute.Text);

            txtChute.ResetText();

            labelPalavraSecreta.Text = jogoDaForca.VerificarSeLetraCerta(labelPalavraSecreta.Text);

            if (jogoDaForca.acertou == false)
            {
                switch (jogoDaForca.contadorErros)
                {
                    case 2: picBoxErro1.Visible = false; break;
                    case 3: picBoxErro2.Visible = false; break;
                    case 4: picBoxErro3.Visible = false; break;
                    case 5: picBoxErro4.Visible = false; break;
                    case 6: picBoxErro5.Visible = false; break;
                }

                InserirLetraErradaJaEscolhida();

                if (jogoDaForca.contadorErros == 6)
                    GameOver();
            }

            if (VerificaSePalavraAcertada())
                Ganhou();
        }

        private bool VerificaSePalavraAcertada()
        {
            return labelPalavraSecreta.Text == jogoDaForca.palavraSecreta.AdicionarEspacosEntreLetras();
        }

        private void InserirLetraErradaJaEscolhida()
        {
            labelLetrasErradas.Text += jogoDaForca.letraEscolhida.ToString() + " ";
        }

        private void Jogar(object? sender, EventArgs e)
        {
            labelPalavraSecreta.Text = IniciarJogo();
        }

        private string IniciarJogo()
        {
            jogoDaForca = new();

            MostrarInformacoesTela();

            btnStart.Visible = false;
            picBoxStart.Visible = false;
            btnJogarNovamente.Visible = false;
            picBoxAcertoPart1.Visible = false;
            picBoxAcertoPart2.Visible = false;
            picBoxGameOver.Visible = false;

            labelLetrasErradas.ResetText();
            labelRevelaPalavraSecreta.ResetText();

            txtChute.Focus();

            jogoDaForca.GerarPalavraAleatoria();

            return (jogoDaForca.palavraSecreta.AdicionarEspacosEntreLetras()).TranformarLetrasEmTracos();
        }

        private void Ganhou()
        {
            EsconderInformacoesTela();
            picBoxAcertoPart1.Visible = true;
            picBoxAcertoPart2.Visible = true;
            btnJogarNovamente.Visible = true;
            btnJogarNovamente.Focus();
        }

        private void GameOver()
        {
            EsconderInformacoesTela();
            labelRevelaPalavraSecreta.Text = "A Palavra Secreta era: " + jogoDaForca.palavraSecreta;
            picBoxGameOver.Visible = true;
            btnJogarNovamente.Visible = true;
            btnJogarNovamente.Focus();
        }

        private void EsconderInformacoesTela()
        {
            btnChute.Visible = false;

            labelLetrasErradas.Visible = false;
            labelPalavraSecreta.Visible = false;

            txtChute.Visible = false;
        }

        private void MostrarInformacoesTela()
        {
            btnChute.Visible = true;

            labelLetrasErradas.Visible = true;
            labelPalavraSecreta.Visible = true;

            txtChute.Visible = true;

            picBoxErro1.Visible = true;
            picBoxErro2.Visible = true;
            picBoxErro3.Visible = true;
            picBoxErro4.Visible = true;
            picBoxErro5.Visible = true;
        }

        private void ApenasMaiusculo(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }
    }
}