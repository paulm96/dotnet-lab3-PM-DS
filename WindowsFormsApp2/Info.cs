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
