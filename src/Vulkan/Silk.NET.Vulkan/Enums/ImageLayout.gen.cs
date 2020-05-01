// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    public enum ImageLayout
    {
        Undefined = 0,
        General = 1,
        ColorAttachmentOptimal = 2,
        DepthStencilAttachmentOptimal = 3,
        DepthStencilReadOnlyOptimal = 4,
        ShaderReadOnlyOptimal = 5,
        TransferSrcOptimal = 6,
        TransferDstOptimal = 7,
        Preinitialized = 8,
        PresentSrcKhr = 1000001002,
        SharedPresentKhr = 1000111000,
        DepthReadOnlyStencilAttachmentOptimalKhr = 1000117000,
        DepthAttachmentStencilReadOnlyOptimalKhr = 1000117001,
        ShadingRateOptimalNV = 1000164003,
        FragmentDensityMapOptimalExt = 1000218000,
        DepthAttachmentOptimalKhr = 1000241000,
        DepthReadOnlyOptimalKhr = 1000241001,
        StencilAttachmentOptimalKhr = 1000241002,
        StencilReadOnlyOptimalKhr = 1000241003,
        DepthReadOnlyStencilAttachmentOptimal = 1000117000,
        DepthAttachmentStencilReadOnlyOptimal = 1000117001,
        DepthAttachmentOptimal = 1000241000,
        DepthReadOnlyOptimal = 1000241001,
        StencilAttachmentOptimal = 1000241002,
        StencilReadOnlyOptimal = 1000241003,
    }
}
