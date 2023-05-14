using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Lab_4_2
{
    public partial class Form1 : Form
    {
        Model model;
        public Form1()
        {
            InitializeComponent();

            model = new Model();
            model.observers += new System.EventHandler(UpdateModuleDependents);
        }

        private void UpdateModuleDependents(object sender, EventArgs e) // Обработчик события observers
        {
            textBoxA.Text = model.getA().ToString(); // Записываем в textBox'ы значение из модели
            textBoxB.Text = model.getB().ToString();
            textBoxC.Text = model.getC().ToString();

            numericUpDownA.Value = model.getA(); // Записываем в numericUpDown'ы значение из модели
            numericUpDownB.Value = model.getB();
            numericUpDownC.Value = model.getC();

            trackBarA.Value = model.getA(); // Записываем в trackBar'ы значение из модели
            trackBarB.Value = model.getB();
            trackBarC.Value = model.getC();
        }

        private void Form1_Load(object sender, EventArgs e) // Обработка события загрузки формы
        {
            model.setValuesFromSettings();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) // Обработка события закрытия формы (до её полного закрытия)
        {
            model.saveValuesToSettings();
        }

        private void textBoxA_KeyDown(object sender, KeyEventArgs e) // Обработка события нажатия в textBoxA
        {
            if (e.KeyCode == Keys.Enter)
                if (textBoxA.Text != "")
                    model.setA(Int32.Parse(textBoxA.Text));
                else
                    model.setA(0);
        }

        private void textBoxB_KeyDown(object sender, KeyEventArgs e) // Обработка события нажатия в textBoxB
        {
            if (e.KeyCode == Keys.Enter)
                if (textBoxB.Text != "")
                    model.setB(Int32.Parse(textBoxB.Text));
                else
                    model.setB(0);
        }

        private void textBoxC_KeyDown(object sender, KeyEventArgs e) // Обработка события нажатия в textBoxC
        {
            if (e.KeyCode == Keys.Enter)
                if (textBoxC.Text != "")
                    model.setC(Int32.Parse(textBoxC.Text));
                else
                    model.setC(0);
        }

        private void numericUpDownA_ValueChanged(object sender, EventArgs e) // Обработка события изменения значения в numericUpDownA
        {
            model.setA(Decimal.ToInt32(numericUpDownA.Value));
        }

        private void numericUpDownB_ValueChanged(object sender, EventArgs e) // Обработка события изменения значения в numericUpDownB
        {
            model.setB(Decimal.ToInt32(numericUpDownB.Value));
        }

        private void numericUpDownC_ValueChanged(object sender, EventArgs e) // Обработка события изменения значения в numericUpDownC
        {
            model.setC(Decimal.ToInt32(numericUpDownC.Value));
        }

        private void trackBarA_Scroll(object sender, EventArgs e) // Обработка события прокручивания в trackBarA
        {
            model.setA(trackBarA.Value);
        }

        private void trackBarB_Scroll(object sender, EventArgs e) // Обработка события прокручивания в trackBarB
        {
            model.setB(trackBarB.Value);
        }

        private void trackBarC_Scroll(object sender, EventArgs e) // Обработка события прокручивания в trackBarC
        {
            model.setC(trackBarC.Value);
        }

        private void textBoxA_Leave(object sender, EventArgs e)
        {
            if (textBoxA.Text != "")
                model.setA(Int32.Parse(textBoxA.Text));
            else
                model.setA(0);
        }

        private void textBoxB_Leave(object sender, EventArgs e)
        {
            if (textBoxB.Text != "")
                model.setB(Int32.Parse(textBoxB.Text));
            else
                model.setB(0);
        }

        private void textBoxC_Leave(object sender, EventArgs e)
        {
            if (textBoxC.Text != "")
                model.setC(Int32.Parse(textBoxC.Text));
            else
                model.setC(0);
        }

        private void numericUpDownA_Leave(object sender, EventArgs e)
        {
            if (numericUpDownA.Text != "")
                model.setA(Decimal.ToInt32(numericUpDownA.Value));
            else
            {
                model.setA(0); numericUpDownA.Text = "0";
            }
        }

        private void numericUpDownB_Leave(object sender, EventArgs e)
        {
            if (numericUpDownB.Text != "")
                model.setB(Decimal.ToInt32(numericUpDownB.Value));
            else
            {
                model.setB(0); numericUpDownB.Text = "0";
            }
        }

        private void numericUpDownC_Leave(object sender, EventArgs e)
        {
            if (numericUpDownC.Text != "")
                model.setC(Decimal.ToInt32(numericUpDownC.Value));
            else
            {
                model.setC(0); numericUpDownC.Text = "0";
            }    
        }
    }

    public class Model
    {
        private int a, b, c;

        public EventHandler observers;

        public Model() { }

        public void setValuesFromSettings()
        {
            a = Settings1.Default.value_a; // Вписываем значения из файла настроек
            b = Settings1.Default.value_c;
            c = Settings1.Default.value_b;
        }

        public void saveValuesToSettings()
        {
            Settings1.Default.value_a = a; // Записываем значения в файл настроек
            Settings1.Default.value_b = b;
            Settings1.Default.value_c = c;
            Settings1.Default.Save(); // Сохраняем изменения в файле настроек
        }
        public void setA(int value) // Установить значение a
        {
            if (value >= 0 && 100 >= value) // Запрещающее поведение
            {
                a = value; // Разрешающее поведенеи

                if (a > c)
                    c = a;

                if (a > b)
                    b = a;
            }
            observers.Invoke(this, EventArgs.Empty); // Вызываем обработчик событий 
        }

        public void setB(int value) // Установить значение b
        {
            if (value >= a && value <= c && value >= 0 && value <= 100) // Запрещающее поведение
            {
                b = value;
            }
            observers.Invoke(this, EventArgs.Empty);
        }

        public void setC(int value) // Установить значение c
        {
            if (value >= 0 && 100 >= value)
            {
                c = value; // Разрешающее поведение

                if (c < b)
                    b = c;

                if (c < a)
                    a = c;  
            }
            observers.Invoke(this, EventArgs.Empty);
        }

        public int getA() // Получить значение a
        {
            return a;
        }

        public int getB() // Получить значение b
        {
            return b;
        }

        public int getC() // Получить значение c
        {
            return c;
        }
    }
}
