using System.Collections.Generic;
using System.Linq;
using Solution.Model;
using Solution.Repos.Interfaces;
using Solution.Services.Interfaces;

/********************************************************************************
 *                                                                              *
 * This service doesn't seem to do what I was expecting. Could you take a look? *
 *                                                                              *
 *******************************************************************************/
namespace Solution.Services
{
    /// <summary>
    /// Contains all business specific rules for interacting with <see cref="Status"/> objects.  These rules define an
    /// Initial Transition as any <see cref="Transition"/> that has a null FromStatus property.
    /// </summary>
    public class StatusService : IStatusService
    {
        private ITransitionRepository TransitionRepo { get; set; }
        private IStatusRepository StatusRepo { get; set; }
        private ISubtypeRepository SubtypeRepo { get; set; }

        public StatusService(ITransitionRepository transitionRepo, IStatusRepository statusRepo, ISubtypeRepository subtypeRepo)
        {
            TransitionRepo = transitionRepo;
            StatusRepo = statusRepo;
            SubtypeRepo = subtypeRepo;
        }

        /// <summary>
        /// This method should return a list of distinct initial <see cref="Status"/> values available for a given <see cref="Subtype"/>.
        ///
        /// An initial <see cref="Status"/> is defined as a <see cref="Status"/> that exists as the ToStatus property of a
        /// <see cref="Transition" /> which also has a null FromStatus value.
        /// 
        /// </summary>
        /// <param name="subtype">The <see cref="Subtype"/> value to filter by.</param>
        /// <returns> An <see cref="IEnumerable{Status}"/> that represents all distinct Initial Status values available </returns>
        public IEnumerable<Status> GetInitialStatuses(Subtype subtype)
        {
            var allTransitions = TransitionRepo.GetAll();

            // Initial Transitions are defined as those with a null FromStatus value from config
            // Here we are also filtering those states related to the subtype that was passed by parameters
            var initialTransitions = 
                    allTransitions.Where(t => t.FromStatus == null && t.Subtype == subtype);

            // Select all the ToStatus values from the initialTransitioned queried
            return initialTransitions.Select(t => t.ToStatus);
        }
    }
}