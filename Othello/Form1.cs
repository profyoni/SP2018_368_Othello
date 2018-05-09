using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Othello
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Initialize2();
        }

        private void Initialize2()
        {
            buttons = new Button[8,8];
            for (int row = 0; row < 8; row++)
            for (int column = 0; column < 8; column++)
            {
                var b = buttons[row, column] = new System.Windows.Forms.Button();
               
                this.tableLayoutPanel1.Controls.Add(b, column, row );
                b.Dock = System.Windows.Forms.DockStyle.Fill;
                b.TabIndex = row*8 +column;

                b.Click += ButtonClickHandler;
                    b.Font = new Font(FontFamily.GenericMonospace, 100);
            }

           
        }

        private void ButtonClickHandler(object sender, EventArgs e)
        {
            // check if legal
            // set Model
            var b = sender as Button;
            b.Text = "\u23FA";
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
