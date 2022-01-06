// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Native
{
    [Flags]
    [NativeName("Name", "D3D_RESOURCE_RETURN_TYPE")]
    public enum D3DResourceReturnType : int
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
        D3D11ReturnTypeUnorm = 0x1,
        [NativeName("Name", "D3D11_RETURN_TYPE_SNORM")]
        D3D11ReturnTypeSNorm = 0x2,
        [NativeName("Name", "D3D11_RETURN_TYPE_SINT")]
        D3D11ReturnTypeSint = 0x3,
        [NativeName("Name", "D3D11_RETURN_TYPE_UINT")]
        D3D11ReturnTypeUint = 0x4,
        [NativeName("Name", "D3D11_RETURN_TYPE_FLOAT")]
        D3D11ReturnTypeFloat = 0x5,
        [NativeName("Name", "D3D11_RETURN_TYPE_MIXED")]
        D3D11ReturnTypeMixed = 0x6,
        [NativeName("Name", "D3D11_RETURN_TYPE_DOUBLE")]
        D3D11ReturnTypeDouble = 0x7,
        [NativeName("Name", "D3D11_RETURN_TYPE_CONTINUED")]
        D3D11ReturnTypeContinued = 0x8,
    }
}
