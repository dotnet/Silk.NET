// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Linq;

namespace Silk.NET.Core
{
    /// <summary>
    /// Represents loaded, uncompressed, processed image data.
    /// </summary>
    public readonly struct RawImage : IEquatable<RawImage>
    {
        /// <summary>
        /// Creates a <see cref="RawImage"/> given pixel data and pixel dimensions.
        /// </summary>
        /// <param name="width">The width of the image.</param>
        /// <param name="height">The height of the image.</param>
        /// <param name="rgbaPixels">The image daqta.</param>
        public RawImage(int width, int height, Memory<byte> rgbaPixels)
        {
            Pixels = rgbaPixels;
            Width = width;
            Height = height;
        }

        /// <summary>
        /// The width of the image in pixels
        /// </summary>
        public int Width { get; }
        /// <summary>
        /// The height of the image in pixels.
        /// </summary>
        public int Height { get; }

        /// <summary>
        /// The image data.
        /// </summary>
        public Memory<byte> Pixels { get; }

        /// <summary>
        /// Checks whether the two given <see cref="RawImage"/>s are equal.
        /// </summary>
        /// <param name="left">The first raw image.</param>
        /// <param name="right">The second raw image to compare the first against.</param>
        /// <returns>True if they are equal, false otherwise.</returns>
        /// <remarks>
        /// This does not check whether the byte arrays are equal, only whether their references are the same.
        /// </remarks>  
        public static bool operator ==(RawImage left, RawImage right) => left.Equals(right);

        /// <summary>
        /// Checks whether the two given <see cref="RawImage"/>s are not equal.
        /// </summary>
        /// <param name="left">The first raw image.</param>
        /// <param name="right">The second raw image to compare the first against.</param>
        /// <returns>True if they are not equal, false otherwise.</returns>
        /// <remarks>
        /// This does not check whether the byte arrays are equal, only whether their references are the same.
        /// </remarks>
        public static bool operator !=(RawImage left, RawImage right) => !(left == right);

        /// <summary>
        /// Checks whether the given <see cref="RawImage"/> is equal to this one.
        /// </summary>
        /// <param name="other">The raw image to compare this raw image against.</param>
        /// <returns>True if they are equal, false otherwise.</returns>
        /// <remarks>
        /// This does not check whether the byte arrays have equal, only whether their references are the same.
        /// </remarks>  
        public bool Equals(RawImage other)
        {
            return Width == other.Width && Height == other.Height && Equals(Pixels, other.Pixels);
        }

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            return obj is RawImage other && Equals(other);
        }

        /// <inheritdoc />
        public override int GetHashCode() => HashCode.Combine(Width, Height, Pixels);
    }
}
