// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

namespace Silk.NET.Input.Common
{
    public struct Thumbstick
    {
        public int Index { get; }
        public float Position { get; }
        public float Direction { get; }

        public Thumbstick(int index, float position, float direction)
        {
            Index = index;
            Position = position;
            Direction = direction;
        }
    }
}