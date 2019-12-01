using Microsoft.AspNetCore.Mvc;
using Nop.Web.Factories;
using Nop.Web.Framework.Components;

namespace Nop.Web.Components
{
    public class HeaderButtonsViewComponent : NopViewComponent
    {
        private readonly ICommonModelFactory _commonModelFactory;

        public HeaderButtonsViewComponent(ICommonModelFactory commonModelFactory)
        {
            _commonModelFactory = commonModelFactory;
        }

        public IViewComponentResult Invoke()
        {
            var model = _commonModelFactory.PrepareHeaderButtonsModel();
            return View(model);
        }
    }
}
