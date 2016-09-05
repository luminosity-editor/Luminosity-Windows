using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace luminosity
{
    public partial class luminosity : Form
    {
        private void initilize()
        {
            InitializeComponent();
        }

        public luminosity()
        {
            initilize();

            Color background = Color.FromArgb(32, 31, 36);

            Color foreground = Color.FromArgb(52, 51, 56);

            //this.BackColor = foreground;

            this.Text = "Luminosity";

            this.Icon = Properties.Resources.lumo;

            Panel toolBar = new Panel();

            toolBar.Height = 60;

            toolBar.Width = this.Width;

            toolBar.BackColor = background;

            this.Controls.Add(toolBar);

            Label title = new Label();

            title.Text = this.Text;

            title.ForeColor = Color.White;

            title.Location = new Point(15, 5);

            toolBar.Controls.Add(title);
        }
    }
}
