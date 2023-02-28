using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AltairRealtors
{
    public partial class PropertyEditor : Form
    {
        public string pictureFile;

        public PropertyEditor()
        {
            InitializeComponent();
        }

        private void PropertyEditor_Load(object sender, EventArgs e)
        {
            pictureFile = "";
        }

        private void btnPicture_Click(object sender, EventArgs e)
        {
            if (dlgPicture.ShowDialog() == DialogResult.OK)
            {
                pbxPicture.Image = Image.FromFile(dlgPicture.FileName);
                pictureFile = dlgPicture.FileName;
            }
        }
    }
}