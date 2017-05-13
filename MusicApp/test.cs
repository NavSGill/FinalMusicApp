using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicApp
{
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
        }

        private void Butclose_Click(object sender, EventArgs e)
        {
            DirectoryInfo asd = new DirectoryInfo(Directory.GetCurrentDirectory() + "\\..\\..\\Music");
            MessageBox.Show(asd.FullName + "\\" + "rapGod.mp3");

            //ASD.fullname is the complete path to the music folder
            //rapgod.mp3
            //ASD.fullname + "\\" + musicName[0]
        }
    }
}
