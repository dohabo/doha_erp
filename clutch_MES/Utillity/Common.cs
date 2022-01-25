using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clutch_MES.UI;

namespace winForm0727_2.Util
{
    class Common
    {
        public static void initTheme(MaterialForm form)
        {
            var skin = MaterialSkinManager.Instance;
            skin.AddFormToManage(form);
            skin.Theme = MaterialSkinManager.Themes.LIGHT;
            skin.ColorScheme = new ColorScheme(
                Primary.BlueGrey900,
                Primary.BlueGrey900,
                Primary.Blue700,
                Accent.Red100,
                TextShade.WHITE);
        }
    }
}
