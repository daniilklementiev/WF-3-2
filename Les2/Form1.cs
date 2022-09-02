
using System;

namespace Les2
{
    public partial class Form1 : Form
    {
        DateTime timeStarted;
        private const int M = 5;
        private const int N = 5;
        private int X = 50;
        private int Y = 20;
        Random rnd = new Random();
        int counter;
        Button[,] buttons = new Button[M, N];
        public Form1()
        {
            InitializeComponent();
            // ������������������� ������ ������
            counter = 0;
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Text = counter++.ToString();
                    buttons[i, j].Parent = this;
                    buttons[i, j].Height = 75;
                    buttons[i, j].Width = 75;
                    buttons[i, j].BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                    counter++;
                    buttons[i, j].Text = counter.ToString();
                    buttons[i, j].Click += new EventHandler(ButtonRemoving);
                    buttons[i, j].Location = new Point(i * X + i * Y, j * X + j * Y);
                }
            }
        }
        
        private void ButtonRemoving(object sender, EventArgs e)
        {
            Controls.Remove((Button)sender);
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = (DateTime.Now - timeStarted).Milliseconds.ToString();
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

        // ��� ������� �� ������� ��� ������� ASDW ���� ������������ � ������ ������� �� 50 �������� � �� ������� �� ����� ������
        /* private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Point? newLoc = null;
            // ��������� ����� �� �����
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