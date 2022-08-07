// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
using System;
using Silk.NET.Maths;

namespace Silk.NET.Windowing
{
    /// <summary>
    /// Represents a screens supported refresh rate and resolution
    /// </summary>
    public readonly struct VideoMode
    {
        /// <summary>
        /// Creates a <see cref="VideoMode"/> with a resolution and refreshRate parameter.
        /// </summary>
        /// <param name="resolution">The dimensions of the VideoMode in question</param>
        /// <param name="refreshRate">How many times per second the screen refreshes</param>
        public VideoMode(Vector2D<int>? resolution = null, int? refreshRate = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a <see cref="VideoMode"/> with a refreshRate parameter.
        /// </summary>
        /// <param name="refreshRate">How many times per second the screen refreshes</param>
        public VideoMode(int? refreshRate)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Resolution of the full screen window.
        /// </summary>
        public Vector2D<int>? Resolution { get; init; }

        /// <summary>
        /// Refresh rate of the full screen window in Hz.
        /// </summary>
        public int? RefreshRate { get; init; }

        /// <summary>
        /// The default video mode. This uses the window size for resolution and doesn't care about other values.
        /// </summary>
        public static VideoMode Default { get; }
    }
}
