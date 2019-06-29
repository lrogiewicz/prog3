using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program3_winforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int GetRepetitionsNumber()
        {
            int repetitionsNumber;
            try
            {
                repetitionsNumber = Int32.Parse(textBox1.Text);
                return repetitionsNumber;
            }
            catch (Exception)
            {
                label6.Text = "Podano błędną ilość powtórzeń. ";
                return 0;
            }
        }

        private int GetInterval()
        {
            int interval;
            try
            {
                interval = Int32.Parse(textBox1.Text);
                return interval;
            }
            catch (Exception)
            {
                label6.Text = "Podano błędną wartość interwału. ";
                return 0;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int repetitionsNumber = GetRepetitionsNumber();
            if (repetitionsNumber == 0)
            {
                return;
            }

            int interval = GetInterval();
            if (interval == 0)
            {
                return;
            }
                                  

            for (int i=0; i <= interval; i++)
            {
                label6.Text = i.ToString();
            }
        }
    }
}
