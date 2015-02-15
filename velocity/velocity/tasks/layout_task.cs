using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngleSharp;
using AngleSharp.Dom;


namespace velocity.tasks
{
    //Handles the calculation of document layout based on the viewport then sends the result to a paint_task
    internal class layout_task
    {
        private IDocument document_object;

        public layout_task(IDocument document_ref)
        {
            document_object = document_ref;
        }


    }
}
