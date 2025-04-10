namespace Lab6_Gra
{
    public partial class Form1 : Form
    {
        public int mainX { get; private set; }
        public int mainY { get; private set; }
        public int mainczas { get; private set; }

        public int maindydlefy { get; private set; }

        public int mainkrokodyle { get; private set; }
        public int mainszopy { get; private set; }
        
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
            
            Form1 form = new Form1();
            form.mainX = mainX;
            form.mainY = mainY; 
            form.mainczas = mainczas;   
            form.maindydlefy = maindydlefy;
            form.mainkrokodyle = mainkrokodyle;
            form.mainszopy = mainszopy;
            Gra noweokno = new Gra(form);

            
            
            if (noweokno.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using var noweokno = new Ustawienia();
            if (noweokno.ShowDialog() == DialogResult.OK)
            {
                mainX = noweokno.X;
                mainY = noweokno.Y;
                maindydlefy = noweokno.dydlefy;
                mainkrokodyle = noweokno.krokodyle;
                mainczas = noweokno.czas;
                mainszopy = noweokno.szopy; 
            }
        }
    }
}