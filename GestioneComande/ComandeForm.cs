using MaterialSkin.Controls;
using System.Windows.Forms;

namespace GestioneComande
{
    public partial class ComandeForm : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public ComandeForm()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme =
                new MaterialSkin.ColorScheme(
                    MaterialSkin.Primary.Indigo500,
                    MaterialSkin.Primary.Indigo700,
                    MaterialSkin.Primary.Indigo100,
                    MaterialSkin.Accent.Pink200,
                    MaterialSkin.TextShade.WHITE
                    );
        }
    }
}
