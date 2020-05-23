using System;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Globalization;
using System.Resources;

namespace SimulatorOfLife
{
	public partial class Form1 : Form
	{
		private Graphics graphics;
		private int currentGeneration = 0;
		private int space;

		private bool[,] field;
		private int rows;
		private int cols;

		public Form1()
		{
			InitializeComponent();
			CultureInfo culture = CultureInfo.CurrentCulture;
			ResourceManager manager = new ResourceManager("SimulatorOfLife.Languages.Messanges", typeof(Form1).Assembly);
			label_Dansity.Text = manager.GetString("Density", culture);
			label_Space.Text = manager.GetString("Space", culture);	
		}

		private void StartGame()
		{
			if (timer1.Enabled)
				return;

			numericSpace.Enabled = false;
			numericDensity.Enabled = false;

			currentGeneration = 0;
			Text = $"Generation {currentGeneration}";

			space = (int)numericSpace.Value;
			rows = pictureBox1.Height / space;
			cols = pictureBox1.Width / space;

			field = new bool[cols, rows];
			Random random = new Random();
			for (int x = 0; x < cols; x++)
			{
				for (int y = 0; y < rows; y++)
				{
					field[x, y] = random.Next((int)numericDensity.Value) == 0;
				}
			}

			pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
			graphics = Graphics.FromImage(pictureBox1.Image);
			timer1.Start();
		}

		private void NextGeneration()
		{
			graphics.Clear(Color.Black);

			var newfield = new bool[cols, rows];
			for (int x = 0; x < cols; x++)
			{
				for (int y = 0; y < rows; y++)
				{
					int neighboursCount = CountNeighbours(x, y);
					bool hasLife = field[x, y];

					if (!hasLife && neighboursCount == 3)
						newfield[x, y] = true;
					else if (hasLife && (neighboursCount < 2 || neighboursCount > 3))
						newfield[x, y] = false;
					else
						newfield[x, y] = field[x, y];

					if (hasLife)
						graphics.FillRectangle(Brushes.Crimson, x * space, y * space, space, space);
				}
			}

			field = newfield;
			pictureBox1.Refresh();
			Text = $"Generation {++currentGeneration}";
		}

		private int CountNeighbours(int x, int y)
		{
			int count = 0;

			for (int i = -1; i < 2; i++)
			{
				for (int j = -1; j < 2; j++)
				{
					int col = (x + i + cols) % cols;
					int row = (y + j + rows) % rows;

					bool isChecking = ((col == x) && (row == y));
					bool hasLife = field[col, row];

					if (hasLife && !isChecking)
						count++;

				}
			}

			return count;
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			NextGeneration();
		}

		private void StopGame()
		{
			if (!timer1.Enabled)
				return;
			timer1.Stop();
			numericSpace.Enabled = true;
			numericDensity.Enabled = true;
		}

		private void bgameTime_Click(object sender, EventArgs e)
		{
			if (bgameTime.Text == "Start")
			{
				StartGame();
				bgameTime.Text = "Stop";
			}
			else if (bgameTime.Text == "Stop")
			{
				StopGame();
				bgameTime.Text = "Start";
			}
		}

		private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
		{
			if (!timer1.Enabled)
				return;

			if (e.Button == MouseButtons.Left)
			{	
				Moving(e, true);
			}
			else if (e.Button == MouseButtons.Right)
			{
				Moving(e, false);
			}
		}

		private void Moving(MouseEventArgs e, bool isMoving)
		{
			int x = e.Location.X / space;
			int y = e.Location.Y / space;
			if (ValidationMousePozition(x, y))
				field[x, y] = isMoving;
		}

		private bool ValidationMousePozition(int x, int y)
		{
			return x >= 0 && y >= 0 && x < cols && y < rows;
		}

	}
}
