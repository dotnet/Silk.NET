// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;

namespace Silk.NET.Core.Contexts
{
    /// <summary>
    /// A native context, serving as the base for loading native addresses.
    /// </summary>
    /// <seealso cref="Silk.NET.Core.Native.IVTable"/>
    public interface INativeContext : IDisposable
    {
        /// <summary>
        /// Loads a native address from the given name and, optionally, the given slot.
        /// </summary>
        /// <param name="proc">The name of the address to be loaded.</param>
        /// <param name="slot">The slot of the address to be loaded. Optional.</param>
        /// <returns>The address to the native function.</returns>
        /// <remarks>
        /// Note to implementors:
        /// This method does receive the slot, but may NEVER cache the address. Caching may result in many critical errors.
        /// </remarks>
        IntPtr GetProcAddress(string proc, int? slot = default);
    }
}
