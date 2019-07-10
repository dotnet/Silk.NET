// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

namespace Silk.NET.Input.Common
{
    public struct ScrollWheel
    {
        public float X { get; }
        public float Y { get; }

        public ScrollWheel(float x, float y)
        {
            X = x;
            Y = y;
        }
    }
}