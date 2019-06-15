//
// This file is part of Silk.NET.
//
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;
using System.Runtime.InteropServices;

namespace Silk.NET.GLFW
{
    /// <summary>
    /// Opaque handle to a GLFW image.
    /// </summary>
    public struct Image : IDisposable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Image"/> struct.
        /// </summary>
        /// <param name="width">The width of the image in pixels.</param>
        /// <param name="height">The height of the image in pixels.</param>
        /// <param name="pixels"><see cref="IntPtr"/> pointing to the RGBA pixel data of the image.</param>
        public Image(int width, int height, IntPtr pixels)
        {
            this.Width = width;
            this.Height = height;
            this.Pixels = pixels;
        }

        /// <summary>
        /// Gets the width, in pixels, of this <see cref="Image"/>.
        /// </summary>
        public int Width { get; }

        /// <summary>
        /// Gets the height, in pixels, of this <see cref="Image"/>.
        /// </summary>
        public int Height { get; }

        /// <summary>
        /// Gets a <see cref="IntPtr"/> pointing to the RGBA pixel data.
        /// </summary>
        public IntPtr Pixels { get; }

        /// <inheritdoc />
        public void Dispose()
        {
            Marshal.FreeHGlobal(Pixels);
        }
    }
}
