using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace SuperAdventure
{
    public partial class WorldMap : Form
    {
        readonly Assembly _thisAssembly = Assembly.GetExecutingAssembly();

        public WorldMap()
        {
            InitializeComponent();

            /* string[] resources = _thisAssembly.GetManifestResourceNames();
             * string toDisplay = string.Join(System.Environment.NewLine, resources);
             * MessageBox.Show(toDisplay);
             */

            SetImage(pic_0_0, "");
            SetImage(pic_0_1, "");
            SetImage(pic_0_2, "HerbalistsGarden");
            SetImage(pic_0_3, "");
            SetImage(pic_0_4, "");
            SetImage(pic_0_5, "");
            SetImage(pic_1_0, "");
            SetImage(pic_1_1, "");
            SetImage(pic_1_2, "HerbalistsHut");
            SetImage(pic_1_3, "");
            SetImage(pic_1_4, "");
            SetImage(pic_1_5, "");
            SetImage(pic_2_0, "FarmFields");
            SetImage(pic_2_1, "Farmhouse");
            SetImage(pic_2_2, "TownSquare");
            SetImage(pic_2_3, "TownGate");
            SetImage(pic_2_4, "Bridge");
            SetImage(pic_2_5, "SpiderForest");
            SetImage(pic_3_0, "");
            SetImage(pic_3_1, "");
            SetImage(pic_3_2, "Home");
            SetImage(pic_3_3, "");
            SetImage(pic_3_4, "");
            SetImage(pic_3_5, "");
        }

        private void SetImage(PictureBox pictureBox, string imageName)
        {
            using (Stream resourceStream =
            _thisAssembly.GetManifestResourceStream(
                 //_thisAssembly.GetName().Name + ".Resources." + imageName + ".png"))
                 "SuperAdventure.Resources." + imageName + ".png"))
            {
                if (resourceStream != null)
                {
                    pictureBox.Image = new Bitmap(resourceStream);
                }
            }
        }
    }
}
