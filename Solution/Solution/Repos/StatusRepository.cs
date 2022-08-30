using System.Collections.Generic;
using Solution.Repos.Interfaces;

namespace Solution.Repos
{
    /// <summary>
    /// Implementation of <see cref="IStatusRepository"/> that creates new data to return each time.
    /// </summary>
    public class StatusRepository : IStatusRepository
    {
        public static readonly Model.Status Open = new Model.Status(0, "Open");
        public static readonly Model.Status InProgress = new Model.Status(1, "In Progress");
        public static readonly Model.Status Closed = new Model.Status(2, "Closed");
        public static readonly Model.Status Validate = new Model.Status(3, "Validate");
        public static readonly Model.Status ValidationSuccessful = new Model.Status(4, "Validation Successful");
        public static readonly Model.Status ValidationFailed = new Model.Status(5, "Validation Failed");

        public IEnumerable<Model.Status> GetAll()
        {
            return new List<Model.Status> { Open, InProgress, Closed, Validate, ValidationSuccessful, ValidationFailed };
        }
    }
}