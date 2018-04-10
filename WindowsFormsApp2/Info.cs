using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
        }

        public void set(string description, string path)
        {
            textBox1.Text = description;            
            pictureBox1.ImageLocation = path;
            this.Refresh();
        }
    }
}
