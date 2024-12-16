using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace code241216
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            byte pixelValue = 20;
            short shortValueLimit = 32767;
            int totalCount = 987654;
            float temperatureValue = -3.4f;
            double distanceCovered = 1234567.89;
           decimal transactionAmount = 12345.67m;

            textBox1_print.Text += $"{pixelValue.GetType()}" + " " + "pixelValue" + " " + $"{pixelValue.ToString()}" + "\r\n";
            textBox1_print.Text += $"{shortValueLimit.GetType()}" + " " + "shortValueLimit" + " " + $"{shortValueLimit.ToString()}" + "\r\n";
            textBox1_print.Text += $"{totalCount.GetType()}" + " " + "totalCount" + " " + $"{totalCount.ToString()}" + "\r\n";
            textBox1_print.Text += $"{temperatureValue.GetType()}" + " " + "temperatureValue" + " " + $"{temperatureValue.ToString()}" + "\r\n";
            textBox1_print.Text += $"{distanceCovered.GetType()}" + " " + "distanceCovered " + " " + $"{distanceCovered.ToString()}" + "\r\n";
            textBox1_print.Text += $"{transactionAmount.GetType()}" + " " + "transactionAmount" + " " + $"{transactionAmount.ToString()}";

        }
    }
}
