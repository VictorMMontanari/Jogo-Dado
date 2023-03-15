namespace Jogo_Dado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int jogo1 = random.Next(1, 7);
            int jogo2 = random.Next(1, 7);
            int jogo3 = random.Next(1, 7);
            
            label9.Text = jogo1.ToString();
            label10.Text = jogo2.ToString();
            label11.Text = jogo3.ToString();

            int jogada1 = Convert.ToInt16(textBox1.Text);
            int jogada2 = Convert.ToInt16(textBox2.Text);
            int jogada3 = Convert.ToInt16(textBox3.Text);

            jogador(jogada1, jogada2, jogada3, jogo1, jogo2, jogo3);
        }
        void jogador(int jogada1, int jogada2, int jogada3, int jogo1, int jogo2, int jogo3)
        {
            int pontos = 0;

            if (jogada1 == jogo1) pontos++;
            if (jogada2 == jogo2) pontos++;
            if (jogada3 == jogo3) pontos++;

            if (pontos >= 2)
            {
                label3.Text = "Você venceu!";
                label4.Text = "Máquina perdeu!";
            }
            else
            {
                label3.Text = "Você Perdeu!";
                label4.Text = "Máquina venceu!";
            }
        }
    }
}