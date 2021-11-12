// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;
using System.Linq;

using Silk.NET.BuildTools.Common.Trimmers;

namespace Silk.NET.BuildTools.Common
{
    /// <summary>
    /// A collection of functions for altering the endings of function names.
    /// </summary>
    public static class NameTrimmer
    {
        // ReSharper disable CommentTypo
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
        /// <param name="prefix">The entroypoint prefix. prefix.</param>
        /// <param name="trimExtensionName">Whether or not the extension name should be trimmed.</param>
        /// <param name="trimDataType">Whether or not the data type should be trimmed.</param>
        /// <returns>The name variations, ordered by length, starting with the longest.</returns>
        // ReSharper restore CommentTypo
        public static IEnumerable<string> GetNameVariations
            (string functionEntrypoint, string prefix, bool trimExtensionName = true, bool trimDataType = true)
        {
            var extensionTrimmer = new ExtensionNameTrimmer();
            var dataTypeTrimmer = new DataTypeNameTrimmer();

            var variations = new List<string>();
            var currentVariation = functionEntrypoint;

            variations.Add(currentVariation);

            if (extensionTrimmer.IsRelevant(currentVariation) && trimExtensionName)
            {
                currentVariation = extensionTrimmer.Trim(currentVariation, prefix).TrimEnd('_');
                variations.Add(currentVariation);
            }

            if (dataTypeTrimmer.IsRelevant(currentVariation) && trimDataType)
            {
                variations.Add(dataTypeTrimmer.Trim(currentVariation, prefix));
            }

            return variations.Distinct().OrderByDescending(v => v.Length);
        }

        /// <summary>
        /// Synchronously trims the given string.
        /// </summary>
        /// <param name="functionName">The string to trim.</param>
        /// <param name="prefix">The function's prefix.</param>
        /// <param name="trimExtensionName">Whether or not the extension name should be trimmed.</param>
        /// <param name="trimDataType">Whether or not the data type should be trimmed.</param>
        /// <returns>A trimmed string.</returns>
        public static string Trim
            (string functionName, string prefix, bool trimExtensionName = true, bool trimDataType = true)
        {
            return GetNameVariations(functionName, prefix, trimExtensionName, trimDataType).Last();
        }
    }
}
