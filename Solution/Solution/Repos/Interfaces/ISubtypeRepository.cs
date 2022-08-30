using Solution.Model;
using System.Collections.Generic;

namespace Solution.Repos.Interfaces
{
    /// <summary>
    /// Contains logic for querying <see cref="Subtype"/> objects.
    /// </summary>
    public interface ISubtypeRepository
    {
        IEnumerable<Subtype> GetAll();
    }
}