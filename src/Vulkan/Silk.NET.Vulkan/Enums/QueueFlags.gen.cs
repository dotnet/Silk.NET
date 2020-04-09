// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

namespace Silk.NET.Vulkan
{
    [Flags()]
    public enum QueueFlags
    {
        QueueGraphicsBit = 1,
        QueueComputeBit = 2,
        QueueTransferBit = 4,
        QueueSparseBindingBit = 8,
        QueueReserved6BitKhr = 64,
        QueueReserved5BitKhr = 32,
        QueueProtectedBit = 16,
    }
}
