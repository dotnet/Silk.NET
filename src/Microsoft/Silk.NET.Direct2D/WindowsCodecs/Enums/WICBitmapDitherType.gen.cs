// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WindowsCodecs
{
    [NativeName("Name", "WICBitmapDitherType")]
    public enum WICBitmapDitherType : int
    {
        [Obsolete("Deprecated in favour of \"BitmapDitherTypeNone\"")]
        [NativeName("Name", "WICBitmapDitherTypeNone")]
        WicbitmapDitherTypeNone = 0x0,
        [Obsolete("Deprecated in favour of \"BitmapDitherTypeSolid\"")]
        [NativeName("Name", "WICBitmapDitherTypeSolid")]
        WicbitmapDitherTypeSolid = 0x0,
        [Obsolete("Deprecated in favour of \"BitmapDitherTypeOrdered4x4\"")]
        [NativeName("Name", "WICBitmapDitherTypeOrdered4x4")]
        WicbitmapDitherTypeOrdered4x4 = 0x1,
        [Obsolete("Deprecated in favour of \"BitmapDitherTypeOrdered8x8\"")]
        [NativeName("Name", "WICBitmapDitherTypeOrdered8x8")]
        WicbitmapDitherTypeOrdered8x8 = 0x2,
        [Obsolete("Deprecated in favour of \"BitmapDitherTypeOrdered16x16\"")]
        [NativeName("Name", "WICBitmapDitherTypeOrdered16x16")]
        WicbitmapDitherTypeOrdered16x16 = 0x3,
        [Obsolete("Deprecated in favour of \"BitmapDitherTypeSpiral4x4\"")]
        [NativeName("Name", "WICBitmapDitherTypeSpiral4x4")]
        WicbitmapDitherTypeSpiral4x4 = 0x4,
        [Obsolete("Deprecated in favour of \"BitmapDitherTypeSpiral8x8\"")]
        [NativeName("Name", "WICBitmapDitherTypeSpiral8x8")]
        WicbitmapDitherTypeSpiral8x8 = 0x5,
        [Obsolete("Deprecated in favour of \"BitmapDitherTypeDualSpiral4x4\"")]
        [NativeName("Name", "WICBitmapDitherTypeDualSpiral4x4")]
        WicbitmapDitherTypeDualSpiral4x4 = 0x6,
        [Obsolete("Deprecated in favour of \"BitmapDitherTypeDualSpiral8x8\"")]
        [NativeName("Name", "WICBitmapDitherTypeDualSpiral8x8")]
        WicbitmapDitherTypeDualSpiral8x8 = 0x7,
        [Obsolete("Deprecated in favour of \"BitmapDitherTypeErrorDiffusion\"")]
        [NativeName("Name", "WICBitmapDitherTypeErrorDiffusion")]
        WicbitmapDitherTypeErrorDiffusion = 0x8,
        [Obsolete("Deprecated in favour of \"ItmapdithertypeForceDword\"")]
        [NativeName("Name", "WICBITMAPDITHERTYPE_FORCE_DWORD")]
        WicbitmapdithertypeForceDword = 0x7FFFFFFF,
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
