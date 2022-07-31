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
            AspectRatio = resolution != null ? resolution / GreatestCommonFactor(resolution.Value.X, resolution.Value.Y) : null;
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
        /// Aspect ratio of the full screen window.
        /// </summary>
        public Vector2D<int>? AspectRatio { get; }

        /// <summary>
        /// The default video mode. This uses the window size for resolution and doesn't care about other values.
        /// </summary>
        public static VideoMode Default => new VideoMode();

        private static int GreatestCommonFactor(int value1, int value2)
        {
            while (true)
            {
                if (value2 > value1)
                {
                    int val = value2 - value1;
                    if (val <= 0)
                        return value1;
                    if (val > value1)
                    {
                        value2 = val;
                        continue;
                    }

                    var value3 = value1;
                    value1 = val;
                    value2 = value3;
                }
                else
                {
                    int val = value1 - value2;
                    if (val <= 0)
                        return value2;
                    if (val > value2)
                    {
                        value1 = value2;
                        value2 = val;
                        continue;
                    }

                    value1 = val;
                }
            }
        }
    }
}
