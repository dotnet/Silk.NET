// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Generator.Common.Functions;
using Generator.Convert.Construction.Trimmers;

namespace Generator.Convert.Construction
{
    /// <summary>
    /// A collection of functions for altering the endings of function names.
    /// </summary>
    public static class NameTrimmer
    {
        /// <summary>
        /// Gets a collection of trimmers supported out-of-the-box.
        /// </summary>
        public static IReadOnlyList<ITrimmer<Function>> FunctionTrimmers { get; } = new ITrimmer<Function>[]
        {
            new ExtensionNameTrimmer(),
            new DataTypeNameTrimmer()
        };

        /// <summary>
        /// Gets a collection of trimmers supported out-of-the-box.
        /// </summary>
        public static IReadOnlyList<ITrimmer<string>> StringTrimmers { get; } = new ITrimmer<string>[]
        {
            new ExtensionNameTrimmer(),
            new DataTypeNameTrimmer()
        };

        /// <summary>
        /// Trims the given functions with the default trimmers.
        /// </summary>
        /// <param name="functions">The functions to trim.</param>
        public static void Trim(IEnumerable<Function> functions)
        {
            Task.WhenAll(functions.Select(FullTrimAsync)).GetAwaiter().GetResult();
        }

        private static async Task FullTrimAsync(Function arg)
        {
            var str = arg.NativeName + string.Empty; // copies the string
            await TrimAsync(str);
            arg.Name = str;
        }

        /// <summary>
        /// Asynchronously trims the given function.
        /// </summary>
        /// <param name="function">The function to trim.</param>
        /// <returns>An asynchronous task.</returns>
        public static Task TrimAsync(Function function)
        {
            foreach (var functionTrimmer in FunctionTrimmers)
            {
                if (functionTrimmer.IsRelevant(function))
                {
                    functionTrimmer.Trim(function);
                }
            }

            return Task.CompletedTask;
        }

        /// <summary>
        /// Trims the given functions with the default trimmers.
        /// </summary>
        /// <param name="functions">The functions to trim.</param>
        public static void Trim(IEnumerable<string> functions)
        {
            Task.WhenAll(functions.Select(TrimAsync)).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Asynchronously trims the given function.
        /// </summary>
        /// <param name="function">The function to trim.</param>
        /// <returns>An asynchronous task.</returns>
        public static Task TrimAsync(string function)
        {
            foreach (var functionTrimmer in StringTrimmers)
            {
                if (functionTrimmer.IsRelevant(function))
                {
                    functionTrimmer.Trim(function);
                }
            }

            return Task.CompletedTask;
        }
    }
}
