using OpenTK.Graphics.OpenGL4;
using System.Drawing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace velocity
{
    public class WebView : OpenTK.GLControl
    {

        private bool has_control_loaded = false;

        protected override void OnLoad(EventArgs e)
        {
            has_control_loaded = true;
            GL.ClearColor(Color.CornflowerBlue);
        }

        protected override void OnResize(EventArgs e)
        {
            if (!has_control_loaded)
            {
                return;
            }
        }

        protected override async void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            if (!has_control_loaded)
            {
                return;
            }
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            this.SwapBuffers();
        }
    }
}
