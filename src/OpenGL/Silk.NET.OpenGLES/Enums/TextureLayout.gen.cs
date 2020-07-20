// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "TextureLayout")]
    public enum TextureLayout
    {
        [NativeName("Name", "GL_LAYOUT_DEPTH_READ_ONLY_STENCIL_ATTACHMENT_EXT")]
        LayoutDepthReadOnlyStencilAttachmentExt = 0x9530,
        [NativeName("Name", "GL_LAYOUT_DEPTH_ATTACHMENT_STENCIL_READ_ONLY_EXT")]
        LayoutDepthAttachmentStencilReadOnlyExt = 0x9531,
        [NativeName("Name", "GL_LAYOUT_GENERAL_EXT")]
        LayoutGeneralExt = 0x958D,
        [NativeName("Name", "GL_LAYOUT_COLOR_ATTACHMENT_EXT")]
        LayoutColorAttachmentExt = 0x958E,
        [NativeName("Name", "GL_LAYOUT_DEPTH_STENCIL_ATTACHMENT_EXT")]
        LayoutDepthStencilAttachmentExt = 0x958F,
        [NativeName("Name", "GL_LAYOUT_DEPTH_STENCIL_READ_ONLY_EXT")]
        LayoutDepthStencilReadOnlyExt = 0x9590,
        [NativeName("Name", "GL_LAYOUT_SHADER_READ_ONLY_EXT")]
        LayoutShaderReadOnlyExt = 0x9591,
        [NativeName("Name", "GL_LAYOUT_TRANSFER_SRC_EXT")]
        LayoutTransferSrcExt = 0x9592,
        [NativeName("Name", "GL_LAYOUT_TRANSFER_DST_EXT")]
        LayoutTransferDstExt = 0x9593,
    }
}
