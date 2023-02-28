using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace AltairRealtors
{
    public partial class AltairRealtors : Form
    {
        List<RealEstateProperty> properties;

        public AltairRealtors()
        {
            InitializeComponent();
        }

        private void AltairRealtors_Load(object sender, EventArgs e)
        {
            properties = new List<RealEstateProperty>();
            ShowProperties();
        }

        private void ShowProperties()
        {
            // Get a reference to the file that holds the records of properties
            string Filename = @"C:\Altair Realtors\properties.atr";

            // Make sure the file exists
            if (File.Exists(Filename) == true)
            {
                // if so, create a file stream
                FileStream stmProperties = new FileStream(Filename,
                                                          FileMode.Open,
                                                          FileAccess.Read);
                // Create a binary formatter
                BinaryFormatter bfmProperty = new BinaryFormatter();
                // If some properties were created already,
                // get them and store them in the collection
                properties =
                    (List<RealEstateProperty>)bfmProperty.Deserialize(stmProperties);

                // First, empty the list view
                lvwProperties.Items.Clear();
                ListViewItem lviProperty = null;

                // Visit each property in the collection and add it to the list view
                foreach (RealEstateProperty house in properties)
                {
                    if (house.PropertyType.Equals("Condominium"))
                        lviProperty = new ListViewItem(house.PropertyNumber,
                                lvwProperties.Groups[0]);
                    else if (house.PropertyType.Equals("Townhouse"))
                        lviProperty = new ListViewItem(house.PropertyNumber,
                                lvwProperties.Groups[1]);
                    else // if (house.PropertyType.Equals("Single Family"))
                        lviProperty = new ListViewItem(house.PropertyNumber,
                                lvwProperties.Groups[2]);

                    lviProperty.SubItems.Add(house.City);
                    lviProperty.SubItems.Add(house.State);
                    lviProperty.SubItems.Add(house.Stories.ToString());
                    lviProperty.SubItems.Add(house.YearBuilt.ToString());
                    lviProperty.SubItems.Add(house.Bedrooms.ToString());
                    lviProperty.SubItems.Add(house.Bathrooms.ToString("F"));
                    lviProperty.SubItems.Add(house.Condition);
                    lviProperty.SubItems.Add(house.Status);
                    lviProperty.SubItems.Add(house.MarketValue.ToString());
                    lvwProperties.Items.Add(lviProperty);
                }

                // Close the file stream
                stmProperties.Close();
            }
        }

        private void btnNewProperty_Click(object sender, EventArgs e)
        {
            PropertyEditor editor = new PropertyEditor();

            Random rndNumber = new Random(DateTime.Now.Millisecond);
            int number1 = rndNumber.Next(100, 999);
            int number2 = rndNumber.Next(100, 999);
            string propNumber = number1 + "-" + number2;

            editor.txtPropertyNumber.Text = propNumber;

            // Check that the directory that contains the list of properties exists.
            // If it doesn't exist, create it
            DirectoryInfo dirInfo = Directory.CreateDirectory(@"C:\Altair Realtors");
            // Get a reference to the file that holds the properties
            string Filename = @"C:\Altair Realtors\properties.atr";

            // First check if the file was previously created
            if (File.Exists(Filename) == true)
            {
                // If the list of properties exists already,
                // get it and store it in a file stream
                FileStream stmProperties = new FileStream(Filename,
                                                          FileMode.Open,
                                                          FileAccess.Read);
                BinaryFormatter bfmProperty = new BinaryFormatter();
                // Store the list of properties in the collection
                properties = (List<RealEstateProperty>)bfmProperty.Deserialize(stmProperties);
                // Close the file stream
                stmProperties.Close();
            }

            if (editor.ShowDialog() == DialogResult.OK)
            {
                ListViewItem lviStoreItem =
                    new ListViewItem(editor.txtPropertyNumber.Text);
                RealEstateProperty prop = new RealEstateProperty();

                prop.PropertyNumber = editor.txtPropertyNumber.Text;
                prop.PropertyType = editor.cbxPropertyTypes.Text;
                prop.City = editor.txtCity.Text;
                prop.State = editor.cbxStates.Text;
                prop.Stories = short.Parse(editor.txtStories.Text);
                prop.YearBuilt = int.Parse(editor.txtYearBuilt.Text);
                prop.Bedrooms = short.Parse(editor.txtBedrooms.Text);
                prop.Bathrooms = float.Parse(editor.txtBathrooms.Text);
                prop.Condition = editor.cbxConditions.Text;
                prop.Status = editor.cbxStatus.Text;
                prop.MarketValue = double.Parse(editor.txtMarketValue.Text);
                if (!editor.pictureFile.Equals(""))
                {
                    FileInfo flePicture = new FileInfo(editor.pictureFile);
                    flePicture.CopyTo(@"C:\Altair Realtors\" +
                                      editor.txtPropertyNumber.Text +
                                      flePicture.Extension);
                    prop.PictureFile = @"C:\Altair Realtors\" +
                                      editor.txtPropertyNumber.Text +
                                      flePicture.Extension;
                }
                else
                    prop.PictureFile = @"C:\Altair Realtors\000-000.jpg";
                // Add the property in the collection
                properties.Add(prop);

                // Get a reference to the properties file
                string strFilename = dirInfo.FullName + "\\properties.atr";
                // Create a file stream to hold the list of properties
                FileStream stmProperties = new FileStream(strFilename,
                                                          FileMode.Create,
                                                          FileAccess.Write);
                BinaryFormatter bfmProperty = new BinaryFormatter();

                // Serialize the list of properties
                bfmProperty.Serialize(stmProperties, properties);
                // Close the file stream
                stmProperties.Close();

                // Show the list of properties
                ShowProperties();
            }
        }

        private void btnLargeIcons_Click(object sender, EventArgs e)
        {
            lvwProperties.View = View.LargeIcon;
        }

        private void btnSmallIcons_Click(object sender, EventArgs e)
        {
            lvwProperties.View = View.SmallIcon;
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            lvwProperties.View = View.List;
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            lvwProperties.View = View.Details;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lvwProperties_ItemSelectionChanged(object sender,
            ListViewItemSelectionChangedEventArgs e)
        {
            RealEstateProperty currentProperty = new RealEstateProperty();

            foreach (RealEstateProperty prop in properties)
            {
                if (prop.PropertyNumber.Equals(e.Item.SubItems[0].Text))
                    pbxPicture.Image = Image.FromFile(prop.PictureFile);
            }
        }
    }
}