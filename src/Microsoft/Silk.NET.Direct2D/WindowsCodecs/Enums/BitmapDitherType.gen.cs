// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WindowsCodecs
{
    [NativeName("Name", "WICBitmapDitherType")]
    public enum BitmapDitherType : int
    {
        [NativeName("Name", "WICBitmapDitherTypeNone")]
        BitmapDitherTypeNone = 0x0,
        [NativeName("Name", "WICBitmapDitherTypeSolid")]
        BitmapDitherTypeSolid = 0x0,
        [NativeName("Name", "WICBitmapDitherTypeOrdered4x4")]
        BitmapDitherTypeOrdered4x4 = 0x1,
        [NativeName("Name", "WICBitmapDitherTypeOrdered8x8")]
        BitmapDitherTypeOrdered8x8 = 0x2,
        [NativeName("Name", "WICBitmapDitherTypeOrdered16x16")]
        BitmapDitherTypeOrdered16x16 = 0x3,
        [NativeName("Name", "WICBitmapDitherTypeSpiral4x4")]
        BitmapDitherTypeSpiral4x4 = 0x4,
        [NativeName("Name", "WICBitmapDitherTypeSpiral8x8")]
        BitmapDitherTypeSpiral8x8 = 0x5,
        [NativeName("Name", "WICBitmapDitherTypeDualSpiral4x4")]
        BitmapDitherTypeDualSpiral4x4 = 0x6,
        [NativeName("Name", "WICBitmapDitherTypeDualSpiral8x8")]
        BitmapDitherTypeDualSpiral8x8 = 0x7,
        [NativeName("Name", "WICBitmapDitherTypeErrorDiffusion")]
        BitmapDitherTypeErrorDiffusion = 0x8,
        [NativeName("Name", "WICBITMAPDITHERTYPE_FORCE_DWORD")]
        ItmapdithertypeForceDword = 0x7FFFFFFF,
    }
}
