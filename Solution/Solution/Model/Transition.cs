namespace Solution.Model
{
    /// <summary>
    /// Represents a configurable behavior for a <see cref="Status"/> object.  Each <see cref="Transition"/> will
    /// only be valid for a specific <see cref="Subtype"/>.
    /// </summary>
    public class Transition
    {
        /// <summary>
        /// The <see cref="Status"/> value representing the current state.
        /// </summary>
        public Status FromStatus { get; private set; }

        /// <summary>
        /// The <see cref="Status"/> value representing the state to be transitioned to.
        /// </summary>
        public Status ToStatus { get; private set; }

        /// <summary>
        /// The <see cref="Subtype"/> that this <see cref="Transition"/> is valid for.
        /// </summary>
        public Subtype Subtype { get; private set; }

        public Transition(Status fromStatus, Status toStatus, Subtype subtype)
        {
            FromStatus = fromStatus;
            ToStatus = toStatus;
            Subtype = subtype;
        }
    }
}