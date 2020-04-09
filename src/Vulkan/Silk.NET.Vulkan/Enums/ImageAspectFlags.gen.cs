// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

namespace Silk.NET.Vulkan
{
    [Flags()]
    public enum ImageAspectFlags
    {
        ImageAspectColorBit = 1,
        ImageAspectDepthBit = 2,
        ImageAspectStencilBit = 4,
        ImageAspectMetadataBit = 8,
        ImageAspectPlane0BitKhr = 16,
        ImageAspectPlane1BitKhr = 32,
        ImageAspectPlane2BitKhr = 64,
        ImageAspectMemoryPlane0BitExt = 128,
        ImageAspectMemoryPlane1BitExt = 256,
        ImageAspectMemoryPlane2BitExt = 512,
        ImageAspectMemoryPlane3BitExt = 1024,
        ImageAspectPlane0Bit = 16,
        ImageAspectPlane1Bit = 32,
        ImageAspectPlane2Bit = 64,
    }
}
