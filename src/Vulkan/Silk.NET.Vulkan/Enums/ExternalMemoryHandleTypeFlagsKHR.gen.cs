// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

namespace Silk.NET.Vulkan
{
    [Flags()]
    public enum ExternalMemoryHandleTypeFlagsKHR
    {
        ExternalMemoryHandleTypeOpaqueFDBit = 1,
        ExternalMemoryHandleTypeOpaqueWin32Bit = 2,
        ExternalMemoryHandleTypeOpaqueWin32KmtBit = 4,
        ExternalMemoryHandleTypeD3D11TextureBit = 8,
        ExternalMemoryHandleTypeD3D11TextureKmtBit = 16,
        ExternalMemoryHandleTypeD3D12HeapBit = 32,
        ExternalMemoryHandleTypeD3D12ResourceBit = 64,
    }
}
