using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clickMeButton_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Name = userNameTextBox.Text;
            user.FamilyName = userFamilyName.Text;
            MessageBox.Show(String.Format("Hello, {0}", userNameTextBox.Text));
            Stopwatch watch = new Stopwatch();
            watch.Start();
            List<int> a = new List<int>();
            for (int i = 0; i < 1000000; i++)
            {
                a.Add(123);
            }
            watch.Stop();
            ellapsedTimeLabel.Text = String.Format("{0} ms", watch.ElapsedMilliseconds);
        }

        private void clickMeButton_MouseEnter(object sender, EventArgs e)
        {
            
        }
    }
}
