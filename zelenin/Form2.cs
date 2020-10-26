using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zelenin
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.Load(openFileDialog1.FileName);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Clear();
            maskedTextBox1.Clear();
        }

        public string CardName
        {
            get
            {
                return textBox1.Text;
            }
        }

        public int CardAge
        {
            get
            {
                return int.Parse(maskedTextBox1.Text);
            }
        }

        public char CardGender
        {
            get
            {
                return comboBox1.Text[0];
            }
        }

        public PictureBox CardPhoto
        {
            get
            {
                return pictureBox1;
            }
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
