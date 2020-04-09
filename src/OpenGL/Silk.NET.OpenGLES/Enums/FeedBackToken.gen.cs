// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

namespace Silk.NET.OpenGLES
{
    public enum FeedBackToken
    {
        PassThroughToken = 0x700,
        PointToken = 0x701,
        LineToken = 0x702,
        PolygonToken = 0x703,
        BitmapToken = 0x704,
        DrawPixelToken = 0x705,
        CopyPixelToken = 0x706,
        LineResetToken = 0x707,
    }
}
