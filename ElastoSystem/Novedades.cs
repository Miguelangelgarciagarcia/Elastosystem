using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElastoSystem
{
    public partial class Novedades : Form
    {
        public Novedades()
        {
            InitializeComponent();
        }

        private void horayfecha_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToString("HH:mm:ss");
            lblfecha.Text = DateTime.Now.ToLongDateString();

        }

        private void LoadNextImage()
        {
            Random rand = new Random();
            int imageNumber = rand.Next(1, 7);

            pbSlide.ImageLocation = string.Format(@"Images\{0}.jpg", imageNumber);

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
        }

        private void Novedades_Load(object sender, EventArgs e)
        {

        }

        private void lblfecha_Click(object sender, EventArgs e)
        {

        }

        private void pbSlide_Click(object sender, EventArgs e)
        {

        }
    }
}
