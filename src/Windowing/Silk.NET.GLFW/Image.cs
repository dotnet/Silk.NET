// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

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
