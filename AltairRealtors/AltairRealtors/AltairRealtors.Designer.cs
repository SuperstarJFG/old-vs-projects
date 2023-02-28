
namespace AltairRealtors
{
    partial class AltairRealtors
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Condominium", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Townhouse", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Single Family", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "987-609",
            "Rockville",
            "MD",
            "2",
            "1988",
            "3",
            "2.5",
            "Excellent",
            "Available",
            "465580"}, 2);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltairRealtors));
            this.lvwProperties = new System.Windows.Forms.ListView();
            this.colPropertyNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colState = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStories = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnYearBuilt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBedrooms = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBathrooms = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCondition = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMarketValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imgLarge = new System.Windows.Forms.ImageList(this.components);
            this.imgSmall = new System.Windows.Forms.ImageList(this.components);
            this.pbxPicture = new System.Windows.Forms.PictureBox();
            this.btnNewProperty = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnLargeIcons = new System.Windows.Forms.Button();
            this.btnSmallIcons = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.btnDetails = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // lvwProperties
            // 
            this.lvwProperties.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwProperties.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colPropertyNumber,
            this.colCity,
            this.colState,
            this.colStories,
            this.columnYearBuilt,
            this.colBedrooms,
            this.colBathrooms,
            this.colCondition,
            this.colStatus,
            this.colMarketValue});
            this.lvwProperties.FullRowSelect = true;
            this.lvwProperties.GridLines = true;
            listViewGroup1.Header = "Condominium";
            listViewGroup1.Name = "Condominium";
            listViewGroup2.Header = "Townhouse";
            listViewGroup2.Name = "Townhouse";
            listViewGroup3.Header = "Single Family";
            listViewGroup3.Name = "SingleFamily";
            this.lvwProperties.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3});
            this.lvwProperties.HideSelection = false;
            this.lvwProperties.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lvwProperties.LargeImageList = this.imgLarge;
            this.lvwProperties.Location = new System.Drawing.Point(12, 12);
            this.lvwProperties.Name = "lvwProperties";
            this.lvwProperties.Size = new System.Drawing.Size(1019, 219);
            this.lvwProperties.SmallImageList = this.imgSmall;
            this.lvwProperties.TabIndex = 0;
            this.lvwProperties.UseCompatibleStateImageBehavior = false;
            this.lvwProperties.View = System.Windows.Forms.View.Details;
            this.lvwProperties.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvwProperties_ItemSelectionChanged);
            // 
            // colPropertyNumber
            // 
            this.colPropertyNumber.Text = "Property #";
            this.colPropertyNumber.Width = 70;
            // 
            // colCity
            // 
            this.colCity.Text = "City";
            this.colCity.Width = 80;
            // 
            // colState
            // 
            this.colState.Text = "State";
            this.colState.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colState.Width = 80;
            // 
            // colStories
            // 
            this.colStories.Text = "Stories";
            this.colStories.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colStories.Width = 44;
            // 
            // columnYearBuilt
            // 
            this.columnYearBuilt.Text = "Year Built";
            this.columnYearBuilt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // colBedrooms
            // 
            this.colBedrooms.Text = "Beds";
            this.colBedrooms.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colBedrooms.Width = 40;
            // 
            // colBathrooms
            // 
            this.colBathrooms.Text = "Baths";
            this.colBathrooms.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colBathrooms.Width = 40;
            // 
            // colCondition
            // 
            this.colCondition.Text = "Condition";
            this.colCondition.Width = 70;
            // 
            // colStatus
            // 
            this.colStatus.Text = "Status";
            // 
            // colMarketValue
            // 
            this.colMarketValue.Text = "Value";
            this.colMarketValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // imgLarge
            // 
            this.imgLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgLarge.ImageStream")));
            this.imgLarge.TransparentColor = System.Drawing.Color.Transparent;
            this.imgLarge.Images.SetKeyName(0, "Condominium.png");
            this.imgLarge.Images.SetKeyName(1, "Townhouse.png");
            this.imgLarge.Images.SetKeyName(2, "SingleFamily.png");
            this.imgLarge.Images.SetKeyName(3, "Townhouse.ico");
            this.imgLarge.Images.SetKeyName(4, "SingleFamily.ico");
            this.imgLarge.Images.SetKeyName(5, "Condominium.ico");
            // 
            // imgSmall
            // 
            this.imgSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgSmall.ImageStream")));
            this.imgSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.imgSmall.Images.SetKeyName(0, "Condominium.png");
            this.imgSmall.Images.SetKeyName(1, "Townhouse.png");
            this.imgSmall.Images.SetKeyName(2, "SingleFamily.png");
            this.imgSmall.Images.SetKeyName(3, "Condominium.ico");
            this.imgSmall.Images.SetKeyName(4, "Townhouse.ico");
            this.imgSmall.Images.SetKeyName(5, "SingleFamily.ico");
            // 
            // pbxPicture
            // 
            this.pbxPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxPicture.Location = new System.Drawing.Point(12, 293);
            this.pbxPicture.Name = "pbxPicture";
            this.pbxPicture.Size = new System.Drawing.Size(1019, 237);
            this.pbxPicture.TabIndex = 1;
            this.pbxPicture.TabStop = false;
            // 
            // btnNewProperty
            // 
            this.btnNewProperty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNewProperty.Location = new System.Drawing.Point(24, 551);
            this.btnNewProperty.Name = "btnNewProperty";
            this.btnNewProperty.Size = new System.Drawing.Size(129, 23);
            this.btnNewProperty.TabIndex = 2;
            this.btnNewProperty.Text = "New Property...";
            this.btnNewProperty.UseVisualStyleBackColor = true;
            this.btnNewProperty.Click += new System.EventHandler(this.btnNewProperty_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(902, 551);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(129, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnLargeIcons
            // 
            this.btnLargeIcons.Image = ((System.Drawing.Image)(resources.GetObject("btnLargeIcons.Image")));
            this.btnLargeIcons.Location = new System.Drawing.Point(362, 234);
            this.btnLargeIcons.Name = "btnLargeIcons";
            this.btnLargeIcons.Size = new System.Drawing.Size(75, 54);
            this.btnLargeIcons.TabIndex = 3;
            this.btnLargeIcons.UseVisualStyleBackColor = true;
            this.btnLargeIcons.Click += new System.EventHandler(this.btnLargeIcons_Click);
            // 
            // btnSmallIcons
            // 
            this.btnSmallIcons.Image = ((System.Drawing.Image)(resources.GetObject("btnSmallIcons.Image")));
            this.btnSmallIcons.Location = new System.Drawing.Point(443, 234);
            this.btnSmallIcons.Name = "btnSmallIcons";
            this.btnSmallIcons.Size = new System.Drawing.Size(75, 54);
            this.btnSmallIcons.TabIndex = 3;
            this.btnSmallIcons.UseVisualStyleBackColor = true;
            this.btnSmallIcons.Click += new System.EventHandler(this.btnSmallIcons_Click);
            // 
            // btnList
            // 
            this.btnList.Image = ((System.Drawing.Image)(resources.GetObject("btnList.Image")));
            this.btnList.Location = new System.Drawing.Point(524, 234);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(75, 54);
            this.btnList.TabIndex = 3;
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnDetails
            // 
            this.btnDetails.Image = ((System.Drawing.Image)(resources.GetObject("btnDetails.Image")));
            this.btnDetails.Location = new System.Drawing.Point(605, 234);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(75, 54);
            this.btnDetails.TabIndex = 3;
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // AltairRealtors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 595);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnSmallIcons);
            this.Controls.Add(this.btnLargeIcons);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnNewProperty);
            this.Controls.Add(this.pbxPicture);
            this.Controls.Add(this.lvwProperties);
            this.Name = "AltairRealtors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Altair Realtors - Properties Listing";
            ((System.ComponentModel.ISupportInitialize)(this.pbxPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvwProperties;
        private System.Windows.Forms.PictureBox pbxPicture;
        private System.Windows.Forms.Button btnNewProperty;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnLargeIcons;
        private System.Windows.Forms.Button btnSmallIcons;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.ImageList imgLarge;
        private System.Windows.Forms.ImageList imgSmall;
        private System.Windows.Forms.ColumnHeader colPropertyNumber;
        private System.Windows.Forms.ColumnHeader colCity;
        private System.Windows.Forms.ColumnHeader colState;
        private System.Windows.Forms.ColumnHeader colStories;
        private System.Windows.Forms.ColumnHeader columnYearBuilt;
        private System.Windows.Forms.ColumnHeader colBedrooms;
        private System.Windows.Forms.ColumnHeader colBathrooms;
        private System.Windows.Forms.ColumnHeader colCondition;
        private System.Windows.Forms.ColumnHeader colStatus;
        private System.Windows.Forms.ColumnHeader colMarketValue;
    }
}

