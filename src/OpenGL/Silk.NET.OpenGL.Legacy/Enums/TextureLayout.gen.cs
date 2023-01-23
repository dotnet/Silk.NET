// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "TextureLayout")]
    public enum TextureLayout : int
    {
        [Obsolete("Deprecated in favour of \"DepthReadOnlyStencilAttachmentExt\"")]
        [NativeName("Name", "GL_LAYOUT_DEPTH_READ_ONLY_STENCIL_ATTACHMENT_EXT")]
        LayoutDepthReadOnlyStencilAttachmentExt = 0x9530,
        [Obsolete("Deprecated in favour of \"DepthAttachmentStencilReadOnlyExt\"")]
        [NativeName("Name", "GL_LAYOUT_DEPTH_ATTACHMENT_STENCIL_READ_ONLY_EXT")]
        LayoutDepthAttachmentStencilReadOnlyExt = 0x9531,
        [Obsolete("Deprecated in favour of \"GeneralExt\"")]
        [NativeName("Name", "GL_LAYOUT_GENERAL_EXT")]
        LayoutGeneralExt = 0x958D,
        [Obsolete("Deprecated in favour of \"ColorAttachmentExt\"")]
        [NativeName("Name", "GL_LAYOUT_COLOR_ATTACHMENT_EXT")]
        LayoutColorAttachmentExt = 0x958E,
        [Obsolete("Deprecated in favour of \"DepthStencilAttachmentExt\"")]
        [NativeName("Name", "GL_LAYOUT_DEPTH_STENCIL_ATTACHMENT_EXT")]
        LayoutDepthStencilAttachmentExt = 0x958F,
        [Obsolete("Deprecated in favour of \"DepthStencilReadOnlyExt\"")]
        [NativeName("Name", "GL_LAYOUT_DEPTH_STENCIL_READ_ONLY_EXT")]
        LayoutDepthStencilReadOnlyExt = 0x9590,
        [Obsolete("Deprecated in favour of \"ShaderReadOnlyExt\"")]
        [NativeName("Name", "GL_LAYOUT_SHADER_READ_ONLY_EXT")]
        LayoutShaderReadOnlyExt = 0x9591,
        [Obsolete("Deprecated in favour of \"TransferSrcExt\"")]
        [NativeName("Name", "GL_LAYOUT_TRANSFER_SRC_EXT")]
        LayoutTransferSrcExt = 0x9592,
        [Obsolete("Deprecated in favour of \"TransferDstExt\"")]
        [NativeName("Name", "GL_LAYOUT_TRANSFER_DST_EXT")]
        LayoutTransferDstExt = 0x9593,
        [NativeName("Name", "GL_LAYOUT_DEPTH_READ_ONLY_STENCIL_ATTACHMENT_EXT")]
        DepthReadOnlyStencilAttachmentExt = 0x9530,
        [NativeName("Name", "GL_LAYOUT_DEPTH_ATTACHMENT_STENCIL_READ_ONLY_EXT")]
        DepthAttachmentStencilReadOnlyExt = 0x9531,
        [NativeName("Name", "GL_LAYOUT_GENERAL_EXT")]
        GeneralExt = 0x958D,
        [NativeName("Name", "GL_LAYOUT_COLOR_ATTACHMENT_EXT")]
        ColorAttachmentExt = 0x958E,
        [NativeName("Name", "GL_LAYOUT_DEPTH_STENCIL_ATTACHMENT_EXT")]
        DepthStencilAttachmentExt = 0x958F,
        [NativeName("Name", "GL_LAYOUT_DEPTH_STENCIL_READ_ONLY_EXT")]
        DepthStencilReadOnlyExt = 0x9590,
        [NativeName("Name", "GL_LAYOUT_SHADER_READ_ONLY_EXT")]
        ShaderReadOnlyExt = 0x9591,
        [NativeName("Name", "GL_LAYOUT_TRANSFER_SRC_EXT")]
        TransferSrcExt = 0x9592,
        [NativeName("Name", "GL_LAYOUT_TRANSFER_DST_EXT")]
        TransferDstExt = 0x9593,
    }
}
