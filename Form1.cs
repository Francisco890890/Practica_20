namespace Practica_20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Edad;
            Edad = int.Parse(textBox1.Text);
            if (Edad < 12) MessageBox.Show("Es un niño");

            if (Edad >= 12 && Edad < 18)

                MessageBox.Show("Es un adolecente");

            if (Edad >= 18 && Edad < 60)

                MessageBox.Show("Es un adulto");

            if (Edad >= 60)

                MessageBox.Show("Ya esta Viejillo :c");
        }
    }
}