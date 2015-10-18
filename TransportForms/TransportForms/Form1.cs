using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TransportConsole;
using Entities;
using Logic;

namespace TransportForms
{
    public partial class Form1 : Form
    {
        static Autopark autopark = AutoparkFactory.CreateAutopark();
        List<AbstractTransport> transport = autopark.Transport;

        public Form1()
        {
            InitializeComponent();

            foreach (AbstractTransport route in transport)
            {
                listBox1.Items.Add("Название транспорта: " + route.Name + "Маршрут: " + route.Way + "Стоимость поездки: " + route.Price);
            }
            UpdateLength();
        }

        public void UpdateLength()
        {
            int totalPrice = AutoparkCalculator.CalculatePrice(autopark);
            label1.Text = "Общая стоимость поездки: " + totalPrice + " рублей";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this, autopark, transport);
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this, autopark, transport, listBox1.SelectedIndex);
            form2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            transport.RemoveAt(listBox1.SelectedIndex);
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            listBox1.Refresh();
            UpdateLength();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}