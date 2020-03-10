using System;
using System.Windows.Forms;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Presenters;

namespace WindowsFormsApp1
{
    public partial class DummyForm : Form
    {
        public DummyForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new CalcPresenter(new CalcForm(), new CalcModel());
        }
    }
}
