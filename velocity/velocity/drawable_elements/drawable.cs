using AngleSharp.Dom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace velocity.drawable_elements
{
    internal interface drawable
    {
        Task paint_element(paint_context pc);
        Task gen_paint_tasks();
    }
}
