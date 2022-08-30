namespace Solution.Model
{
    /// <summary>
    /// A <see cref="Subtype"/> is used to categorize different <see cref="Status"/> behaviors.
    /// </summary>
    public class Subtype
    {
        /// <summary>
        /// Unique identifier for a <see cref="Subtype"/>
        /// </summary>
        public int Id { get; private set; }

        /// <summary>
        /// User-friendly display value for a <see cref="Subtype"/>
        /// </summary>
        public string Name { get; private set; }

        public Subtype(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}