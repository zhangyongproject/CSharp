using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DotNetServer;

namespace RealDotNetClient
{
    public partial class Form1 : Form
    {
        DotnetComponent coment = new DotnetComponent();
        public Form1()
        {
            coment.CalculationCompleted += coment_CalculationCompleted;

            int result = coment.Add(10, 1);
            result = 5;

            InitializeComponent();
        }

        void coment_CalculationCompleted()
        {
            int a = 0;
            a += 1;
        }
    }
}
