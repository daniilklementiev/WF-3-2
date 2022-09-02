
namespace Les2
{
    public partial class Form1 : Form
    {
        DateTime timeStarted;
        
        public Form1()
        {
            InitializeComponent();
            
        }
        
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = (DateTime.Now - timeStarted).ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timeStarted = DateTime.Now;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
        }

        // при нажатии на стрелки или клавиши ASDW окно перемещается в нужную сторону на 50 пикселей и не заходит за рамки экрана
        /* private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Point? newLoc = null;
            // поставить фокус на форму
            this.Focus();


            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                newLoc = new Point(this.Location.X, this.Location.Y - 50);
            }
            else if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                newLoc = new Point(this.Location.X, this.Location.Y + 50);
            }
            else if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                newLoc = new Point(this.Location.X - 50, this.Location.Y);
            }
            else if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                newLoc = new Point(this.Location.X + 50, this.Location.Y);
            }

            if (newLoc.HasValue)
            {
                    if (Screen.PrimaryScreen.Bounds.Contains(new Rectangle(newLoc.Value, this.Size)))
                    {
                        this.Location = newLoc.Value;
                    }
            }

        }*/





    }
}