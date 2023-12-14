using System.Drawing;
using System.Windows.Forms;

namespace General_settings
{
    internal class Settings
    {
        Point lastPoint;

        public void MouseMove(Form form, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                form.Left += e.X - lastPoint.X;
                form.Top += e.Y - lastPoint.Y;
            }
        }

        public void MouseDown(MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        public void CloseWindow()
        {
            Application.Exit();
        }

        public void MinimizeWindow(Form form)
        {
            form.WindowState = FormWindowState.Minimized;
        }

        public void MaximizeWindow(Form form)
        {
            if (form.WindowState == FormWindowState.Maximized)
            {
                form.WindowState = FormWindowState.Normal;
                return;
            }

            if (form.WindowState == FormWindowState.Normal)
            {
                form.WindowState = FormWindowState.Maximized;
                return;
            }
        }

        public void ProhibitionSymbol(KeyPressEventArgs e)
        {
            if (e.KeyChar == '\'')
            {
                e.Handled = true;
            }
        }
    }
}
