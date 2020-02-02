// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

namespace Silk.NET.Input.Common
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
        /// Width of the cursor in pixels.
        /// </summary>
        /// <remarks>
        /// Is only used if <see cref="Type"/> is <see cref="CursorType.Custom"/>.
        /// </remarks>
        int Width { get; set; }

        /// <summary>
        /// Height of the cursor in pixels.
        /// </summary>
        /// <remarks>
        /// Is only used if <see cref="Type"/> is <see cref="CursorType.Custom"/>.
        /// </remarks>
        int Height { get; set; }

        /// <summary>
        /// Image data for the cursor.
        /// </summary>
        /// <remarks>
        /// The image MUST be in 32-bit RGBA, non-premultiplied, and in little-endian format.
        /// Is only used if <see cref="Type"/> is <see cref="CursorType.Custom"/>.
        /// </remarks>
        byte[] Pixels { get; set; }

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
