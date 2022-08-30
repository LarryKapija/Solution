using Solution.Model;
using System.Collections.Generic;

namespace Solution.Repos.Interfaces
{
    /// <summary>
    /// Contains logic for querying <see cref="Transition"/> objects.
    /// </summary>
    public interface ITransitionRepository
    {
        IEnumerable<Transition> GetAll();
    }
}