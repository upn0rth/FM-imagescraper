using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstaScraper
{
    public partial class UserControl1 : UserControl
    {
        private String imgUrl = "";
        private String title = "";
        private PictureBox pict = null;
        private Label label1 = null;

        public UserControl1()
        {
            InitializeComponent();
        }
        public UserControl1(String img, String title)
            : base()
        {
            imgUrl = img;
            this.title = title;

            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Name = "panel2";
            this.Size = new System.Drawing.Size(108, 117);

            // pictureBox
            this.pict = new PictureBox();
            this.pict.Image = new Bitmap(img);
            this.pict.Location = new System.Drawing.Point(3, 3);
            this.pict.Size = new System.Drawing.Size(100, 91);
            this.pict.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            // label
            this.label1 = new Label();
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 99);
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.Text = title;

            this.Controls.Add(this.label1);
            this.Controls.Add(this.pict);

            InitializeComponent();
        }

        public void setImageURL(String url)
        {
            this.imgUrl = url;
        }
        public void setTitle(String title)
        {
            this.title = title;
        }
    }
}