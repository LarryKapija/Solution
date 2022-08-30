using System.Collections.Generic;
using Solution.Model;

namespace Solution.Repos.Interfaces
{
    /// <summary>
    /// Contains logic for querying <see cref="Status"/> objects.
    /// </summary>
    public interface IStatusRepository
    {
        IEnumerable<Status> GetAll();
    }
}