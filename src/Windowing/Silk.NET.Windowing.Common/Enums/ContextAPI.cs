//
// This file is part of Silk.NET.
//
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
//

namespace Silk.NET.Windowing.Common
{
    /// <summary>
    /// Represents which API the graphics context should use.
    /// </summary>
    public enum ContextAPI
    {
        /// <summary>
        /// Use core OpenGL. This is standard for software intended for desktop computers.
        /// </summary>
        OpenGl = 0,

        /// <summary>
        /// Use OpenGL ES. This is standard for software intended to be compatable with embedded systems, such as phones.
        /// </summary>
        OpenGlEs,
    }
}