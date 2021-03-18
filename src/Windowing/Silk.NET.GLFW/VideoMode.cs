// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Runtime.InteropServices;

namespace Silk.NET.GLFW
{
    /// <summary>
    /// Replicated handle to a GLFW VideoMode.
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct VideoMode
    {
        /// <summary>
        /// Gets the width, in screen coordinates, of the <see cref="VideoMode" />.
        /// </summary>
        public int Width { get; }

        /// <summary>
        /// Gets the height, in screen coordinates, of the <see cref="VideoMode" />.
        /// </summary>
        public int Height { get; }

        /// <summary>
        /// Gets the bit depth of the red channel of the <see cref="VideoMode" />.
        /// </summary>
        public int RedBits { get; }

        /// <summary>
        /// Gets the bit depth of the green channel of the <see cref="VideoMode" />.
        /// </summary>
        public int GreenBits { get; }

        /// <summary>
        /// Gets the bit depth of the blue channel of the <see cref="VideoMode" />.
        /// </summary>
        public int BlueBits { get; }

        /// <summary>
        /// Gets the refresh rate, in Hz, of the <see cref="VideoMode" />.
        /// </summary>
        public int RefreshRate { get; }
    }
}