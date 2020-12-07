// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

namespace Silk.NET.Input
{
    /// <summary>
    /// Standard cursors.
    /// </summary>
    /// <remarks>
    /// Not every backend supports every standard cursor. Check availability with
    /// <see cref="ICursor.IsSupported(StandardCursor)"/> before changing to a standard cursor.
    /// </remarks>
    public enum StandardCursor
    {
        /// <summary>
        /// Default cursor.
        /// </summary>
        Default,

        /// <summary>
        /// Regular arrow cursor.
        /// </summary>
        Arrow,

        /// <summary>
        /// Text input I-beam cursor.
        /// </summary>
        IBeam,

        /// <summary>
        /// Crosshair cursor.
        /// </summary>
        Crosshair,

        /// <summary>
        /// Hand cursor.
        /// </summary>
        Hand,

        /// <summary>
        /// Horizontal resize arrow cursor.
        /// </summary>
        HResize,

        /// <summary>
        /// Vertical resize arrow cursor.
        /// </summary>
        VResize
    }
}
