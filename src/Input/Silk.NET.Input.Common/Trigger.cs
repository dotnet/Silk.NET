// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

namespace Silk.NET.Input.Common
{
    public struct Trigger
    {
        public int Index { get; }
        public float Position { get; }

        public Trigger(int index, float position)
        {
            Index = index;
            Position = position;
        }
    }
}