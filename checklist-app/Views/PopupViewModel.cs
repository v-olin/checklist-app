using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checklist_app.Views
{
    public class PopupViewModel
    {
        public PopupViewModel(string msg)
        {
            this.Message = msg;
        }

        public string Message { get; init; }
    }
}
