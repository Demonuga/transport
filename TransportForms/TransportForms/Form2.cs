using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Logic;
using Entities;

namespace TransportForms
{
    public partial class Form2 : Form
    {
        static Autopark autopark1 = new Autopark();
        List<AbstractTransport> transport1;
        AbstractTransport route;
        Form1 form1;

        public Form2(Form1 fr1, Autopark autopark, List<AbstractTransport> transport)
        {
            InitializeComponent();
            this.Text = "Добавление маршрута";
            form1 = fr1;
            transport1 = transport;
            autopark1 = autopark;
            button3.Visible = false;
            comboBox1.Items.Add("Автобусы");
            comboBox1.Items.Add("Маршрутные такси");
            comboBox1.Items.Add("Такси");
            comboBox1.Items.Add("Трамваи");
            Label[] labelBox = { label2, label3, label4, label5, label6, label7, label8, label9, label10, label11, label12, label13 };
            TextBox[] textBoxBox = { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8, textBox9, textBox10, textBox11, textBox12 };
            for (int i = 0; i < 12; i++)
            {
                labelBox[i].Visible = false;
                textBoxBox[i].Visible = false;
            }
        }

        public Form2(Form1 fr1, Autopark autopark, List<AbstractTransport> transport, int selectedIndex)
        {
            InitializeComponent();
            this.Text = "Редактирование маршрута";
            form1 = fr1;
            transport1 = transport;
            autopark1 = autopark;
            button1.Visible = false;
            comboBox1.Visible = false;
            label1.Visible = false;
            Label[] labelBox = { label2, label3, label4, label5, label6, label7, label8, label9, label10, label11, label12, label13 };
            TextBox[] textBoxBox = { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8, textBox9, textBox10, textBox11, textBox12 };
            for (int i = 0; i < 12; i++)
            {
                labelBox[i].Visible = false;
                textBoxBox[i].Visible = false;
            }
            route = transport[selectedIndex];
            if (route != null)   
            {
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox1.Text = route.Name;
                textBox2.Text = route.Way;
                textBox3.Text = Convert.ToString(route.Price);
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Label[] labelBox = { label2, label3, label4, label5, label6, label7, label8, label9, label10, label11, label12, label13 };
            TextBox[] textBoxBox = { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8, textBox9, textBox10, textBox11, textBox12 };
            for (int i = 0; i < 12; i++)
            {
                labelBox[i].Visible = false;
                textBoxBox[i].Visible = false;
            }
            label1.Visible = true;
            if (comboBox1.Text == "Автобусы")
            {
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = true;
                textBox6.Visible = true;
            }
            if (comboBox1.Text == "Маршрутные такси")
            {
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                label10.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox7.Visible = true;
                textBox8.Visible = true;
                textBox9.Visible = true;
            }
            if (comboBox1.Text == "Такси")
            {
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                label11.Visible = true;
                label12.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox7.Visible = true;
                textBox8.Visible = true;
                textBox10.Visible = true;
                textBox11.Visible = true;
            }
            if (comboBox1.Text == "Трамваи")
            {
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label13.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = true;
                textBox12.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Автобусы")
            {
                Buses buses = new Buses();
                buses.Name = textBox1.Text;
                buses.Way = textBox2.Text;
                buses.Price = Convert.ToInt16(textBox3.Text);
                buses.Passengercount = Convert.ToInt16(textBox4.Text);
                buses.Dimensions = textBox5.Text;
                buses.Parkname = textBox6.Text;
                autopark1.AddTransport(buses);
            }
            if (comboBox1.Text == "Маршрутные такси")
            {
                Minibuses minibuses = new Minibuses();
                minibuses.Name = textBox1.Text;
                minibuses.Way = textBox2.Text;
                minibuses.Price = Convert.ToInt16(textBox3.Text);
                minibuses.Fuelconsumption = Convert.ToInt16(textBox7.Text);
                minibuses.Company = textBox8.Text;
                minibuses.Gradyear = Convert.ToInt16(textBox9.Text);
                autopark1.AddTransport(minibuses);
            }
            if (comboBox1.Text == "Такси")
            {
                Taxi taxi = new Taxi();
                taxi.Name = textBox1.Text;
                taxi.Way = textBox2.Text;
                taxi.Price = Convert.ToInt16(textBox3.Text);
                taxi.Fuelconsumption = Convert.ToInt16(textBox7.Text);
                taxi.Company = textBox8.Text;
                taxi.Color = textBox10.Text;
                taxi.Speed = Convert.ToInt16(textBox11.Text);
                autopark1.AddTransport(taxi);
            }
            if (comboBox1.Text == "Трамваи")
            {
                Trams trams = new Trams();
                trams.Name = textBox1.Text;
                trams.Way = textBox2.Text;
                trams.Price = Convert.ToInt16(textBox3.Text);
                trams.Passengercount = Convert.ToInt16(textBox4.Text);
                trams.Dimensions = textBox5.Text;
                trams.Condition = textBox12.Text;
                autopark1.AddTransport(trams);
            }
            form1.listBox1.Items.Clear();
            foreach (AbstractTransport route in transport1)
            {
                form1.listBox1.Items.Add("Название транспорта: " + route.Name + "; Маршрут: " + route.Way + "; Стоимость поездки: " + route.Price);
            }
            form1.UpdateLength();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            route.Name = textBox1.Text;
            route.Way = textBox2.Text;
            route.Price = Convert.ToInt16(textBox3.Text);
            form1.listBox1.Items.Clear();
            foreach (AbstractTransport route1 in transport1)
            {
                form1.listBox1.Items.Add("Название транспорта: " + route1.Name + "; Маршрут: " + route1.Way + "; Стоимость поездки: " + route1.Price);
            }
            form1.UpdateLength();
            Close();
        }
    }
}