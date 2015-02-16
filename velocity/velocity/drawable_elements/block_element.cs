using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngleSharp;
using AngleSharp.Dom;

namespace velocity.drawable_elements
{
    //Contains calculated values for an element whos display:block from a layout_task and is ready to be painted...
    internal class block_element : drawable
    {
        private IElement element_object;
        private List<Action> paint_tasks_list;

        public block_element(IElement element_ref)
        {
            element_object = element_ref;
            paint_tasks_list = new List<Action>();
        }

        public async Task gen_paint_tasks()
        {

        }

        public async Task paint_element(paint_context pc)
        {
            //run all paint tasks in order.
            foreach (Action task in paint_tasks_list)
            {
                await Task.Run(task);
            }
        }
    }
}
