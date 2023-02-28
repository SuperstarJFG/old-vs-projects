
namespace AltairRealtors
{
    partial class PropertyEditor
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
            this.dlgPicture = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cbxPropertyTypes = new System.Windows.Forms.ComboBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.cbxStates = new System.Windows.Forms.ComboBox();
            this.txtStories = new System.Windows.Forms.TextBox();
            this.txtYearBuilt = new System.Windows.Forms.TextBox();
            this.txtBedrooms = new System.Windows.Forms.TextBox();
            this.txtBathrooms = new System.Windows.Forms.TextBox();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.btnPicture = new System.Windows.Forms.Button();
            this.pbxPicture = new System.Windows.Forms.PictureBox();
            this.txtPropertyNumber = new System.Windows.Forms.TextBox();
            this.cbxConditions = new System.Windows.Forms.ComboBox();
            this.txtMarketValue = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // dlgPicture
            // 
            this.dlgPicture.DefaultExt = "jpg";
            this.dlgPicture.FileName = "openFileDialog1";
            this.dlgPicture.Filter = "JPEG Files (*.jpg,*.jpeg)|*.jpg";
            this.dlgPicture.Title = "Select House Picture";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "propety type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "city";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "zip code";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "year built";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "bedrooms";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "market value";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(414, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "property #";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(414, 109);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "state";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(414, 142);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "stories";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(414, 175);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "condition";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(414, 208);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 17);
            this.label13.TabIndex = 0;
            this.label13.Text = "bathrooms";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(414, 241);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 17);
            this.label14.TabIndex = 0;
            this.label14.Text = "sale status";
            // 
            // cbxPropertyTypes
            // 
            this.cbxPropertyTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPropertyTypes.FormattingEnabled = true;
            this.cbxPropertyTypes.Items.AddRange(new object[] {
            "Condominium",
            "Townhouse",
            "Single Family",
            "Unknown"});
            this.cbxPropertyTypes.Location = new System.Drawing.Point(152, 43);
            this.cbxPropertyTypes.Name = "cbxPropertyTypes";
            this.cbxPropertyTypes.Size = new System.Drawing.Size(232, 24);
            this.cbxPropertyTypes.TabIndex = 1;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(152, 106);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 22);
            this.txtCity.TabIndex = 2;
            // 
            // cbxStates
            // 
            this.cbxStates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStates.FormattingEnabled = true;
            this.cbxStates.Items.AddRange(new object[] {
            "AL",
            "AK",
            "AZ",
            "AR",
            "CA",
            "CO",
            "CT",
            "DE",
            "DC",
            "FL",
            "GA",
            "HI",
            "ID",
            "IL",
            "IN",
            "IA",
            "KS",
            "KY",
            "LA",
            "ME",
            "MD",
            "MA",
            "MI",
            "MN",
            "MS",
            "MO",
            "MT",
            "NE",
            "NV",
            "NH",
            "NJ",
            "NM",
            "NY",
            "NC",
            "ND",
            "OH",
            "OK",
            "OR",
            "PA",
            "RI",
            "SC",
            "SD",
            "TN",
            "TX",
            "UT",
            "VT",
            "VA",
            "WA",
            "WV",
            "WI",
            "WY"});
            this.cbxStates.Location = new System.Drawing.Point(498, 106);
            this.cbxStates.Name = "cbxStates";
            this.cbxStates.Size = new System.Drawing.Size(232, 24);
            this.cbxStates.TabIndex = 1;
            // 
            // txtStories
            // 
            this.txtStories.Location = new System.Drawing.Point(498, 142);
            this.txtStories.Name = "txtStories";
            this.txtStories.Size = new System.Drawing.Size(100, 22);
            this.txtStories.TabIndex = 2;
            // 
            // txtYearBuilt
            // 
            this.txtYearBuilt.Location = new System.Drawing.Point(152, 172);
            this.txtYearBuilt.Name = "txtYearBuilt";
            this.txtYearBuilt.Size = new System.Drawing.Size(100, 22);
            this.txtYearBuilt.TabIndex = 2;
            // 
            // txtBedrooms
            // 
            this.txtBedrooms.Location = new System.Drawing.Point(152, 208);
            this.txtBedrooms.Name = "txtBedrooms";
            this.txtBedrooms.Size = new System.Drawing.Size(100, 22);
            this.txtBedrooms.TabIndex = 2;
            this.txtBedrooms.Text = "0";
            // 
            // txtBathrooms
            // 
            this.txtBathrooms.Location = new System.Drawing.Point(498, 208);
            this.txtBathrooms.Name = "txtBathrooms";
            this.txtBathrooms.Size = new System.Drawing.Size(100, 22);
            this.txtBathrooms.TabIndex = 2;
            this.txtBathrooms.Text = "0.00";
            // 
            // cbxStatus
            // 
            this.cbxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Items.AddRange(new object[] {
            "Unspecified",
            "Available",
            "Sold"});
            this.cbxStatus.Location = new System.Drawing.Point(496, 238);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(232, 24);
            this.cbxStatus.TabIndex = 1;
            // 
            // btnPicture
            // 
            this.btnPicture.Location = new System.Drawing.Point(43, 347);
            this.btnPicture.Name = "btnPicture";
            this.btnPicture.Size = new System.Drawing.Size(75, 23);
            this.btnPicture.TabIndex = 3;
            this.btnPicture.Text = "Picture...";
            this.btnPicture.UseVisualStyleBackColor = true;
            this.btnPicture.Click += new System.EventHandler(this.btnPicture_Click);
            // 
            // pbxPicture
            // 
            this.pbxPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxPicture.Location = new System.Drawing.Point(165, 285);
            this.pbxPicture.Name = "pbxPicture";
            this.pbxPicture.Size = new System.Drawing.Size(563, 237);
            this.pbxPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxPicture.TabIndex = 4;
            this.pbxPicture.TabStop = false;
            // 
            // txtPropertyNumber
            // 
            this.txtPropertyNumber.Enabled = false;
            this.txtPropertyNumber.Location = new System.Drawing.Point(498, 45);
            this.txtPropertyNumber.Name = "txtPropertyNumber";
            this.txtPropertyNumber.Size = new System.Drawing.Size(100, 22);
            this.txtPropertyNumber.TabIndex = 2;
            // 
            // cbxConditions
            // 
            this.cbxConditions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxConditions.FormattingEnabled = true;
            this.cbxConditions.Items.AddRange(new object[] {
            "Excellent",
            "Good Shape",
            "Needs Fixing"});
            this.cbxConditions.Location = new System.Drawing.Point(498, 170);
            this.cbxConditions.Name = "cbxConditions";
            this.cbxConditions.Size = new System.Drawing.Size(232, 24);
            this.cbxConditions.TabIndex = 1;
            // 
            // txtMarketValue
            // 
            this.txtMarketValue.Location = new System.Drawing.Point(152, 241);
            this.txtMarketValue.Name = "txtMarketValue";
            this.txtMarketValue.Size = new System.Drawing.Size(100, 22);
            this.txtMarketValue.TabIndex = 2;
            this.txtMarketValue.Text = "0.00";
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(43, 427);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(43, 456);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // PropertyEditor
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(800, 534);
            this.Controls.Add(this.pbxPicture);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnPicture);
            this.Controls.Add(this.txtMarketValue);
            this.Controls.Add(this.txtBathrooms);
            this.Controls.Add(this.txtBedrooms);
            this.Controls.Add(this.txtYearBuilt);
            this.Controls.Add(this.txtPropertyNumber);
            this.Controls.Add(this.txtStories);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.cbxStatus);
            this.Controls.Add(this.cbxConditions);
            this.Controls.Add(this.cbxStates);
            this.Controls.Add(this.cbxPropertyTypes);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PropertyEditor";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Altair Realtors - Property Editor";
            this.Load += new System.EventHandler(this.PropertyEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog dlgPicture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.ComboBox cbxPropertyTypes;
        public System.Windows.Forms.TextBox txtCity;
        public System.Windows.Forms.ComboBox cbxStates;
        public System.Windows.Forms.TextBox txtStories;
        public System.Windows.Forms.TextBox txtYearBuilt;
        public System.Windows.Forms.TextBox txtBedrooms;
        public System.Windows.Forms.TextBox txtBathrooms;
        public System.Windows.Forms.ComboBox cbxStatus;
        private System.Windows.Forms.Button btnPicture;
        private System.Windows.Forms.PictureBox pbxPicture;
        public System.Windows.Forms.TextBox txtPropertyNumber;
        public System.Windows.Forms.ComboBox cbxConditions;
        public System.Windows.Forms.TextBox txtMarketValue;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}