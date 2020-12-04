// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

namespace Silk.NET.Input.Common
{
    /// <summary>
    /// Represents an axis on a joystick.
    /// </summary>
    public struct Axis
    {
        /// <summary>
        /// The index of this axis, used to determine which axis it is.
        /// </summary>
        public int Index { get; }

        /// <summary>
        /// The position of this axis.
        /// </summary>
        public float Position { get; }

        /// <summary>
        /// Creates a new instance of the Axis struct.
        /// </summary>
        /// <param name="index">The index of the new axis.</param>
        /// <param name="position">The position of the new axis.</param>
        public Axis(int index, float position)
        {
            Index = index;
            Position = position;
        }
    }
}