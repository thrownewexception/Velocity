using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngleSharp;
using AngleSharp.Dom;

namespace velocity.core
{
    //Exposed browser class
    public class browser
    {
        //The anglesharp document currently being displayed in the browser
        internal IDocument current_document;

        //When a new browser is created
        public browser()
        {
        }

        #region public methods
        public void Navigate(string url)
        {
            navigate_to_url(new Uri(url));
        }
        public void NavigateToHtml(string source)
        {
            navigate_to_source(source);
        }
        #endregion

        #region private methods
        private void navigate_to_url(Uri uri)
        {
            Task html_async_task = DocumentBuilder.HtmlAsync(uri);
            html_async_task.ContinueWith((result) => {
                if (result.AsyncState is IDocument)
                {
                    //the document was loaded, set the current document.
                    current_document = (IDocument)result.AsyncState;
                    //setup the page with tasks, in parallel
                    setup_page();
                }
                else
                {
                    //an error occured in anglesharp
                }
            });
        }

        private void navigate_to_source(string source)
        {
            Task html_async_task = DocumentBuilder.HtmlAsync(utilities.convert_stringutf8_to_stream(source));
            html_async_task.ContinueWith((result) =>
            {
                if (((Task<IDocument>)result).Result is IDocument)
                {
                    //the document was loaded, set the current document.
                    current_document = ((Task<IDocument>)result).Result;
                    //setup the page with tasks, in parallel
                    setup_page();
                }
                else
                {
                    //an error occured in anglesharp
                }
            });
        }

        private void setup_page()
        {
            //now that we have the document, in parallel, lay it out, paint it, run scripts, handle input.
            Parallel.Invoke(new Action(() =>
            {
                //preform layout
                tasks.layout_task.do_layout(this);
            }),
            new Action(() =>
            {
                //preform paint
                tasks.paint_task.do_paint(this);
            }));
        }
        #endregion
    }
}
