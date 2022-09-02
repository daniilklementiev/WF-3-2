namespace Les2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // при нажатии на стрелки или клавиши ASDW окно перемещается в нужную сторону на 50 пикселей и не заходит за рамки экрана
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
            {
                if (this.Left > 0)
                    this.Left -= 50;
            }
            if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                if (this.Left + this.Width < Screen.PrimaryScreen.Bounds.Width)
                    this.Left += 50;
            }
            if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up)
            {
                if (this.Top > 0)
                    this.Top -= 50;
            }
            if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
            {
                if (this.Top + this.Height < Screen.PrimaryScreen.Bounds.Height)
                    this.Top += 50;
            }
        }

    }
}