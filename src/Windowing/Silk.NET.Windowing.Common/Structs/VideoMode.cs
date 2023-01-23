// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using Silk.NET.Maths;

namespace Silk.NET.Windowing
{
    public struct VideoMode
    {
        public VideoMode(Vector2D<int>? resolution = null, int? refreshRate = null)
        {
            Resolution = resolution;
            RefreshRate = refreshRate;
            AspectRatioEstimate = resolution != null ? CalculateAspectRatio(resolution.Value) : null;
        }

        public VideoMode(int refreshRate)
            : this(null, refreshRate) { }

        /// <summary>
        /// Resolution of the full screen window.
        /// </summary>
        public Vector2D<int>? Resolution { get; }

        /// <summary>
        /// Refresh rate of the full screen window in Hz.
        /// </summary>
        public int? RefreshRate { get; }

        /// <summary>
        /// Aspect ratio of the full screen window. This value will not be 100% accurate to the actual value, however
        /// is more accurate to what a user may expect the ratio to be (for example a resolution of 1366x768 will appear
        /// as 16:9, even though it is not quite 16:9 in reality).
        /// </summary>
        public Vector2D<int>? AspectRatioEstimate { get; }

        /// <summary>
        /// The default video mode. This uses the window size for resolution and doesn't care about other values.
        /// </summary>
        public static VideoMode Default => new VideoMode();

        private static Vector2D<int> CalculateAspectRatio(Vector2D<int> res)
        {
            // Calculate the width-height ratio.
            float ratio = res.X / (float) res.Y;

            // Count up until the lowest value as the aspect ratio cannot be higher than the lowest value.
            int lowestValue = res.X < res.Y ? res.X : res.Y;
            for (int i = 1; i < lowestValue; i++)
            {
                // Multiply both together and calculate a good enough value, a bias of 0.1 seems to work well.
                float multiplied = ratio * i;
                if (multiplied - (int) multiplied < 0.1f)
                    return new Vector2D<int>((int) multiplied, i);
            }

            return res;
        }

    }
}
