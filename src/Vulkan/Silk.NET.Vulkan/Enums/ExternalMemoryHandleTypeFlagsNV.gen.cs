// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags()]
    public enum ExternalMemoryHandleTypeFlagsNV
    {
        ExternalMemoryHandleTypeOpaqueWin32BitNV = 1,
        ExternalMemoryHandleTypeOpaqueWin32KmtBitNV = 2,
        ExternalMemoryHandleTypeD3D11ImageBitNV = 4,
        ExternalMemoryHandleTypeD3D11ImageKmtBitNV = 8,
    }
}
