namespace Calculadora
{
    public partial class Form1 : Form
    {
        int tempo = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            
            if (pgbTempo.Value == 10)
            {
                trmTempo.Enabled = false;
                this.Hide();
                Form2 FormularioTeste = new Form2();
                FormularioTeste.ShowDialog();
            }

            else
            {
                pgbTempo.Value = pgbTempo.Value + 1;
            }

        }

        private void pgbTempo_Click(object sender, EventArgs e)
        {
            
        }
    }
}
