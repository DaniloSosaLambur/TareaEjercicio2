using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TareaEjercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private  async void button1_Click(object sender, EventArgs e)
        {
            decimal nota1 = 0;
            decimal nota2 = 0;
            decimal nota3 = 0;
            decimal nota4 = 0;
            nota1 = Convert.ToDecimal(nota1textBox.Text);
            nota2 = Convert.ToDecimal(nota2textBox.Text);
            nota3 = Convert.ToDecimal(nota3textBox.Text);
            nota4 = Convert.ToDecimal(nota4textBox.Text);
            decimal prom = await CalcularaAsync(nota1, nota2, nota3, nota4);
            MessageBox.Show($"El promedio es:{prom}");
            LimpiarControles();
        }
        private async Task<decimal> CalcularaAsync(decimal nota1, decimal nota2, decimal nota3, decimal nota4)
        {
            decimal promedio = await Task.Run(() =>
            {
                return (nota1 + nota2 + nota3 + nota4)/4;         
            });
            return promedio;
        }

        private void LimpiarControles()
        {
            nota1textBox.Clear();
            nota2textBox.Clear();
            nota3textBox.Clear();
            nota4textBox.Clear();
        }

    }
}
