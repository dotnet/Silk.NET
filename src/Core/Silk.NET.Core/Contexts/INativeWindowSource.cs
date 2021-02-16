// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

namespace Silk.NET.Core.Contexts
{
    public interface INativeWindowSource
    {
        /// <summary>
        /// Gets the <see cref="INativeWindow"/> instance representing the underlying native window handle(s), or null
        /// if a native window has not been created (i.e. because the window has not been initialized yet)
        /// </summary>
        public INativeWindow? Native { get; }
    }
}
