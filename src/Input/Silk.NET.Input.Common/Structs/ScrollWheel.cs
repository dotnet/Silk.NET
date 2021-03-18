// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Input
{
    /// <summary>
    /// Represents a scroll wheel.
    /// </summary>
    public struct ScrollWheel
    {
        /// <summary>
        /// The X position of the scroll wheel.
        /// </summary>
        public float X { get; }

        /// <summary>
        /// The Y position of the scroll wheel.
        /// </summary>
        public float Y { get; }

        /// <summary>
        /// Creates a new instance of the scroll wheel struct.
        /// </summary>
        /// <param name="x">The X position of the scroll wheel.</param>
        /// <param name="y">The Y position of the scroll wheel.</param>
        public ScrollWheel(float x, float y)
        {
            X = x;
            Y = y;
        }
    }
}
