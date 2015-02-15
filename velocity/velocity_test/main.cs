using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace velocity_test
{
    public partial class main : Form
    {
        private velocity.WebView webView;

        public main()
        {
            InitializeComponent();
            webView = new velocity.WebView() { Dock = DockStyle.Fill };
            this.Controls.Add(webView);
        }
    }
}
