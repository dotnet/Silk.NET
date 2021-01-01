// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXGI
{
    [NativeName("Name", "DXGI_OUTDUPL_POINTER_SHAPE_TYPE")]
    public enum OutduplPointerShapeType : int
    {
        [NativeName("Name", "DXGI_OUTDUPL_POINTER_SHAPE_TYPE_MONOCHROME")]
        OutduplPointerShapeTypeMonochrome = 0x1,
        [NativeName("Name", "DXGI_OUTDUPL_POINTER_SHAPE_TYPE_COLOR")]
        OutduplPointerShapeTypeColor = 0x2,
        [NativeName("Name", "DXGI_OUTDUPL_POINTER_SHAPE_TYPE_MASKED_COLOR")]
        OutduplPointerShapeTypeMaskedColor = 0x4,
    }
}
