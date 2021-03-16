// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.GLFW
{
    /// <summary>
    /// Represents an image.
    /// </summary>
    public struct Image
    {
        /// <summary>
        /// Gets or sets the width of this image in pixels.
        /// </summary>
        public int Width { get; set; }

        /// <summary>
        /// Gets or sets the height of this image in pixels.
        /// </summary>
        public int Height { get; set; }

        /// <summary>
        /// Gets or sets the image's bytes.
        /// </summary>
        public unsafe byte* Pixels { get; set; }
    }
}
