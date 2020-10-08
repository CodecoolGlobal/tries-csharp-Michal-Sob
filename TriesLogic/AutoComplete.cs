using System;
using System.Collections.Generic;

namespace TriesLogic
{
    public class AutoComplete
    {
        private TrieDataNode rootNode;

        /// <summary>
        /// Starts a new Trie with dummy root data "-"
        /// </summary>
        public AutoComplete()
        {
            rootNode = new TrieDataNode('-');
        }

        /// <summary>
        /// Adds a word to the Trie.
        /// </summary>
        /// <param name="wordToAdd"></param>
        public void AddWord(String wordToAdd)
        {
            // TODO
        }

        /// <summary>
        /// Returns the possible completions of baseChars String from the Trie.
        /// </summary>
        /// <param name="baseChars">The String to autocomplete.</param>
        /// <returns>Possible completions.An empty list if there are none.</returns>
        public List<String> GetCompletions(String baseChars)
        {
            List<String> words = new List<string>();
            // TODO
            return words;
        }

        /// <summary>
        /// Removes a word from the Trie
        /// </summary>
        /// <param name="wordToRemove">Word to remove from the possible words.</param>
        /// <returns>true if the removal was successful</returns>
        public bool RemoveWord(String wordToRemove)
        {
            // TODO -- Optional homework
            return false;
        }
    }
}

