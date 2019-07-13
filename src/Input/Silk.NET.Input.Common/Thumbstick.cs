// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

namespace Silk.NET.Input.Common
{
    /// <summary>
    /// A thumbstick on an <see cref="IGamepad"/>
    /// </summary>
    public struct Thumbstick
    {
        /// <summary>
        /// The index of this stick.
        /// </summary>
        public int Index { get; }
        
        /// <summary>
        /// The current position of the stick, from 0.0 to 1.0.
        /// </summary>
        public float Position { get; }
        
        /// <summary>
        /// The current direction of the stick, from 0.0 to 360.0.
        /// </summary>
        public float Direction { get; }

        /// <summary>
        /// Creates a new instance of the Thumbstick struct.
        /// </summary>
        /// <param name="index">The index of the stick.</param>
        /// <param name="position">The position of the stick.</param>
        /// <param name="direction">The direction of the stick.</param>
        public Thumbstick(int index, float position, float direction)
        {
            Index = index;
            Position = position;
            Direction = direction;
        }
    }
}