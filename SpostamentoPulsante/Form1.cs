namespace SpostamentoPulsante
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Button pulsante=new Button();
            pulsante.Location = new Point((ClientSize.Width / 2 - pulsante.Width / 2), (ClientSize.Height / 2 - pulsante.Height));
            pulsante.Size = new Size(30,30);
            pulsante.Text = "";
            this.Controls.Add(pulsante);

            Thread Destra = new Thread(VersoDestra);
            Destra.Start(pulsante);
            Thread Sinistra = new Thread(VersoSinistra);
            Sinistra.Start(pulsante);
           
        }

        public void VersoDestra(object obj)
        {
            Button pulsante = (Button)obj;
            int time = 0;
            Random rnd = new Random(DateTime.Now.Millisecond);
            while (true)
            {
                pulsante.Location = new Point((pulsante.Location.X - 10), pulsante.Location.Y);
                time = rnd.Next(0, 50);
                Thread.Sleep(time);
            }
        }

        public void VersoSinistra(object obj)
        {
            Button pulsante = (Button)obj;
            int time = 0;
            Random rnd = new Random(DateTime.Now.Millisecond);
            while (true)
            {
                
                pulsante.Location = new Point((pulsante.Location.X + 10), pulsante.Location.Y);
                time = rnd.Next(0, 50);
                Thread.Sleep(time); 
            }


        }
    }
}