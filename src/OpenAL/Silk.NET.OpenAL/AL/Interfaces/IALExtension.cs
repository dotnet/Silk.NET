// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using AdvancedDLSupport;
using Silk.NET.Core.Loader;

namespace Silk.NET.OpenAL.Interfaces
{
    /// <summary>
    /// Defines the API surface of an OpenAL extension.
    /// </summary>
    public interface IALExtension
    {
        /// <summary>
        /// Gets the library name container for this extension.
        /// </summary>
        SearchPathContainer SearchPaths { get; }

        /// <summary>
        /// Determines whether or not the named extension is available.
        /// </summary>
        /// <param name="name">The name of the extension.</param>
        /// <returns>true if the extension is available; otherwise, false.</returns>
        bool IsExtensionPresent([CallerFree] string name);

        /// <summary>
        /// Gets the address of an extension function.
        /// </summary>
        /// <param name="name">The name of the function.</param>
        /// <returns>The function pointer.</returns>
        IntPtr GetProcAddress([CallerFree] string name);

        /// <summary>
        /// Gets the value of the named extension enumeration member.
        /// </summary>
        /// <param name="name">The name of the enumeration member.</param>
        /// <returns>The value of the member.</returns>
        int GetEnumValue([CallerFree] string name);
    }
}
