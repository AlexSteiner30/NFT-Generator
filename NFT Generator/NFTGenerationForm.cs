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
    public partial class NFTGenerationForm : Form
    {

        //Variables

        //Int
        public int HatGenerationX = 100000000;
        public int HatGenerationY = 100000000;

        public int NecklacesGenerationX = 100000000;
        public int NecklacesGenerationY = 100000000;

        public int SunglassesGenerationX = 100000000;
        public int SunglassesGenerationY = 100000000;

        //String
        public string GenerationLocation = null;

        //List
        public List<string> RarityList = new List<string> {"Common", "Common", "Common", "Common", "Rare", "Rare", "Epic", "Legendary"};

        public NFTGenerationForm()
        {
            InitializeComponent();

            panel_NFTAncor.BackgroundImage = Image.FromFile(NFTGeneratorComponentsForm.BodyLocation);

            panel_Colors.Visible = false;
            panel1.Visible = false;
            panel2.Visible = false;
            panel_Hats.Visible = false;
            panel_Necklaces.Visible = false;
            panel_Sunglasses.Visible = false;
        }

        private void btnLocation_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog location = new FolderBrowserDialog();

            location.ShowDialog();

            try
            {
                GenerationLocation = location.SelectedPath;
                txtBoxLocation.Text = GenerationLocation;
            }

            catch
            {
                MessageBox.Show("Invalid path. Please select valid path.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void panel_NFTAncor_Click(object sender, EventArgs e)
        {
            if (checkBox_Hats.Checked == true)
            {
                checkBox_Necklaces.Checked = false;
                checkBox_Sunglasses.Checked = false;

                Point point = panel_NFTAncor.PointToClient(Cursor.Position);
                MessageBox.Show(point.ToString(), "Hats");

                HatGenerationX = point.X;
                HatGenerationY = point.Y;
            }

            if (checkBox_Necklaces.Checked == true)
            {
                checkBox_Hats.Checked = false;
                checkBox_Sunglasses.Checked = false;

                Point point = panel_NFTAncor.PointToClient(Cursor.Position);
                MessageBox.Show(point.ToString(), "Necklaces");

                NecklacesGenerationX = point.X;
                NecklacesGenerationY = point.Y;
            }

            if (checkBox_Sunglasses.Checked == true)
            {
                checkBox_Necklaces.Checked = false;
                checkBox_Hats.Checked = false;

                Point point = panel_NFTAncor.PointToClient(Cursor.Position);
                MessageBox.Show(point.ToString(), "Sunglasses");

                SunglassesGenerationX = point.X;
                SunglassesGenerationY = point.Y;
            }
        }

        private void btn_Generate_Click(object sender, EventArgs e)
        {
            Generate();
        }

        void Generate()
        {
            panel_NFTAncor.BackgroundImage = null;
            panel_Colors.Visible = true;
            panel1.Visible = true;
            panel2.Visible = false;
            btn_Generate.Enabled = false;

            if (NFTGeneratorComponentsForm.isHats)
            {
                panel_Hats.Visible = true;
            }

            else
            {
                panel_Hats.Visible = false;
            }

            if (NFTGeneratorComponentsForm.isNecklaces)
            {
                panel_Necklaces.Visible = true;
            }

            else
            {
                panel_Necklaces.Visible = false;
            }

            if (NFTGeneratorComponentsForm.isSunglasses)
            {
                panel_Sunglasses.Visible = true;
            }

            else
            {
                panel_Sunglasses.Visible = false;
            }



            //Set UP
            panel_Colors.Controls.Add(panel1);
            panel1.Controls.Add(panel2);


            int x = 0;

            while (x != NFTGeneratorComponentsForm.Quantity)
            {
                Random rnd = new Random();

                Color randomColorBG = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));

                panel_NFTAncor.BackColor = randomColorBG;

                var random = new Random();
                var randomColor = new Random();
                var randomHats = new Random();

                int ListItemNumber = random.Next(RarityList.Count);
                int ColorInt;

                int ListItemNumberHats = randomHats.Next(RarityList.Count);
                int HatsInt;

                switch (ListItemNumber)
                {
                    case 0:

                        ColorInt = random.Next(NFTGeneratorComponentsForm.ColorsCommonLocation.Count);

                        panel_Colors.BackgroundImage = Image.FromFile(NFTGeneratorComponentsForm.ColorsCommonLocation[ColorInt]);
                        panel_NFTAncor.Controls.Add(panel_Colors);

                        break;

                    case 1:
                        ColorInt = random.Next(NFTGeneratorComponentsForm.ColorsCommonLocation.Count);

                        panel_Colors.BackgroundImage = Image.FromFile(NFTGeneratorComponentsForm.ColorsCommonLocation[ColorInt]);
                        panel_NFTAncor.Controls.Add(panel_Colors);

                        break;

                    case 2:
                        ColorInt = random.Next(NFTGeneratorComponentsForm.ColorsCommonLocation.Count);

                        panel_Colors.BackgroundImage = Image.FromFile(NFTGeneratorComponentsForm.ColorsCommonLocation[ColorInt]);
                        panel_NFTAncor.Controls.Add(panel_Colors);

                        break;

                    case 3:
                        ColorInt = random.Next(NFTGeneratorComponentsForm.ColorsCommonLocation.Count);

                        panel_Colors.BackgroundImage = Image.FromFile(NFTGeneratorComponentsForm.ColorsCommonLocation[ColorInt]);
                        panel_NFTAncor.Controls.Add(panel_Colors);

                        break;

                    case 4:
                        ColorInt = random.Next(NFTGeneratorComponentsForm.ColorsRareLocation.Count);

                        panel_Colors.BackgroundImage = Image.FromFile(NFTGeneratorComponentsForm.ColorsRareLocation[ColorInt]);
                        panel_NFTAncor.Controls.Add(panel_Colors);

                        break;

                    case 5:
                        ColorInt = random.Next(NFTGeneratorComponentsForm.ColorsRareLocation.Count);

                        panel_Colors.BackgroundImage = Image.FromFile(NFTGeneratorComponentsForm.ColorsRareLocation[ColorInt]);
                        panel_NFTAncor.Controls.Add(panel_Colors);

                        break;

                    case 6:
                        ColorInt = random.Next(NFTGeneratorComponentsForm.ColorsCommonLocation.Count);

                        panel_Colors.BackgroundImage = Image.FromFile(NFTGeneratorComponentsForm.ColorsRareLocation[ColorInt]);
                        panel_NFTAncor.Controls.Add(panel_Colors);

                        break;

                    case 7:
                        ColorInt = random.Next(NFTGeneratorComponentsForm.ColorsEpicLocation.Count);

                        panel_Colors.BackgroundImage = Image.FromFile(NFTGeneratorComponentsForm.ColorsEpicLocation[ColorInt]);
                        panel_NFTAncor.Controls.Add(panel_Colors);

                        break;

                    case 8:
                        ColorInt = random.Next(NFTGeneratorComponentsForm.ColorsEpicLocation.Count);

                        panel_Colors.BackgroundImage = Image.FromFile(NFTGeneratorComponentsForm.ColorsEpicLocation[ColorInt]);
                        panel_NFTAncor.Controls.Add(panel_Colors);

                        break;

                    case 9:
                        ColorInt = random.Next(NFTGeneratorComponentsForm.ColorsLegendaryLocation.Count);

                        panel_Colors.BackgroundImage = Image.FromFile(NFTGeneratorComponentsForm.ColorsLegendaryLocation[ColorInt]);
                        panel_NFTAncor.Controls.Add(panel_Colors);

                        break;
                }

                //Body
                panel1.BackgroundImage = Image.FromFile(NFTGeneratorComponentsForm.BodyLocation);

                //Hats
                if (HatGenerationX != 100000000)
                {
                    Image Hats = null;
                    Bitmap HatsResize = null;

                    int EffPosX = 0;
                    int EffPosY = 0;

                    switch (ListItemNumberHats)
                    {
                        case 0:

                            HatsInt = random.Next(NFTGeneratorComponentsForm.HatsCommonLocation.Count);

                            Hats = Image.FromFile(NFTGeneratorComponentsForm.HatsCommonLocation[HatsInt]);

                            if (Hats.Width >= 250)
                            {
                                HatsResize = new Bitmap(Hats, new Size(Hats.Width / 2, Hats.Height / 2));
                            }

                            panel_Hats.Width = HatsResize.Width;
                            panel_Hats.Height = HatsResize.Height;

                            panel_Hats.BackgroundImage = HatsResize;
                            panel2.Controls.Add(panel_Hats);

                            EffPosX = HatsResize.Width / 2;
                            EffPosY = HatsResize.Height / 2;

                            panel_Hats.Location = new Point(HatGenerationX - EffPosX, HatGenerationY - EffPosY);

                            break;

                        case 1:
                            HatsInt = random.Next(NFTGeneratorComponentsForm.HatsCommonLocation.Count);

                            Hats = Image.FromFile(NFTGeneratorComponentsForm.HatsCommonLocation[HatsInt]);

                            if (Hats.Width >= 250)
                            {
                                HatsResize = new Bitmap(Hats, new Size(Hats.Width / 2, Hats.Height / 2));
                            }

                            panel_Hats.Width = HatsResize.Width;
                            panel_Hats.Height = HatsResize.Height;

                            panel_Hats.BackgroundImage = HatsResize;
                            panel2.Controls.Add(panel_Hats);

                            EffPosX = HatsResize.Width / 2;
                            EffPosY = HatsResize.Height / 2;

                            panel_Hats.Location = new Point(HatGenerationX - EffPosX, HatGenerationY - EffPosY);

                            break;

                        case 2:
                            HatsInt = random.Next(NFTGeneratorComponentsForm.HatsCommonLocation.Count);

                            Hats = Image.FromFile(NFTGeneratorComponentsForm.HatsCommonLocation[HatsInt]);

                            if (Hats.Width >= 250)
                            {
                                HatsResize = new Bitmap(Hats, new Size(Hats.Width / 2, Hats.Height / 2));
                            }

                            panel_Hats.Width = HatsResize.Width;
                            panel_Hats.Height = HatsResize.Height;

                            panel_Hats.BackgroundImage = HatsResize;
                            panel2.Controls.Add(panel_Hats);

                            EffPosX = HatsResize.Width / 2;
                            EffPosY = HatsResize.Height / 2;

                            panel_Hats.Location = new Point(HatGenerationX - EffPosX, HatGenerationY - EffPosY);

                            break;

                        case 3:
                            HatsInt = random.Next(NFTGeneratorComponentsForm.HatsCommonLocation.Count);

                            Hats = Image.FromFile(NFTGeneratorComponentsForm.HatsCommonLocation[HatsInt]);

                            if (Hats.Width >= 250)
                            {
                                HatsResize = new Bitmap(Hats, new Size(Hats.Width / 2, Hats.Height / 2));
                            }

                            panel_Hats.Width = HatsResize.Width;
                            panel_Hats.Height = HatsResize.Height;

                            panel_Hats.BackgroundImage = HatsResize;
                            panel2.Controls.Add(panel_Hats);

                            EffPosX = HatsResize.Width / 2;
                            EffPosY = HatsResize.Height / 2;

                            panel_Hats.Location = new Point(HatGenerationX - EffPosX, HatGenerationY - EffPosY);

                            break;

                        case 4:
                            HatsInt = random.Next(NFTGeneratorComponentsForm.HatsRareLocation.Count);

                            Hats = Image.FromFile(NFTGeneratorComponentsForm.HatsRareLocation[HatsInt]);

                            if (Hats.Width >= 250)
                            {
                                HatsResize = new Bitmap(Hats, new Size(Hats.Width / 2, Hats.Height / 2));
                            }

                            panel_Hats.Width = HatsResize.Width;
                            panel_Hats.Height = HatsResize.Height;

                            panel_Hats.BackgroundImage = HatsResize;
                            panel2.Controls.Add(panel_Hats);

                            EffPosX = HatsResize.Width / 2;
                            EffPosY = HatsResize.Height / 2;

                            panel_Hats.Location = new Point(HatGenerationX - EffPosX, HatGenerationY - EffPosY);

                            break;

                        case 5:
                            HatsInt = random.Next(NFTGeneratorComponentsForm.HatsRareLocation.Count);

                            Hats = Image.FromFile(NFTGeneratorComponentsForm.HatsRareLocation[HatsInt]);

                            if (Hats.Width >= 250)
                            {
                                HatsResize = new Bitmap(Hats, new Size(Hats.Width / 2, Hats.Height / 2));
                            }

                            panel_Hats.Width = HatsResize.Width;
                            panel_Hats.Height = HatsResize.Height;

                            panel_Hats.BackgroundImage = HatsResize;
                            panel2.Controls.Add(panel_Hats);

                            EffPosX = HatsResize.Width / 2;
                            EffPosY = HatsResize.Height / 2;

                            panel_Hats.Location = new Point(HatGenerationX - EffPosX, HatGenerationY - EffPosY);

                            break;

                        case 6:
                            HatsInt = random.Next(NFTGeneratorComponentsForm.HatsRareLocation.Count);

                            Hats = Image.FromFile(NFTGeneratorComponentsForm.HatsRareLocation[HatsInt]);

                            if (Hats.Width >= 250)
                            {
                                HatsResize = new Bitmap(Hats, new Size(Hats.Width / 2, Hats.Height / 2));
                            }

                            panel_Hats.Width = HatsResize.Width;
                            panel_Hats.Height = HatsResize.Height;

                            panel_Hats.BackgroundImage = HatsResize;
                            panel2.Controls.Add(panel_Hats);

                            EffPosX = HatsResize.Width / 2;
                            EffPosY = HatsResize.Height / 2;

                            panel_Hats.Location = new Point(HatGenerationX - EffPosX, HatGenerationY - EffPosY);

                            break;

                        case 7:
                            HatsInt = random.Next(NFTGeneratorComponentsForm.HatsEpicLocation.Count);

                            Hats = Image.FromFile(NFTGeneratorComponentsForm.HatsEpicLocation[HatsInt]);

                            if (Hats.Width >= 250)
                            {
                                HatsResize = new Bitmap(Hats, new Size(Hats.Width / 2, Hats.Height / 2));
                            }

                            panel_Hats.Width = HatsResize.Width;
                            panel_Hats.Height = HatsResize.Height;

                            panel_Hats.BackgroundImage = HatsResize;
                            panel2.Controls.Add(panel_Hats);

                            EffPosX = HatsResize.Width / 2;
                            EffPosY = HatsResize.Height / 2;

                            panel_Hats.Location = new Point(HatGenerationX - EffPosX, HatGenerationY - EffPosY);

                            break;

                        case 8:
                            HatsInt = random.Next(NFTGeneratorComponentsForm.HatsEpicLocation.Count);

                            Hats = Image.FromFile(NFTGeneratorComponentsForm.HatsEpicLocation[HatsInt]);

                            if (Hats.Width >= 250)
                            {
                                HatsResize = new Bitmap(Hats, new Size(Hats.Width / 2, Hats.Height / 2));
                            }

                            panel_Hats.Width = HatsResize.Width;
                            panel_Hats.Height = HatsResize.Height;

                            panel_Hats.BackgroundImage = HatsResize;
                            panel2.Controls.Add(panel_Hats);

                            EffPosX = HatsResize.Width / 2;
                            EffPosY = HatsResize.Height / 2;

                            panel_Hats.Location = new Point(HatGenerationX - EffPosX, HatGenerationY - EffPosY);

                            break;

                        case 9:
                            HatsInt = random.Next(NFTGeneratorComponentsForm.HatsLegendaryLocation.Count);

                            Hats = Image.FromFile(NFTGeneratorComponentsForm.HatsLegendaryLocation[HatsInt]);

                            if (Hats.Width >= 250)
                            {
                                HatsResize = new Bitmap(Hats, new Size(Hats.Width / 2, Hats.Height / 2));
                            }

                            panel_Hats.Width = HatsResize.Width;
                            panel_Hats.Height = HatsResize.Height;

                            panel_Hats.BackgroundImage = HatsResize;
                            panel2.Controls.Add(panel_Hats);

                            EffPosX = HatsResize.Width / 2;
                            EffPosY = HatsResize.Height / 2;

                            panel_Hats.Location = new Point(HatGenerationX - EffPosX, HatGenerationY - EffPosY);

                            break;
                    }
                }

                //Necklaces
                int ListItemNumberNecklaces = randomHats.Next(RarityList.Count);
                int NecklacesInt;

                if (NecklacesGenerationX != 100000000)
                {
                    Image Necklaces = null;
                    Bitmap NecklacesResize = null;

                    int EffPosX_Necklaces = 0;
                    int EffPosY_Necklaces = 0;

                    switch (ListItemNumberNecklaces)
                    {
                        case 0:

                            NecklacesInt = random.Next(NFTGeneratorComponentsForm.NecklacesCommonLocation.Count);

                            Necklaces = Image.FromFile(NFTGeneratorComponentsForm.NecklacesCommonLocation[NecklacesInt]);

                            if (Necklaces.Width >= 250)
                            {
                                NecklacesResize = new Bitmap(Necklaces, new Size(Necklaces.Width / 2, Necklaces.Height / 2));
                            }

                            panel_Necklaces.Width = NecklacesResize.Width;
                            panel_Necklaces.Height = NecklacesResize.Height;

                            panel_Necklaces.BackgroundImage = NecklacesResize;
                            panel1.Controls.Add(panel_Necklaces);

                            EffPosX_Necklaces = NecklacesResize.Width / 2;
                            EffPosY_Necklaces = NecklacesResize.Height / 2;

                            panel_Necklaces.Location = new Point(NecklacesGenerationX - EffPosX_Necklaces, NecklacesGenerationY - EffPosY_Necklaces);

                            break;

                        case 1:
                            NecklacesInt = random.Next(NFTGeneratorComponentsForm.NecklacesCommonLocation.Count);

                            Necklaces = Image.FromFile(NFTGeneratorComponentsForm.NecklacesCommonLocation[NecklacesInt]);

                            if (Necklaces.Width >= 250)
                            {
                                NecklacesResize = new Bitmap(Necklaces, new Size(Necklaces.Width / 2, Necklaces.Height / 2));
                            }

                            panel_Necklaces.Width = NecklacesResize.Width;
                            panel_Necklaces.Height = NecklacesResize.Height;

                            panel_Necklaces.BackgroundImage = NecklacesResize;
                            panel1.Controls.Add(panel_Necklaces);

                            EffPosX_Necklaces = NecklacesResize.Width / 2;
                            EffPosY_Necklaces = NecklacesResize.Height / 2;

                            panel_Necklaces.Location = new Point(NecklacesGenerationX - EffPosX_Necklaces, NecklacesGenerationY - EffPosY_Necklaces);

                            break;

                        case 2:
                            NecklacesInt = random.Next(NFTGeneratorComponentsForm.NecklacesCommonLocation.Count);

                            Necklaces = Image.FromFile(NFTGeneratorComponentsForm.NecklacesCommonLocation[NecklacesInt]);

                            if (Necklaces.Width >= 250)
                            {
                                NecklacesResize = new Bitmap(Necklaces, new Size(Necklaces.Width / 2, Necklaces.Height / 2));
                            }

                            panel_Necklaces.Width = NecklacesResize.Width;
                            panel_Necklaces.Height = NecklacesResize.Height;

                            panel_Necklaces.BackgroundImage = NecklacesResize;
                            panel1.Controls.Add(panel_Necklaces);

                            EffPosX_Necklaces = NecklacesResize.Width / 2;
                            EffPosY_Necklaces = NecklacesResize.Height / 2;

                            panel_Necklaces.Location = new Point(NecklacesGenerationX - EffPosX_Necklaces, NecklacesGenerationY - EffPosY_Necklaces);

                            break;

                        case 3:
                            NecklacesInt = random.Next(NFTGeneratorComponentsForm.NecklacesCommonLocation.Count);

                            Necklaces = Image.FromFile(NFTGeneratorComponentsForm.NecklacesCommonLocation[NecklacesInt]);

                            if (Necklaces.Width >= 250)
                            {
                                NecklacesResize = new Bitmap(Necklaces, new Size(Necklaces.Width / 2, Necklaces.Height / 2));
                            }

                            panel_Necklaces.Width = NecklacesResize.Width;
                            panel_Necklaces.Height = NecklacesResize.Height;

                            panel_Necklaces.BackgroundImage = NecklacesResize;
                            panel1.Controls.Add(panel_Necklaces);

                            EffPosX_Necklaces = NecklacesResize.Width / 2;
                            EffPosY_Necklaces = NecklacesResize.Height / 2;

                            panel_Necklaces.Location = new Point(NecklacesGenerationX - EffPosX_Necklaces, NecklacesGenerationY - EffPosY_Necklaces);

                            break;

                        case 4:
                            NecklacesInt = random.Next(NFTGeneratorComponentsForm.NecklacesRareLocation.Count);

                            Necklaces = Image.FromFile(NFTGeneratorComponentsForm.NecklacesRareLocation[NecklacesInt]);

                            if (Necklaces.Width >= 250)
                            {
                                NecklacesResize = new Bitmap(Necklaces, new Size(Necklaces.Width / 2, Necklaces.Height / 2));
                            }

                            panel_Necklaces.Width = NecklacesResize.Width;
                            panel_Necklaces.Height = NecklacesResize.Height;

                            panel_Necklaces.BackgroundImage = NecklacesResize;
                            panel1.Controls.Add(panel_Necklaces);

                            EffPosX_Necklaces = NecklacesResize.Width / 2;
                            EffPosY_Necklaces = NecklacesResize.Height / 2;

                            panel_Necklaces.Location = new Point(NecklacesGenerationX - EffPosX_Necklaces, NecklacesGenerationY - EffPosY_Necklaces);

                            break;

                        case 5:
                            NecklacesInt = random.Next(NFTGeneratorComponentsForm.NecklacesRareLocation.Count);

                            Necklaces = Image.FromFile(NFTGeneratorComponentsForm.NecklacesRareLocation[NecklacesInt]);

                            if (Necklaces.Width >= 250)
                            {
                                NecklacesResize = new Bitmap(Necklaces, new Size(Necklaces.Width / 2, Necklaces.Height / 2));
                            }

                            panel_Necklaces.Width = NecklacesResize.Width;
                            panel_Necklaces.Height = NecklacesResize.Height;

                            panel_Necklaces.BackgroundImage = NecklacesResize;
                            panel1.Controls.Add(panel_Necklaces);

                            EffPosX_Necklaces = NecklacesResize.Width / 2;
                            EffPosY_Necklaces = NecklacesResize.Height / 2;

                            panel_Necklaces.Location = new Point(NecklacesGenerationX - EffPosX_Necklaces, NecklacesGenerationY - EffPosY_Necklaces);

                            break;

                        case 6:
                            NecklacesInt = random.Next(NFTGeneratorComponentsForm.NecklacesRareLocation.Count);

                            Necklaces = Image.FromFile(NFTGeneratorComponentsForm.NecklacesRareLocation[NecklacesInt]);

                            if (Necklaces.Width >= 250)
                            {
                                NecklacesResize = new Bitmap(Necklaces, new Size(Necklaces.Width / 2, Necklaces.Height / 2));
                            }

                            panel_Necklaces.Width = NecklacesResize.Width;
                            panel_Necklaces.Height = NecklacesResize.Height;

                            panel_Necklaces.BackgroundImage = NecklacesResize;
                            panel1.Controls.Add(panel_Necklaces);

                            EffPosX_Necklaces = NecklacesResize.Width / 2;
                            EffPosY_Necklaces = NecklacesResize.Height / 2;

                            panel_Necklaces.Location = new Point(NecklacesGenerationX - EffPosX_Necklaces, NecklacesGenerationY - EffPosY_Necklaces);

                            break;

                        case 7:
                            NecklacesInt = random.Next(NFTGeneratorComponentsForm.NecklacesEpicLocation.Count);

                            Necklaces = Image.FromFile(NFTGeneratorComponentsForm.NecklacesEpicLocation[NecklacesInt]);

                            if (Necklaces.Width >= 250)
                            {
                                NecklacesResize = new Bitmap(Necklaces, new Size(Necklaces.Width / 2, Necklaces.Height / 2));
                            }

                            panel_Necklaces.Width = NecklacesResize.Width;
                            panel_Necklaces.Height = NecklacesResize.Height;

                            panel_Necklaces.BackgroundImage = NecklacesResize;
                            panel1.Controls.Add(panel_Necklaces);

                            EffPosX_Necklaces = NecklacesResize.Width / 2;
                            EffPosY_Necklaces = NecklacesResize.Height / 2;

                            panel_Necklaces.Location = new Point(NecklacesGenerationX - EffPosX_Necklaces, NecklacesGenerationY - EffPosY_Necklaces);

                            break;

                        case 8:
                            NecklacesInt = random.Next(NFTGeneratorComponentsForm.NecklacesEpicLocation.Count);

                            Necklaces = Image.FromFile(NFTGeneratorComponentsForm.NecklacesEpicLocation[NecklacesInt]);

                            if (Necklaces.Width >= 250)
                            {
                                NecklacesResize = new Bitmap(Necklaces, new Size(Necklaces.Width / 2, Necklaces.Height / 2));
                            }

                            panel_Necklaces.Width = NecklacesResize.Width;
                            panel_Necklaces.Height = NecklacesResize.Height;

                            panel_Necklaces.BackgroundImage = NecklacesResize;
                            panel1.Controls.Add(panel_Necklaces);

                            EffPosX_Necklaces = NecklacesResize.Width / 2;
                            EffPosY_Necklaces = NecklacesResize.Height / 2;

                            panel_Necklaces.Location = new Point(NecklacesGenerationX - EffPosX_Necklaces, NecklacesGenerationY - EffPosY_Necklaces);

                            break;

                        case 9:
                            NecklacesInt = random.Next(NFTGeneratorComponentsForm.NecklacesLegendaryLocation.Count);

                            Necklaces = Image.FromFile(NFTGeneratorComponentsForm.NecklacesLegendaryLocation[NecklacesInt]);

                            if (Necklaces.Width >= 250)
                            {
                                NecklacesResize = new Bitmap(Necklaces, new Size(Necklaces.Width / 2, Necklaces.Height / 2));
                            }

                            panel_Necklaces.Width = NecklacesResize.Width;
                            panel_Necklaces.Height = NecklacesResize.Height;

                            panel_Necklaces.BackgroundImage = NecklacesResize;
                            panel1.Controls.Add(panel_Necklaces);

                            EffPosX_Necklaces = NecklacesResize.Width / 2;
                            EffPosY_Necklaces = NecklacesResize.Height / 2;

                            panel_Necklaces.Location = new Point(NecklacesGenerationX - EffPosX_Necklaces, NecklacesGenerationY - EffPosY_Necklaces);

                            break;
                    }
                }

                //Sunglasses
                int ListItemNumberSunglasses = randomHats.Next(RarityList.Count);
                int SunglassesInt;

                if (SunglassesGenerationX != 100000000)
                {
                    Image Sunglasses = null;
                    Bitmap SunglassesResize = null;

                    int EffPosX_Sunglasses = 0;
                    int EffPosY_Sunglasses = 0;

                    switch (ListItemNumberSunglasses)
                    {
                        case 0:
                            SunglassesInt = random.Next(NFTGeneratorComponentsForm.SunglassesCommonLocation.Count);

                            Sunglasses = Image.FromFile(NFTGeneratorComponentsForm.SunglassesCommonLocation[SunglassesInt]);

                            if (Sunglasses.Width >= 250)
                            {
                                SunglassesResize = new Bitmap(Sunglasses, new Size(Sunglasses.Width / 2, Sunglasses.Height / 2));
                            }

                            panel_Sunglasses.Width = SunglassesResize.Width;
                            panel_Sunglasses.Height = SunglassesResize.Height;

                            panel_Sunglasses.BackgroundImage = SunglassesResize;
                            panel_NFTAncor.Controls.Add(panel_Sunglasses);

                            EffPosX_Sunglasses = SunglassesResize.Width / 2;
                            EffPosY_Sunglasses = SunglassesResize.Height / 2;

                            panel_Sunglasses.Location = new Point(SunglassesGenerationX - EffPosX_Sunglasses, SunglassesGenerationY - EffPosY_Sunglasses);

                            break;

                        case 1:
                            SunglassesInt = random.Next(NFTGeneratorComponentsForm.SunglassesCommonLocation.Count);

                            Sunglasses = Image.FromFile(NFTGeneratorComponentsForm.SunglassesCommonLocation[SunglassesInt]);

                            if (Sunglasses.Width >= 250)
                            {
                                SunglassesResize = new Bitmap(Sunglasses, new Size(Sunglasses.Width / 2, Sunglasses.Height / 2));
                            }

                            panel_Sunglasses.Width = SunglassesResize.Width;
                            panel_Sunglasses.Height = SunglassesResize.Height;

                            panel_Sunglasses.BackgroundImage = SunglassesResize;
                            panel_Colors.Controls.Add(panel_Sunglasses);

                            EffPosX_Sunglasses = SunglassesResize.Width / 2;
                            EffPosY_Sunglasses = SunglassesResize.Height / 2;

                            panel_Sunglasses.Location = new Point(SunglassesGenerationX - EffPosX_Sunglasses, SunglassesGenerationY - EffPosY_Sunglasses);

                            break;

                        case 2:
                            SunglassesInt = random.Next(NFTGeneratorComponentsForm.SunglassesCommonLocation.Count);

                            Sunglasses = Image.FromFile(NFTGeneratorComponentsForm.SunglassesCommonLocation[SunglassesInt]);

                            if (Sunglasses.Width >= 250)
                            {
                                SunglassesResize = new Bitmap(Sunglasses, new Size(Sunglasses.Width / 2, Sunglasses.Height / 2));
                            }

                            panel_Sunglasses.Width = SunglassesResize.Width;
                            panel_Sunglasses.Height = SunglassesResize.Height;

                            panel_Sunglasses.BackgroundImage = SunglassesResize;
                            panel_Colors.Controls.Add(panel_Sunglasses);

                            EffPosX_Sunglasses = SunglassesResize.Width / 2;
                            EffPosY_Sunglasses = SunglassesResize.Height / 2;

                            panel_Sunglasses.Location = new Point(SunglassesGenerationX - EffPosX_Sunglasses, SunglassesGenerationY - EffPosY_Sunglasses);

                            break;

                        case 3:
                            SunglassesInt = random.Next(NFTGeneratorComponentsForm.SunglassesCommonLocation.Count);

                            Sunglasses = Image.FromFile(NFTGeneratorComponentsForm.SunglassesCommonLocation[SunglassesInt]);

                            if (Sunglasses.Width >= 250)
                            {
                                SunglassesResize = new Bitmap(Sunglasses, new Size(Sunglasses.Width / 2, Sunglasses.Height / 2));
                            }

                            panel_Sunglasses.Width = SunglassesResize.Width;
                            panel_Sunglasses.Height = SunglassesResize.Height;

                            panel_Sunglasses.BackgroundImage = SunglassesResize;
                            panel_Colors.Controls.Add(panel_Sunglasses);

                            EffPosX_Sunglasses = SunglassesResize.Width / 2;
                            EffPosY_Sunglasses = SunglassesResize.Height / 2;

                            panel_Sunglasses.Location = new Point(SunglassesGenerationX - EffPosX_Sunglasses, SunglassesGenerationY - EffPosY_Sunglasses);

                            break;

                        case 4:
                            SunglassesInt = random.Next(NFTGeneratorComponentsForm.SunglassesRareLocation.Count);

                            Sunglasses = Image.FromFile(NFTGeneratorComponentsForm.SunglassesRareLocation[SunglassesInt]);

                            if (Sunglasses.Width >= 250)
                            {
                                SunglassesResize = new Bitmap(Sunglasses, new Size(Sunglasses.Width / 2, Sunglasses.Height / 2));
                            }

                            panel_Sunglasses.Width = SunglassesResize.Width;
                            panel_Sunglasses.Height = SunglassesResize.Height;

                            panel_Sunglasses.BackgroundImage = SunglassesResize;
                            panel_Colors.Controls.Add(panel_Sunglasses);

                            EffPosX_Sunglasses = SunglassesResize.Width / 2;
                            EffPosY_Sunglasses = SunglassesResize.Height / 2;

                            panel_Sunglasses.Location = new Point(SunglassesGenerationX - EffPosX_Sunglasses, SunglassesGenerationY - EffPosY_Sunglasses);

                            break;

                        case 5:
                            SunglassesInt = random.Next(NFTGeneratorComponentsForm.SunglassesRareLocation.Count);

                            Sunglasses = Image.FromFile(NFTGeneratorComponentsForm.SunglassesRareLocation[SunglassesInt]);

                            if (Sunglasses.Width >= 250)
                            {
                                SunglassesResize = new Bitmap(Sunglasses, new Size(Sunglasses.Width / 2, Sunglasses.Height / 2));
                            }

                            panel_Sunglasses.Width = SunglassesResize.Width;
                            panel_Sunglasses.Height = SunglassesResize.Height;

                            panel_Sunglasses.BackgroundImage = SunglassesResize;
                            panel_Colors.Controls.Add(panel_Sunglasses);

                            EffPosX_Sunglasses = SunglassesResize.Width / 2;
                            EffPosY_Sunglasses = SunglassesResize.Height / 2;

                            panel_Sunglasses.Location = new Point(SunglassesGenerationX - EffPosX_Sunglasses, SunglassesGenerationY - EffPosY_Sunglasses);

                            break;

                        case 6:
                            SunglassesInt = random.Next(NFTGeneratorComponentsForm.SunglassesRareLocation.Count);

                            Sunglasses = Image.FromFile(NFTGeneratorComponentsForm.SunglassesRareLocation[SunglassesInt]);

                            if (Sunglasses.Width >= 250)
                            {
                                SunglassesResize = new Bitmap(Sunglasses, new Size(Sunglasses.Width / 2, Sunglasses.Height / 2));
                            }

                            panel_Sunglasses.Width = SunglassesResize.Width;
                            panel_Sunglasses.Height = SunglassesResize.Height;

                            panel_Sunglasses.BackgroundImage = SunglassesResize;
                            panel_Colors.Controls.Add(panel_Sunglasses);

                            EffPosX_Sunglasses = SunglassesResize.Width / 2;
                            EffPosY_Sunglasses = SunglassesResize.Height / 2;

                            panel_Sunglasses.Location = new Point(SunglassesGenerationX - EffPosX_Sunglasses, SunglassesGenerationY - EffPosY_Sunglasses);

                            break;

                        case 7:
                            SunglassesInt = random.Next(NFTGeneratorComponentsForm.SunglassesEpicLocation.Count);

                            Sunglasses = Image.FromFile(NFTGeneratorComponentsForm.SunglassesEpicLocation[SunglassesInt]);

                            if (Sunglasses.Width >= 250)
                            {
                                SunglassesResize = new Bitmap(Sunglasses, new Size(Sunglasses.Width / 2, Sunglasses.Height / 2));
                            }

                            panel_Sunglasses.Width = SunglassesResize.Width;
                            panel_Sunglasses.Height = SunglassesResize.Height;

                            panel_Sunglasses.BackgroundImage = SunglassesResize;
                            panel_Colors.Controls.Add(panel_Sunglasses);

                            EffPosX_Sunglasses = SunglassesResize.Width / 2;
                            EffPosY_Sunglasses = SunglassesResize.Height / 2;

                            panel_Sunglasses.Location = new Point(SunglassesGenerationX - EffPosX_Sunglasses, SunglassesGenerationY - EffPosY_Sunglasses);

                            break;

                        case 8:
                            SunglassesInt = random.Next(NFTGeneratorComponentsForm.SunglassesEpicLocation.Count);

                            Sunglasses = Image.FromFile(NFTGeneratorComponentsForm.SunglassesEpicLocation[SunglassesInt]);

                            if (Sunglasses.Width >= 250)
                            {
                                SunglassesResize = new Bitmap(Sunglasses, new Size(Sunglasses.Width / 2, Sunglasses.Height / 2));
                            }

                            panel_Sunglasses.Width = SunglassesResize.Width;
                            panel_Sunglasses.Height = SunglassesResize.Height;

                            panel_Sunglasses.BackgroundImage = SunglassesResize;
                            panel_Colors.Controls.Add(panel_Sunglasses);

                            EffPosX_Sunglasses = SunglassesResize.Width / 2;
                            EffPosY_Sunglasses = SunglassesResize.Height / 2;

                            panel_Sunglasses.Location = new Point(SunglassesGenerationX - EffPosX_Sunglasses, SunglassesGenerationY - EffPosY_Sunglasses);

                            break;

                        case 9:
                            SunglassesInt = random.Next(NFTGeneratorComponentsForm.SunglassesLegendaryLocation.Count);

                            Sunglasses = Image.FromFile(NFTGeneratorComponentsForm.SunglassesLegendaryLocation[SunglassesInt]);

                            if (Sunglasses.Width >= 250)
                            {
                                SunglassesResize = new Bitmap(Sunglasses, new Size(Sunglasses.Width / 2, Sunglasses.Height / 2));
                            }

                            panel_Sunglasses.Width = SunglassesResize.Width;
                            panel_Sunglasses.Height = SunglassesResize.Height;

                            panel_Sunglasses.BackgroundImage = SunglassesResize;
                            panel_Colors.Controls.Add(panel_Sunglasses);

                            EffPosX_Sunglasses = SunglassesResize.Width / 2;
                            EffPosY_Sunglasses = SunglassesResize.Height / 2;

                            panel_Sunglasses.Location = new Point(SunglassesGenerationX - EffPosX_Sunglasses, SunglassesGenerationY - EffPosY_Sunglasses);

                            break;
                    }
                }

                x++;

                capture(panel_NFTAncor, "Generate_" + x.ToString() + ".png");

                System.Threading.Thread.Sleep(2500);
            }
        }

        private void capture(Control ctrl, string fileName)
        {
            Rectangle bounds = ctrl.Bounds;
            Point pt = ctrl.PointToScreen(bounds.Location);
            Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.CopyFromScreen(new Point(pt.X - ctrl.Location.X, pt.Y - ctrl.Location.Y), Point.Empty, bounds.Size);
            }

            bitmap.Save(txtBoxLocation.Text + fileName, System.Drawing.Imaging.ImageFormat.Png);
        }

    }
}
