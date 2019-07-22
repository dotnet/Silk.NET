// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;
using Silk.NET.BuildTools.Convert.Construction.Trimmers;

namespace Silk.NET.BuildTools.Convert.Construction
{
    /// <summary>
    /// A collection of functions for altering the endings of function names.
    /// </summary>
    public static class NameTrimmer
    {
        /// <summary>
        /// Gets the possible variations on the given entry point. Typically, this boils down to the
        /// following three cases, in order:
        ///
        /// * FunctionNamefvEXT
        /// * FunctionNamefv
        /// * FunctionName
        ///
        /// Care should be taken when creating new overrides that the intended function is targeted.
        /// </summary>
        /// <param name="functionEntrypoint">The entrypoint to create variations of.</param>
        /// <returns>The name variations, ordered by length, starting with the longest.</returns>
        [NotNull]
        [ItemNotNull]
        public static IEnumerable<string> GetNameVariations(string functionEntrypoint)
        {
            var extensionTrimmer =new ExtensionNameTrimmer();
            var dataTypeTrimmer = new DataTypeNameTrimmer();

            var variations = new List<string>();
            var currentVariation = functionEntrypoint;

            variations.Add(currentVariation);

            if (extensionTrimmer.IsRelevant(currentVariation))
            {
                currentVariation = extensionTrimmer.Trim(currentVariation);
                variations.Add(currentVariation);
            }

            if (dataTypeTrimmer.IsRelevant(currentVariation))
            {
                variations.Add(dataTypeTrimmer.Trim(currentVariation));
            }

            return variations.Distinct().OrderByDescending(v => v.Length);
        }

        /// <summary>
        /// Synchronously trims the given string.
        /// </summary>
        /// <param name="functionName">The string to trim.</param>
        /// <returns>A trimmed string.</returns>
        public static string Trim(string functionName)
        {
            return GetNameVariations(functionName).Last();
        }
    }
}
