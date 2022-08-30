namespace Solution.Model
{
    /// <summary>
    /// Represents a configurable state that an item can be in.
    /// </summary>
    public class Status
    {
        /// <summary>
        /// Unique identifier for a <see cref="Status"/>
        /// </summary>
        public int Id { get; private set; }

        /// <summary>
        /// User-friendly display value for a <see cref="Status"/>
        /// </summary>
        public string Name { get; private set; }

        public Status(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return string.Format("{0}: {1}", Id, Name);
        }
    }
}