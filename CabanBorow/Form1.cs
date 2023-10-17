namespace CabanBorow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitCabans();
        }

        Image sadCaban, happyCaban;
        List<PictureBox> cabans;

        System.Windows.Forms.Timer timer = new();
        int interval = 5 * 1000;
        int numberOfCabans = 0;

        private void CabanClicked(int numberOfCaban)
        {
            timer.Tick -= TimerEnds;
            numberOfCabans = numberOfCaban;
            numberOfCaban -= 1;
            foreach (var _ in cabans)
            {
                _.Image = sadCaban;
            }
            for (int i = 0; i <= numberOfCaban; i++)
            {
                cabans[i].Image = happyCaban;
            }
            timer.Stop();
            timer.Interval = interval;
            timer.Start();
            timer.Tick += TimerEnds;
        }

        void TimerEnds(object sender, EventArgs e)
        {
            var text = "Заработало блинб";
            if (label1.Text == text)
                label1.Text = string.Empty;
            else
                label1.Text = text;
            CSVWriter.WriteInFile(numberOfCabans);

            timer.Tick -= TimerEnds;
            timer.Stop();
        }

        private void Caban1_Click(object sender, EventArgs e)
        {
            CabanClicked(1);
        }

        private void Caban2_Click(object sender, EventArgs e)
        {
            CabanClicked(2);
        }

        private void Caban3_Click(object sender, EventArgs e)
        {
            CabanClicked(3);
        }

        private void Caban4_Click(object sender, EventArgs e)
        {
            CabanClicked(4);
        }

        private void Caban5_Click(object sender, EventArgs e)
        {
            CabanClicked(5);
        }
    }
}