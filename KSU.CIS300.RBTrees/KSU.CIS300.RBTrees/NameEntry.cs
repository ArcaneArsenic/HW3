/*
 *Author:
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSU.CIS300.RBTrees
{
    /// <summary>
    /// An immutable structure representing a frequency and a rank.
    /// </summary>
    public struct NameEntry: IComparable<NameEntry>, IComparable
    {
        public string Name { get; }
        /// <summary>
        /// Gets the Frequency.
        /// </summary>
        public float Frequency { get; }

        /// <summary>
        /// Gets the Rank.
        /// </summary>
        public int Rank { get; }

        /// <summary>
        /// Initializes a FrequencyAndRank with the given values.
        /// </summary>
        /// <param name="freq">The frequency.</param>
        /// <param name="rank">The rank.</param>
        public NameEntry(string name, float freq, int rank)
        {
            Name = name;
            Frequency = freq;
            Rank = rank;
        }

        /// <summary>
        /// Obtains a string representation of the frequency and rank.
        /// </summary>
        /// <returns>The string representation.</returns>
        public override string ToString()
        {
            return Name + ", " + Frequency + ", " + Rank;
        }

        public int CompareTo(NameEntry entry)
        {
            return Name.CompareTo(entry.Name);
        }

        public int CompareTo(object obj)
        {
            if (obj == null || !(obj is NameEntry))
                throw new InvalidOperationException("Object must be NameEntry");
            return CompareTo((NameEntry)obj);
        }
    }
}
