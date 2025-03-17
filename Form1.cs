using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int SideA = int.Parse(textBox2.Text);
                int SideB = int.Parse(textBox3.Text);
                int SideC = int.Parse(textBox4.Text);
                if (SideA <= 0 || SideB <= 0 || SideC <= 0) { label1.Text = "Треугольник не сущестсвует"; }
                else if (SideA == SideB && SideB == SideC) { label1.Text = "Треугольник равносторонний"; }
                else if (SideA == SideB || SideA == SideC || SideB == SideC) { label1.Text = "Треугольник равнобедренный"; }
                else if (SideA + SideB <= SideC || SideA + SideC <= SideB || SideB + SideC<=SideA) { label1.Text = "Треугольник не сущестсвует"; }
                else { label1.Text = "Треугольник разносторонний"; }
            }
            catch 
            {
                label1.Text = "Введены некоректные данные";
            }


        

        }
    }
}
