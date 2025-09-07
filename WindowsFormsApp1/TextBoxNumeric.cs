using System.Windows.Forms;

namespace SerialMonitor
{
    public static class TextBoxNumeric
    {
        public static void NumericOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
