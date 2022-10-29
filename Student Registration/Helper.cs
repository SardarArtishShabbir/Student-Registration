
using System.Windows.Forms;

namespace HelperSpace
{
    public static class Helper
    {
        public static void Clear(Form form)
        {
            foreach (var item in form.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt = (TextBox)item;
                    txt.Clear();
                }
            }
        }


    }
}
