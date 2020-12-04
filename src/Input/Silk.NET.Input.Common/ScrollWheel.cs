// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

namespace Silk.NET.Input.Common
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