using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_1_19PyzhovDK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        abstract class komplekt<T>
        {
            public T article;
            public int price;
            public int agev;
            public komplekt(T art, int pr, int agv)
            {
                article = art;
                price = pr;
                agev = agv;
            }
            public abstract void Display(ListBox lb);
        }
        class ChildProcessor<T> : komplekt<T>
        {
            private int chastota;
            public int chastota1
            {
                get { return chastota; }
                set { chastota = value; }
            }
            private int yadra;
            public int yadra1
            {
                get { return yadra; }
                set { yadra = value; }
            }
            private int potoki;
            public int potoki1
            {
                get { return potoki; }
                set { potoki = value; }
            }

            public ChildProcessor(T art, int price, int age, int gz, int yad, int potok)
            : base(art, price, age)
            {
                chastota1 = gz;
                yadra1 = yad;
                potoki1 = potok;
            }
            public override void Display(ListBox lb)
            {
                lb.Items.Add($"Артикул товара : {article}");
                lb.Items.Add($"Цена товара : {price}");
                lb.Items.Add($"Год выпуска товара : {agev}");
                lb.Items.Add($"Тактовая частота процессора :{chastota1}");
                lb.Items.Add($"Количество ядер процессора :{yadra1}");
                lb.Items.Add($"Количество потоков процессора :{potoki1}");
            }
            
        }
        class Vidyaha<T> : komplekt<T>
        {
            private int GPU;
            public int GPU1
            {
                get { return GPU; }
                set { GPU = value; }
            }

            private string perfom;
            public string perfom1
            {
                get { return perfom; }
                set { perfom = value; }
            }

            private int pamyat;
            public int pamyat1
            {
                get { return pamyat; }
                set { pamyat = value; }
            }

            public Vidyaha(T art, int price, int age, int gpu, string proiz, int GB)
            : base(art, price, age)
            {
                GPU1 = gpu;
                perfom1 = proiz;
                pamyat1 = GB;
            }
            public override void Display(ListBox lb)
            {
                lb.Items.Add($"Артикул товара : {article}");
                lb.Items.Add($"Цена товара : {price}");
                lb.Items.Add($"Год выпуска товара : {agev}");
                lb.Items.Add($"Частота видеочипа :{GPU1}");
                lb.Items.Add($"Фирма производитель :{perfom1}");
                lb.Items.Add($"Объём памяти :{pamyat1}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            ChildProcessor<string> cp1 = new ChildProcessor<string>(textBox3.Text, Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text), Convert.ToInt32(textBox7.Text), Convert.ToInt32(textBox8.Text));
            cp1.Display(listBox2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            Vidyaha<string> vid1  = new Vidyaha<string>(textBox3.Text, Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text), textBox7.Text, Convert.ToInt32(textBox8.Text));
            vid1.Display(listBox2);
        }
    }
}
