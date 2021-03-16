// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Core;

namespace Silk.NET.Input
{
    /// <summary>
    /// An interface representing a mouse cursor.
    /// </summary>
    public interface ICursor
    {
        /// <summary>
        /// Type of the cursor.
        /// </summary>
        CursorType Type { get; set; }

        /// <summary>
        /// Standard cursor to use.
        /// </summary>
        /// <remarks>
        /// Is only used if <see cref="Type"/> is <see cref="CursorType.Standard"/>.
        /// </remarks>
        StandardCursor StandardCursor { get; set; }

        /// <summary>
        /// Mode of the cursor.
        /// </summary>
        /// <remarks>
        /// See <see cref="CursorMode"/> for details.
        /// </remarks>
        CursorMode CursorMode { get; set; }

        /// <summary>
        /// Determines whether the cursor is locked to the bounds of the view/window of this input context.
        /// </summary>
        /// <remarks>
        /// Only supported by SDL, will have no effect on GLFW.
        /// </remarks>
        bool IsConfined { get; set; }

        /// <summary>
        /// Hotspot on the X axis.
        /// </summary>
        /// <remarks>
        /// Is only used if <see cref="Type"/> is <see cref="CursorType.Custom"/>.
        /// </remarks>
        int HotspotX { get; set; }

        /// <summary>
        /// Hotspot on the Y axis.
        /// </summary>
        /// <remarks>
        /// Is only used if <see cref="Type"/> is <see cref="CursorType.Custom"/>.
        /// </remarks>
        int HotspotY { get; set; }

        /// <summary>
        /// Image data for the cursor.
        /// </summary>
        /// <remarks>
        /// The image MUST be in 32-bit RGBA, non-premultiplied, and in little-endian format.
        /// Is only used if <see cref="Type"/> is <see cref="CursorType.Custom"/>.
        /// </remarks>
        RawImage Image { get; set; }

        /// <summary>
        /// Checks whether or not a specific <see cref="CursorMode"/> is supported.
        /// </summary>
        /// <param name="mode">The mode to check for.</param>
        /// <returns>Whether or not this mode is supported.</returns>
        bool IsSupported(CursorMode mode);

        /// <summary>
        /// Checks whether or not a specific <see cref="StandardCursor"/> is supported.
        /// </summary>
        /// <param name="standardCursor">The standard cursor to check for.</param>
        /// <returns>Whether or not this standard cursor is supported.</returns>
        bool IsSupported(StandardCursor standardCursor);
    }
}
