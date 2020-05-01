// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags()]
    public enum BufferCreateFlags
    {
        BufferCreateSparseBindingBit = 1,
        BufferCreateSparseResidencyBit = 2,
        BufferCreateSparseAliasedBit = 4,
        BufferCreateDeviceAddressCaptureReplayBitExt = 16,
        BufferCreateDeviceAddressCaptureReplayBitKhr = 16,
        BufferCreateProtectedBit = 8,
        BufferCreateDeviceAddressCaptureReplayBit = 16,
    }
}
