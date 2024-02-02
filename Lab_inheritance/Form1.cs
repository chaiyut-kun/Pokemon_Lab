using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_inheritance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pikachu pikachu = new Pikachu();
            label1.Text = pikachu.Name;
            pictureBox1.Image = pikachu.Picture;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Squirtle squirtle = new Squirtle();
            label1.Text = squirtle.Name;
            pictureBox1.Image = squirtle.Picture;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Wartortle wartortle = new Wartortle();
            label1.Text = wartortle.Name;
            pictureBox1.Image = wartortle.Picture;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Blastoise blastoise = new Blastoise();
            label1.Text = blastoise.Name;
            pictureBox1.Image = blastoise.Picture;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Raichu raichu = new Raichu();
            label1.Text = raichu.Name;
            pictureBox1.Image = raichu.Picture;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Nidorina nidorina = new Nidorina();
            label1.Text = nidorina.Name;
            pictureBox1.Image = nidorina.Picture;
        }
    }
}
