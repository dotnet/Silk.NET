// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

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
        VResize,

        /// <summary>
        /// Top-left to bottom-right diagonal resize/move arrow cursor.
        /// </summary>
        NwseResize,

        /// <summary>
        /// Top-right to bottom-left diagonal resize/move arrow cursor.
        /// </summary>
        NeswResize,

        /// <summary>
        /// Omni-directional resize/move cursor.
        /// </summary>
        ResizeAll,
        
        /// <summary>
        /// Operation not allowed cursor.
        /// </summary>
        NotAllowed,
        
        /// <summary>
        /// Hourglass/waiting cursor.
        /// </summary>
        Wait,
        
        /// <summary>
        /// Regular arrow but with an hourglass/waiting icon cursor.
        /// </summary>
        WaitArrow
    }
}
