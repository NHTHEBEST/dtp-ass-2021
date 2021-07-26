using System;
using System.Windows.Forms;

namespace OX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Load Help Screen Before Showing game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            Help h = new Help();
            h.ShowDialog();

        }
    }
}
