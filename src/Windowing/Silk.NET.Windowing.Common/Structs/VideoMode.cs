// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Maths;

namespace Silk.NET.Windowing
{
    public struct VideoMode
    {
        public VideoMode(Vector2D<int>? resolution = null, int? refreshRate = null)
        {
            Resolution = resolution;
            RefreshRate = refreshRate;
        }

        public VideoMode(int refreshRate)
            : this(null, refreshRate)
        {
        }

        /// <summary>
        /// Resolution of the full screen window.
        /// </summary>
        public Vector2D<int>? Resolution { get; }

        /// <summary>
        /// Refresh rate of the full screen window in Hz.
        /// </summary>
        public int? RefreshRate { get; }

        /// <summary>
        /// The default video mode. This uses the window size for resolution and doesn't care about other values.
        /// </summary>
        public static VideoMode Default => new VideoMode();
    }
}