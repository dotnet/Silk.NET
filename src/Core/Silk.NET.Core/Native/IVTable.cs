// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using Silk.NET.Core.Contexts;

namespace Silk.NET.Core.Native
{
    /// <summary>
    /// A VTable, see SilkTouch documentation and https://ultz.co.uk/blog/silktouch-slots-vtables/
    /// </summary>
    public interface IVTable : IDisposable
    {
        /// <summary>
        /// Initializes the VTable with the given context and max slot count.
        /// </summary>
        /// <param name="ctx">The context.</param>
        /// <param name="maxSlots">The max slot count.</param>
        void Initialize(INativeContext ctx, int maxSlots);
        
        /// <summary>
        /// Loads a given slot with a given name/entrypoint.
        /// </summary>
        /// <param name="slot">The slot to load.</param>
        /// <param name="entryPoint">The name to load.</param>
        /// <returns>The Address that was loaded.</returns>
        IntPtr Load(int slot, string entryPoint);
        
        /// <summary>
        /// Resets the VTable. Does not reset the parameters given in <see cref="Initialize" />
        /// </summary>
        void Purge();
    }
}
