// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D_RESOURCE_RETURN_TYPE")]
    public enum D3DResourceReturnType
    {
        [NativeName("Name", "D3D_RETURN_TYPE_UNORM")]
        D3DReturnTypeUnorm = 0x1,
        [NativeName("Name", "D3D_RETURN_TYPE_SNORM")]
        D3DReturnTypeSNorm = 0x2,
        [NativeName("Name", "D3D_RETURN_TYPE_SINT")]
        D3DReturnTypeSint = 0x3,
        [NativeName("Name", "D3D_RETURN_TYPE_UINT")]
        D3DReturnTypeUint = 0x4,
        [NativeName("Name", "D3D_RETURN_TYPE_FLOAT")]
        D3DReturnTypeFloat = 0x5,
        [NativeName("Name", "D3D_RETURN_TYPE_MIXED")]
        D3DReturnTypeMixed = 0x6,
        [NativeName("Name", "D3D_RETURN_TYPE_DOUBLE")]
        D3DReturnTypeDouble = 0x7,
        [NativeName("Name", "D3D_RETURN_TYPE_CONTINUED")]
        D3DReturnTypeContinued = 0x8,
        [NativeName("Name", "D3D10_RETURN_TYPE_UNORM")]
        D3D10ReturnTypeUnorm = 0x1,
        [NativeName("Name", "D3D10_RETURN_TYPE_SNORM")]
        D3D10ReturnTypeSNorm = 0x2,
        [NativeName("Name", "D3D10_RETURN_TYPE_SINT")]
        D3D10ReturnTypeSint = 0x3,
        [NativeName("Name", "D3D10_RETURN_TYPE_UINT")]
        D3D10ReturnTypeUint = 0x4,
        [NativeName("Name", "D3D10_RETURN_TYPE_FLOAT")]
        D3D10ReturnTypeFloat = 0x5,
        [NativeName("Name", "D3D10_RETURN_TYPE_MIXED")]
        D3D10ReturnTypeMixed = 0x6,
        [NativeName("Name", "D3D11_RETURN_TYPE_UNORM")]
        ReturnTypeUnorm = 0x1,
        [NativeName("Name", "D3D11_RETURN_TYPE_SNORM")]
        ReturnTypeSNorm = 0x2,
        [NativeName("Name", "D3D11_RETURN_TYPE_SINT")]
        ReturnTypeSint = 0x3,
        [NativeName("Name", "D3D11_RETURN_TYPE_UINT")]
        ReturnTypeUint = 0x4,
        [NativeName("Name", "D3D11_RETURN_TYPE_FLOAT")]
        ReturnTypeFloat = 0x5,
        [NativeName("Name", "D3D11_RETURN_TYPE_MIXED")]
        ReturnTypeMixed = 0x6,
        [NativeName("Name", "D3D11_RETURN_TYPE_DOUBLE")]
        ReturnTypeDouble = 0x7,
        [NativeName("Name", "D3D11_RETURN_TYPE_CONTINUED")]
        ReturnTypeContinued = 0x8,
    }
}
