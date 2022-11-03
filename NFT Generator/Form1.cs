using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NFT_Generator
{
    public partial class NFTGeneratorComponentsForm : Form
    {
        //Variables

        //Int 32
        public static int Quantity;

        //Bool
        public static bool isHats = false;
        public static bool isNecklaces = false;
        public static bool isSunglasses = false;
        public static bool isBGImage = false;

        //String

        //Body Location
        public static string BodyLocation = null;

        //List

        //Colors Location
        public static List<string> ColorsCommonLocation = null;
        public static List<string> ColorsRareLocation = null;
        public static List<string> ColorsEpicLocation = null;
        public static List<string> ColorsLegendaryLocation = null;

        //BG Image Location
        public static List<string> BGCommonLocation = null;
        public static List<string> BGRareLocation = null;
        public static List<string> BGEpicLocation = null;
        public static List<string> BGLegendaryLocation = null;

        //Hats Location
        public static List<string> HatsCommonLocation = null;
        public static List<string> HatsRareLocation = null;
        public static List<string> HatsEpicLocation = null;
        public static List<string> HatsLegendaryLocation = null;

        //Necklaces Location
        public static List<string> NecklacesCommonLocation = null;
        public static List<string> NecklacesRareLocation = null;
        public static List<string> NecklacesEpicLocation = null;
        public static List<string> NecklacesLegendaryLocation = null;

        //Sunglasses Location
        public static List<string> SunglassesCommonLocation = null;
        public static List<string> SunglassesRareLocation = null;
        public static List<string> SunglassesEpicLocation = null;
        public static List<string> SunglassesLegendaryLocation = null;

        public NFTGeneratorComponentsForm()
        {
            InitializeComponent();
        }

        //Generate
        private void btn_Generate_Click(object sender, EventArgs e)
        {
            isHats = false;
            isNecklaces = false;
            isSunglasses = false;
            isBGImage = false;

            if (checkBox_Hats.Checked == true)
            {
                isHats = true;
            }

            if (checkBox_Necklaces.Checked == true)
            {
                isNecklaces = true;
            }

            if (checkBox_Sunglasses.Checked == true)
            {
                isSunglasses = true;
            }

            if (checkBox_BGImage.Checked == true)
            {
                isBGImage = true;
            }

            try
            {
                Quantity = Int32.Parse(txtBox_Quantity.Text);

                if (BodyLocation == null)
                {
                    MessageBox.Show("Generation Failed, you didn't upload the Body", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //Mettere L'obbligo dei Colors

                if (isHats == true)
                {
                    if (HatsCommonLocation == null)
                    {
                        MessageBox.Show("Generation Failed, you didn't upload the Hats", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (HatsRareLocation == null)
                    {
                        MessageBox.Show("Generation Failed, you didn't upload the Hats", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (HatsEpicLocation == null)
                    {
                        MessageBox.Show("Generation Failed, you didn't upload the Hats", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (HatsLegendaryLocation == null)
                    {
                        MessageBox.Show("Generation Failed, you didn't upload the Hats", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                if (isNecklaces == true)
                {
                    if (NecklacesCommonLocation == null)
                    {
                        MessageBox.Show("Generation Failed, you didn't upload the Necklaces", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (NecklacesRareLocation == null)
                    {
                        MessageBox.Show("Generation Failed, you didn't upload the Necklaces", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (NecklacesEpicLocation == null)
                    {
                        MessageBox.Show("Generation Failed, you didn't upload the Necklaces", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (NecklacesLegendaryLocation == null)
                    {
                        MessageBox.Show("Generation Failed, you didn't upload the Necklaces", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                if (isSunglasses == true)
                {
                    if (SunglassesCommonLocation == null)
                    {
                        MessageBox.Show("Generation Failed, you didn't upload the Sunglasses", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (SunglassesRareLocation == null)
                    {
                        MessageBox.Show("Generation Failed, you didn't upload the Sunglasses", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (SunglassesEpicLocation == null)
                    {
                        MessageBox.Show("Generation Failed, you didn't upload the Sunglasses", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (SunglassesLegendaryLocation == null)
                    {
                        MessageBox.Show("Generation Failed, you didn't upload the Sunglasses", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                if (isBGImage == true)
                {
                    if (BGCommonLocation == null)
                    {
                        MessageBox.Show("Generation Failed, you didn't upload the BG Image", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (BGRareLocation == null)
                    {
                        MessageBox.Show("Generation Failed, you didn't upload the BG Image", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (BGEpicLocation == null)
                    {
                        MessageBox.Show("Generation Failed, you didn't upload the BG Image", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (BGLegendaryLocation == null)
                    {
                        MessageBox.Show("Generation Failed, you didn't upload the BG Image", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            catch
            {
                MessageBox.Show("Generation Failed, check if you upload everything or if the quantity is right...", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            NFTGenerationForm generationForm = new NFTGenerationForm();

            generationForm.Show();

            /*
            //Body Location
            BodyLocation = null;

            //Colors Location
            ColorsCommonLocation = null;
            ColorsRareLocation = null;
            ColorsEpicLocation = null;
            ColorsLegendaryLocation = null;

            //BG Image Location
            BGCommonLocation = null;
            BGRareLocation = null;
            BGEpicLocation = null;
            BGLegendaryLocation = null;

            //Hats Location
            HatsCommonLocation = null;
            HatsRareLocation = null;
            HatsEpicLocation = null;
            HatsLegendaryLocation = null;

            //Necklaces Location
            NecklacesCommonLocation = null;
            NecklacesRareLocation = null;
            NecklacesEpicLocation = null;
            NecklacesLegendaryLocation = null;

            //Sunglasses Location
            SunglassesCommonLocation = null;
            SunglassesRareLocation = null;
            SunglassesEpicLocation = null;
            SunglassesLegendaryLocation = null;
            */
        }

        //Body
        private void btn_Bodylocation_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Filter = "PNG Files(*.png) | *.png"; 
            dialog.Multiselect = false; 

            dialog.InitialDirectory = "C://Desktop";
  
            dialog.Title = "Select file to be upload.";

            dialog.FilterIndex = 1;
            try
            {
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (dialog.CheckFileExists)
                    {
                        BodyLocation = System.IO.Path.GetFullPath(dialog.FileName);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid image. Please select valid image.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Colors
        private void btn_ColorsCommonLocation_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Filter = "PNG Files(*.png) | *.png";
            dialog.Multiselect = true;

            dialog.InitialDirectory = "C://Desktop";

            dialog.Title = "Select file to be upload.";

            dialog.FilterIndex = 1;

            ColorsCommonLocation = new List<string> { };

            try
            {
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    foreach (string file in dialog.FileNames)
                    {
                        string path = System.IO.Path.GetFullPath(file);

                        ColorsCommonLocation.Add(path);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid image. Please select valid image.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_ColorsRareLocation_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Filter = "PNG Files(*.png) | *.png";
            dialog.Multiselect = true;

            dialog.InitialDirectory = "C://Desktop";

            dialog.Title = "Select file to be upload.";

            dialog.FilterIndex = 1;

            ColorsRareLocation = new List<string> { };

            try
            {
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    foreach (string file in dialog.FileNames)
                    {
                        string path = System.IO.Path.GetFullPath(file);

                        ColorsRareLocation.Add(path);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid image. Please select valid image.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_ColorsEpicLocation_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Filter = "PNG Files(*.png) | *.png";
            dialog.Multiselect = true;

            dialog.InitialDirectory = "C://Desktop";

            dialog.Title = "Select file to be upload.";

            dialog.FilterIndex = 1;

            ColorsEpicLocation = new List<string> { };

            try
            {
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    foreach (string file in dialog.FileNames)
                    {
                        string path = System.IO.Path.GetFullPath(file);

                        ColorsEpicLocation.Add(path);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid image. Please select valid image.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_ColorsLegendaryLocation_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Filter = "PNG Files(*.png) | *.png";
            dialog.Multiselect = true;

            dialog.InitialDirectory = "C://Desktop";

            dialog.Title = "Select file to be upload.";

            dialog.FilterIndex = 1;


            ColorsLegendaryLocation = new List<string> { };

            try
            {
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    foreach (string file in dialog.FileNames)
                    {
                        string path = System.IO.Path.GetFullPath(file);

                        ColorsLegendaryLocation.Add(path);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid image. Please select valid image.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //BG
        private void btn_BGCommonLocation_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Filter = "PNG Files(*.png) | *.png";
            dialog.Multiselect = true;

            dialog.InitialDirectory = "C://Desktop";

            dialog.Title = "Select file to be upload.";

            dialog.FilterIndex = 1;

            BGCommonLocation = new List<string> { };

            try
            {
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    foreach (string file in dialog.FileNames)
                    {
                        string path = System.IO.Path.GetFullPath(file);

                        BGCommonLocation.Add(path);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid image. Please select valid image.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_BGRareLocation_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Filter = "PNG Files(*.png) | *.png";
            dialog.Multiselect = true;

            dialog.InitialDirectory = "C://Desktop";

            dialog.Title = "Select file to be upload.";

            dialog.FilterIndex = 1;

            BGRareLocation = new List<string> { };

            try
            {
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    foreach (string file in dialog.FileNames)
                    {
                        string path = System.IO.Path.GetFullPath(file);

                        BGRareLocation.Add(path);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid image. Please select valid image.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_BGEpicLocation_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Filter = "PNG Files(*.png) | *.png";
            dialog.Multiselect = true;

            dialog.InitialDirectory = "C://Desktop";

            dialog.Title = "Select file to be upload.";

            dialog.FilterIndex = 1;

            BGEpicLocation = new List<string> { };

            try
            {
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    foreach (string file in dialog.FileNames)
                    {
                        string path = System.IO.Path.GetFullPath(file);

                        BGEpicLocation.Add(path);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid image. Please select valid image.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_BGLegendaryLocation_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Filter = "PNG Files(*.png) | *.png";
            dialog.Multiselect = true;

            dialog.InitialDirectory = "C://Desktop";

            dialog.Title = "Select file to be upload.";

            dialog.FilterIndex = 1;

            BGLegendaryLocation = new List<string> { };

            try
            {
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    foreach (string file in dialog.FileNames)
                    {
                        string path = System.IO.Path.GetFullPath(file);

                        BGLegendaryLocation.Add(path);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid image. Please select valid image.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Hats
        private void btn_HatsCommonLocation_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Filter = "PNG Files(*.png) | *.png";
            dialog.Multiselect = true;

            dialog.InitialDirectory = "C://Desktop";

            dialog.Title = "Select file to be upload.";

            dialog.FilterIndex = 1;

            HatsCommonLocation = new List<string> { };

            try
            {
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    foreach (string file in dialog.FileNames)
                    {
                        string path = System.IO.Path.GetFullPath(file);

                        HatsCommonLocation.Add(path);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid image. Please select valid image.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_HatsRareLocation_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Filter = "PNG Files(*.png) | *.png";
            dialog.Multiselect = true;

            dialog.InitialDirectory = "C://Desktop";

            dialog.Title = "Select file to be upload.";

            dialog.FilterIndex = 1;

            HatsRareLocation = new List<string> { };

            try
            {
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    foreach (string file in dialog.FileNames)
                    {
                        string path = System.IO.Path.GetFullPath(file);

                        HatsRareLocation.Add(path);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid image. Please select valid image.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_HatsEpicLocation_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Filter = "PNG Files(*.png) | *.png";
            dialog.Multiselect = true;

            dialog.InitialDirectory = "C://Desktop";

            dialog.Title = "Select file to be upload.";

            dialog.FilterIndex = 1;

            HatsEpicLocation = new List<string> { };

            try
            {
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    foreach (string file in dialog.FileNames)
                    {
                        string path = System.IO.Path.GetFullPath(file);

                        HatsEpicLocation.Add(path);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid image. Please select valid image.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_HatsLegendaryLocation_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Filter = "PNG Files(*.png) | *.png";
            dialog.Multiselect = true;

            dialog.InitialDirectory = "C://Desktop";

            dialog.Title = "Select file to be upload.";

            dialog.FilterIndex = 1;

            HatsLegendaryLocation = new List<string> { };

            try
            {
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    foreach (string file in dialog.FileNames)
                    {
                        string path = System.IO.Path.GetFullPath(file);

                        HatsLegendaryLocation.Add(path);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid image. Please select valid image.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Necklaces
        private void btn_NecklacesCommonLocation_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Filter = "PNG Files(*.png) | *.png";
            dialog.Multiselect = true;

            dialog.InitialDirectory = "C://Desktop";

            dialog.Title = "Select file to be upload.";

            dialog.FilterIndex = 1;

            NecklacesCommonLocation = new List<string> { };

            try
            {
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    foreach (string file in dialog.FileNames)
                    {
                        string path = System.IO.Path.GetFullPath(file);

                        NecklacesCommonLocation.Add(path);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid image. Please select valid image.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_NecklacesRareLocation_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Filter = "PNG Files(*.png) | *.png";
            dialog.Multiselect = true;

            dialog.InitialDirectory = "C://Desktop";

            dialog.Title = "Select file to be upload.";

            dialog.FilterIndex = 1;

            NecklacesRareLocation = new List<string> { };

            try
            {
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    foreach (string file in dialog.FileNames)
                    {
                        string path = System.IO.Path.GetFullPath(file);

                        NecklacesRareLocation.Add(path);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid image. Please select valid image.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_NecklacesEpicLocation_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Filter = "PNG Files(*.png) | *.png";
            dialog.Multiselect = true;

            dialog.InitialDirectory = "C://Desktop";

            dialog.Title = "Select file to be upload.";

            dialog.FilterIndex = 1;

            NecklacesEpicLocation = new List<string> { };

            try
            {
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    foreach (string file in dialog.FileNames)
                    {
                        string path = System.IO.Path.GetFullPath(file);

                        NecklacesEpicLocation.Add(path);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid image. Please select valid image.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_NecklacesLegendaryLocation_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Filter = "PNG Files(*.png) | *.png";
            dialog.Multiselect = true;

            dialog.InitialDirectory = "C://Desktop";

            dialog.Title = "Select file to be upload.";

            dialog.FilterIndex = 1;

            NecklacesLegendaryLocation = new List<string> { };

            try
            {
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    foreach (string file in dialog.FileNames)
                    {
                        string path = System.IO.Path.GetFullPath(file);

                        NecklacesLegendaryLocation.Add(path);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid image. Please select valid image.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Sunglasses
        private void btn_SunglassesCommonLocation_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Filter = "PNG Files(*.png) | *.png";
            dialog.Multiselect = true;

            dialog.InitialDirectory = "C://Desktop";

            dialog.Title = "Select file to be upload.";

            dialog.FilterIndex = 1;

            SunglassesCommonLocation = new List<string> { };

            try
            {
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    foreach (string file in dialog.FileNames)
                    {
                        string path = System.IO.Path.GetFullPath(file);

                        SunglassesCommonLocation.Add(path);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid image. Please select valid image.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_SunglassesRareLocation_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Filter = "PNG Files(*.png) | *.png";
            dialog.Multiselect = true;

            dialog.InitialDirectory = "C://Desktop";

            dialog.Title = "Select file to be upload.";

            dialog.FilterIndex = 1;

            SunglassesRareLocation = new List<string> { };

            try
            {
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    foreach (string file in dialog.FileNames)
                    {
                        string path = System.IO.Path.GetFullPath(file);

                        SunglassesRareLocation.Add(path);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid image. Please select valid image.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_SunglassesEpicLocation_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Filter = "PNG Files(*.png) | *.png";
            dialog.Multiselect = true;

            dialog.InitialDirectory = "C://Desktop";

            dialog.Title = "Select file to be upload.";

            dialog.FilterIndex = 1;

            SunglassesEpicLocation = new List<string> { };

            try
            {
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    foreach (string file in dialog.FileNames)
                    {
                        string path = System.IO.Path.GetFullPath(file);

                        SunglassesEpicLocation.Add(path);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid image. Please select valid image.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_SunglassesLegendaryLocation_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Filter = "PNG Files(*.png) | *.png";
            dialog.Multiselect = true;

            dialog.InitialDirectory = "C://Desktop";

            dialog.Title = "Select file to be upload.";

            dialog.FilterIndex = 1;

            SunglassesLegendaryLocation = new List<string> { };

            try
            {
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    foreach (string file in dialog.FileNames)
                    {
                        string path = System.IO.Path.GetFullPath(file);

                        SunglassesLegendaryLocation.Add(path);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid image. Please select valid image.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
