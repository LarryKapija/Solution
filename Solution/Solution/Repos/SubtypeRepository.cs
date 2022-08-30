using System.Collections.Generic;
using Solution.Repos.Interfaces;

namespace Solution.Repos
{
    /// <summary>
    /// Implementation of <see cref="ISubtypeRepository"/> that creates new data to return each time.
    /// </summary>
    public class SubtypeRepository : ISubtypeRepository
    {
        public static readonly Model.Subtype DefaultSubtype = new Model.Subtype(0, "Default");
        public static readonly Model.Subtype ValidationSubtype = new Model.Subtype(1, "Validation");

        public IEnumerable<Model.Subtype> GetAll()
        {
            return new List<Model.Subtype> { DefaultSubtype, ValidationSubtype };
        }
    }
}