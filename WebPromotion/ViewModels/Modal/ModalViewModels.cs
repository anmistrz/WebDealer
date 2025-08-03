using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebPromotion.ViewModels.Modal
{
    public class ModalViewModels
    {
        public string Title { get; set; }
        public string Message { get; set; }
        public string ButtonText { get; set; }
        public string ButtonAction { get; set; }
        public string Type { get; set; } // e.g., "info", "warning", "error", "success"
        public bool IsVisible { get; set; } = false; // Controls visibility of the modal
    }
}