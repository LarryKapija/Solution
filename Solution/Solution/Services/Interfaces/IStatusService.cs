using System;
using System.Collections.Generic;
using System.Reflection;

namespace Solution.Services.Interfaces
{
    public interface IStatusService
    {
        /// <summary>
        /// Returns a list of "Initial" <see cref="Model.Status"/> objects that are filtered by the passed in subtype.
        /// </summary>
        /// <param name="subtype">The <see cref="Model.Subtype"/> that filters the Statuses returned</param>
        /// <returns>A list of initial <see cref="Model.Status"/> objects for the passed in <see cref="Model.Subtype"/></returns>
        IEnumerable<Model.Status> GetInitialStatuses(Model.Subtype subtype);
    }
}

