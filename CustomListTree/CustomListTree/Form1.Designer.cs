
namespace CustomListTree
{
    partial class PokeDex
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PokeDex));
            this.listView1 = new System.Windows.Forms.ListView();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(410, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(378, 426);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // treeView1
            // 
            this.treeView1.ImageKey = "die_cast_poke_ball_replica.jpg";
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(392, 426);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "diglett (1).png");
            this.imageList1.Images.SetKeyName(1, "gastly.png");
            this.imageList1.Images.SetKeyName(2, "eevee-f.png");
            this.imageList1.Images.SetKeyName(3, "chikorita.png");
            this.imageList1.Images.SetKeyName(4, "cyndaquil.png");
            this.imageList1.Images.SetKeyName(5, "totodile.png");
            this.imageList1.Images.SetKeyName(6, "die_cast_poke_ball_replica.jpg");
            this.imageList1.Images.SetKeyName(7, "Icon_Ground.png");
            this.imageList1.Images.SetKeyName(8, "Icon_Ghost.png");
            this.imageList1.Images.SetKeyName(9, "Icon_Normal.png");
            this.imageList1.Images.SetKeyName(10, "Icon_Grass.png");
            this.imageList1.Images.SetKeyName(11, "Icon_Fire.png");
            this.imageList1.Images.SetKeyName(12, "Icon_Water.png");
            this.imageList1.Images.SetKeyName(13, "haunter.png");
            this.imageList1.Images.SetKeyName(14, "gengar.png");
            // 
            // PokeDex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.listView1);
            this.Name = "PokeDex";
            this.Text = "PokeDex";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ImageList imageList1;
    }
}

