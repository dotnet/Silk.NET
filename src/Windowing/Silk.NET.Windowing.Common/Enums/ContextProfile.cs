//
// This file is part of Silk.NET.
//
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
//

namespace Silk.NET.Windowing.Common
{
    /// <summary>
    /// Represents the context profile OpenGL should use.
    /// </summary>
    public enum ContextProfile
    {
        /// <summary>
        /// Uses a core OpenGL context, which removes some deprecated functionality.
        /// </summary>
        Core = 0,

        /// <summary>
        /// Uses a compatability OpenGL context, allowing for some deprecated functionality. This should only ever be
        /// used for maintaining legacy code; no newly-written software should use this.
        /// </summary>
        Compatability,
    }
}