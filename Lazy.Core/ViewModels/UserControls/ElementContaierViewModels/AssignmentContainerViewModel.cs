namespace Lazy.Core.ViewModels.UserControls
{
    using Lazy.Core.Enums;
    using Lazy.Data;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;

    public class AssignmentContainerViewModel : ElementContainerViewModel
    {
        public override ElementContainerViewModel Update()
        {
            this.Elements = new List<ElementViewModel>();

            using (LazyEntities context = new LazyEntities())
            {
                var assignemnts = context.Assignments.ToList();

                foreach (var assignment in assignemnts)
                {
                    this.Elements.Add(new ElementViewModel
                    {
                        ID = assignment.Id,
                        ElementID = assignment.AssignmentId,
                        Name = assignment.Name,
                        Status = (ElementStatus)assignment.StatusId,
                        URL = assignment.URL,
                        Directory = $"{assignment.Workspace.Directory}/{assignment.Name}",
                        Type = ElementType.Assignment,
                    });
                }
            }

            return this;
        }
    }
}