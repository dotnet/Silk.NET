// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    public enum TextureLayout
    {
        LayoutDepthReadOnlyStencilAttachmentExt = 0x9530,
        LayoutDepthAttachmentStencilReadOnlyExt = 0x9531,
        LayoutGeneralExt = 0x958D,
        LayoutColorAttachmentExt = 0x958E,
        LayoutDepthStencilAttachmentExt = 0x958F,
        LayoutDepthStencilReadOnlyExt = 0x9590,
        LayoutShaderReadOnlyExt = 0x9591,
        LayoutTransferSrcExt = 0x9592,
        LayoutTransferDstExt = 0x9593,
    }
}
