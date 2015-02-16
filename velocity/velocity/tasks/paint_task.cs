using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace velocity.tasks
{
    //Handles painting the results of a layout_task to the OpenGL Surface
    internal class paint_task
    {
        private List<paint_layer> paint_layers;

        public paint_task()
        {
            paint_layers = new List<paint_layer>();
        }

        /// <summary>
        /// Adds a layer to the paint_layers list
        /// </summary>
        /// <param name="pl">The layer to add</param>
        /// <returns></returns>
        public async Task add_layer(paint_layer pl)
        {
            //wait for paint_task to calculate css properties...
            await pl.gen_paint_task();
            //add layer to list
            paint_layers.Add(pl);
        }

        //Paints each layer, in order, sort by paint_index property on paint_layer
        public async Task do_paint()
        {
            //as we find a layer to paint start painting the next one in line, wait for it to finish then continue...
            //depending on how big or small the layers are they are NOT in order in the paint_layers list.
            
        }
    }
}
