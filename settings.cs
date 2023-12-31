using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace demo_yatirim
{
    public partial class settings : Form
    {
        public settings()
        {
            InitializeComponent();
        }
        internal bool bakiyeSifirlaKontrol;
        private void portfoySifirla()
        {
            FileStream fs = new FileStream("portfoy.txt", FileMode.Truncate, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write("");
            sw.Close();
            fs.Close();
        }

        private void portfoyReset_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Tüm portföyünüz sıfırlanacaktır.\nSadece portföy listeniz silinecektir.\nBunu yapmak istediğinize emin misiniz ?.", "SIFIRLAMA", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Stop);
            if (dr == DialogResult.Yes)
            {
                portfoySifirla();
                MessageBox.Show("Portföy listeniz başarıyla sıfırlandı");
                this.Close();
            }
            
        }

        private void bakiyeReset_Click(object sender, EventArgs e)
        {
            if (File.Exists("bakiye.txt"))
            {
                FileStream fs = new FileStream("bakiye.txt", FileMode.Truncate, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.Write("1000000");
                sw.Close();
                fs.Close();
                MessageBox.Show("Toplam bakiye Sıfırlandı");
                bakiyeSifirlaKontrol = true;
                this.Close();
            }
        }
    }
}
