// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

namespace Silk.NET.Input.Common
{
    /// <summary>
    /// Represents a joystick hat.
    /// </summary>
    public struct Hat
    {
        /// <summary>
        /// The index of this hat.
        /// </summary>
        public int Index { get; }

        /// <summary>
        /// The position of this hat.
        /// </summary>
        public Position2D Position { get; }

        /// <summary>
        /// Creates a new instance of the Hat struct.
        /// </summary>
        /// <param name="index">The index of the hat.</param>
        /// <param name="position">The position of the hat.</param>
        public Hat(int index, Position2D position)
        {
            Index = index;
            Position = position;
        }
    }
}