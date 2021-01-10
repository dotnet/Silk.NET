// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

namespace Silk.NET.EGL.Extensions.HI
{
    public unsafe struct ClientPixmapHI
    {
        public void* PData;
        public int Width;
        public int Height;
        public int Stride;
        
        public ClientPixmapHI(void* pData, int width, int height, int stride)
        {
            PData = pData;
            Width = width;
            Height = height;
            Stride = stride;
        }
    }
}
