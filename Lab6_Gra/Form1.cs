namespace Lab6_Gra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using var noweokno = new Gra();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using var noweokno = new Ustawienia();
        }
    }
}