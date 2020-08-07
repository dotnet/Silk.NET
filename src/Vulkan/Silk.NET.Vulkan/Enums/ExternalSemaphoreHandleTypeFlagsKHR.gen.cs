// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags()]
    public enum ExternalSemaphoreHandleTypeFlagsKHR
    {
        ExternalSemaphoreHandleTypeOpaqueFDBit = 1,
        ExternalSemaphoreHandleTypeOpaqueWin32Bit = 2,
        ExternalSemaphoreHandleTypeOpaqueWin32KmtBit = 4,
        ExternalSemaphoreHandleTypeD3D12FenceBit = 8,
        ExternalSemaphoreHandleTypeD3D11FenceBit = 8,
        ExternalSemaphoreHandleTypeSyncFDBit = 16,
    }
}
