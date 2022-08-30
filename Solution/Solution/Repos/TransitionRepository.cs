using System.Collections.Generic;
using Solution.Model;
using Solution.Repos.Interfaces;

namespace Solution.Repos
{
    /// <summary>
    /// Implementation of <see cref="ITransitionRepository"/> that creates new data to return each time.
    /// </summary>
    public class TransitionRepository : ITransitionRepository
    {
        // Initial Default Subtype Status Transitions
        public static readonly Transition DefaultOpen = new Transition(null, StatusRepository.Open, SubtypeRepository.DefaultSubtype);
        public static readonly Transition InProgress = new Transition(null, StatusRepository.InProgress, SubtypeRepository.DefaultSubtype);

        // Initial Validation Subtype Status Transitions
        public static readonly Transition ValidateOpen = new Transition(null, StatusRepository.Open, SubtypeRepository.ValidationSubtype);
        public static readonly Transition Validate = new Transition(null, StatusRepository.Validate, SubtypeRepository.ValidationSubtype);

        // Other Transitions
        public static readonly Transition OpenInProgress = new Transition(StatusRepository.Open, StatusRepository.InProgress, SubtypeRepository.DefaultSubtype);
        public static readonly Transition InProgressClosed = new Transition(StatusRepository.InProgress, StatusRepository.Closed, SubtypeRepository.DefaultSubtype);
        public static readonly Transition OpenValidate = new Transition(StatusRepository.Open, StatusRepository.Validate, SubtypeRepository.ValidationSubtype);
        public static readonly Transition ValidateFailed = new Transition(StatusRepository.Validate, StatusRepository.ValidationFailed, SubtypeRepository.ValidationSubtype);
        public static readonly Transition ValidateSucceeded = new Transition(StatusRepository.Validate, StatusRepository.ValidationSuccessful, SubtypeRepository.ValidationSubtype);

        public IEnumerable<Transition> GetAll()
        {
            return new List<Transition>
            {
                DefaultOpen, InProgress, OpenInProgress, InProgressClosed, Validate, ValidateOpen, OpenValidate, ValidateFailed, ValidateSucceeded
            };
        }
    }
}