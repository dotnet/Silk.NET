// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    public enum ExternalHandleType
    {
        HandleTypeOpaqueFDExt = 0x9586,
        HandleTypeOpaqueWin32Ext = 0x9587,
        HandleTypeOpaqueWin32KmtExt = 0x9588,
        HandleTypeD3D12TilepoolExt = 0x9589,
        HandleTypeD3D12ResourceExt = 0x958A,
        HandleTypeD3D11ImageExt = 0x958B,
        HandleTypeD3D11ImageKmtExt = 0x958C,
        HandleTypeD3D12FenceExt = 0x9594,
    }
}
