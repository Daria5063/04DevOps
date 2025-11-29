using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test1
{
    public partial class Form1 : Form
    {
        private Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            progressBar1.Size = new Size(40, 250);
            UpdateColor();
            
    }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Привет, Дарья !";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Привет, Дарья !";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            progressBar1.Value = trackBar1.Value;
            label2.Text = $"Значение : {trackBar1.Value}";

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

            UpdateColor();

        }

        private void label2_Click(object sender, EventArgs e)
        {
            UpdateColor();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            UpdateColor();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            UpdateColor();
        }
        private void UpdateColor()
        {
            int r = trackBar2.Value;
            int g = trackBar3.Value;
            int b = trackBar4.Value;

            panel1.BackColor = Color.FromArgb(r, g, b);
            label3.Text = $"RGB: ({r}, {g}, {b})";
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            UpdateColor();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            UpdateColor();
        }

        private void trackBar5_Scroll(object sender, EventArgs e)
        {
            progressBar2.Maximum = trackBar5.Value;
            label4.Text = $"Максимум: {trackBar5.Value}";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int randomNumber = random.Next(0, trackBar5.Value + 1);

          
            progressBar2.Value = randomNumber;

            // Показываем число в Label
            label5.Text = $"Случайное: {randomNumber}";
        }

        private void progressBar2_Click(object sender, EventArgs e)
        {

        }
    }
}