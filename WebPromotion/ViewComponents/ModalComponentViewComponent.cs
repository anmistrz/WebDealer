using System;
using Microsoft.AspNetCore.Mvc;
using WebPromotion.ViewModels.Modal;

namespace WebPromotion.ViewComponents
{
    public class ModalComponentViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(ModalViewModels model)
        {
            if (model == null)
            {
                throw new ArgumentNullException(nameof(model), "ModalViewModels cannot be null");
            }

            return View(model);
        }
    }
}
