// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

namespace Silk.NET.Input.Common
{
    public struct Hat
    {
        public int Index { get; }
        public Position2D Position { get; }

        public Hat(int index, Position2D position)
        {
            Index = index;
            Position = position;
        }
    }
}