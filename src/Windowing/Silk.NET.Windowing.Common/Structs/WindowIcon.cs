// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

namespace Silk.NET.Windowing.Common.Structs
{
    public readonly struct WindowIcon
    {
        public WindowIcon(int width, int height, byte[] rgbaPixels)
        {
            Pixels = rgbaPixels;
            Width = width;
            Height = height;
        }

        public int Width { get; }
        public int Height { get; }
        public byte[] Pixels { get; }
    }
}
