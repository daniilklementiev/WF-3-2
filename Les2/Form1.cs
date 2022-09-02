namespace Les2
{
    public partial class Form1 : Form
    {
        int X = 0;
        int Y = 0;
        public Form1()
        {
            InitializeComponent();
            
        }
        // при нажатии на стрелки или клавиши ASDW окно перемещается в нужную сторону на 50 пикселей и не заходит за рамки экрана
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Point? newLoc = null!;

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

        }

    }
}