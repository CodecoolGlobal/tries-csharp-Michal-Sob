using System;

namespace TriesLogic
{
    public class TrieDataNode
    {
        /// <summary>
        /// Stores the Data id this instance
        /// </summary>
        public char Data
        {
            get; private set;
        }
        // TODO: add further members as needed

        /// <summary>
        /// Initializes a TrieDataNode with its data
        /// </summary>
        /// <param name="data">The data in this node</param>
        public TrieDataNode(char data)
        {
            Data = data;
        }

        /// <summary>
        /// Converts the value of this instance to its string representation of its Data property. 
        /// </summary>
        /// <returns>The string representation of the Data property of this instance.</returns>
        public override String ToString()
        {
            return Data.ToString();
        }
    }
}
