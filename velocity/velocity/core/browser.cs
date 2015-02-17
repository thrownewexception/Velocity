using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace velocity.core
{
    //Exposed browser class
    public class browser
    {
        //When a new browser is created
        public browser()
        {
            //Spawn tasks (Layout, Script, Paint, Cache, Input)
            Parallel.Invoke(spawn_worker_tasks);
        }

        //Create the tasks using unique pipe id's (Somehow we need to generate unique id's for each pipe as they cannot share the same channel.)
        //TODO: Create a task that returns a unique pipe id. When we enter multi-process mode we provide the pipe id to the process from the main process.
        private void spawn_worker_tasks()
        {

        }
    }
}
