// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

namespace Silk.NET.Vulkan
{
    [Flags()]
    public enum ImageUsageFlags
    {
        ImageUsageTransferSrcBit = 1,
        ImageUsageTransferDstBit = 2,
        ImageUsageSampledBit = 4,
        ImageUsageStorageBit = 8,
        ImageUsageColorAttachmentBit = 16,
        ImageUsageDepthStencilAttachmentBit = 32,
        ImageUsageTransientAttachmentBit = 64,
        ImageUsageInputAttachmentBit = 128,
        ImageUsageReserved13BitKhr = 8192,
        ImageUsageReserved14BitKhr = 16384,
        ImageUsageReserved15BitKhr = 32768,
        ImageUsageReserved10BitKhr = 1024,
        ImageUsageReserved11BitKhr = 2048,
        ImageUsageReserved12BitKhr = 4096,
        ImageUsageShadingRateImageBitNV = 256,
        ImageUsageReserved16BitQCom = 65536,
        ImageUsageReserved17BitQCom = 131072,
        ImageUsageFragmentDensityMapBitExt = 512,
    }
}
