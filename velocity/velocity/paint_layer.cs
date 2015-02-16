using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace velocity
{
    //Contains the elements, in order to be painted for this layer, with calculated values
    internal class paint_layer
    {
        private List<drawable_elements.drawable> draw_elements;

        public int paint_index = 0;

        public paint_layer()
        {
            draw_elements = new List<drawable_elements.drawable>();
        }

        public async Task gen_paint_task()
        {
            //have each element converted to a basic paint_task in paint_context
            List<Task> gen_tasks = new List<Task>();
            foreach (drawable_elements.drawable de in draw_elements)
            {
                gen_tasks.Add(Task.Run(() => { de.gen_paint_tasks(); }));
            }
            //wait for all elements to finish creating paint_tasks
            await Task.WhenAll(gen_tasks);
        }
    }
}
