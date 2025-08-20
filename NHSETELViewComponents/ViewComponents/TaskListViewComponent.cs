namespace NHSETELViewComponents.ViewComponents
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;
    using NHSETELViewComponents.ViewModels;

    /// <summary>
    /// A ViewComponent that renders a list of tasks based on the provided list of task items.
    /// </summary>
    public class TaskListViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(
            IEnumerable<TaskListItemViewModel> listItems)
        {
            var model = new TaskListViewModel(listItems);

            return View(model);
        }
    }
}
