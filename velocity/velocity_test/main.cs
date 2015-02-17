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
        

        public main()
        {
            InitializeComponent();
            velocity.core.browser b = new velocity.core.browser();
            b.NavigateToHtml(System.IO.File.ReadAllText("../../../tests_source/basic_helloworld/helloworld.html"));
        }
    }
}
