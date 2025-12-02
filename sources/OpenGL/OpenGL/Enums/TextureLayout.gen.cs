// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("TextureLayout")]
public enum TextureLayout : uint
{
    [NativeName("GL_LAYOUT_GENERAL_EXT")]
    GeneralEXT = unchecked((uint)0x958D),

    [NativeName("GL_LAYOUT_COLOR_ATTACHMENT_EXT")]
    ColorAttachmentEXT = unchecked((uint)0x958E),

    [NativeName("GL_LAYOUT_DEPTH_STENCIL_ATTACHMENT_EXT")]
    DepthStencilAttachmentEXT = unchecked((uint)0x958F),

    [NativeName("GL_LAYOUT_DEPTH_STENCIL_READ_ONLY_EXT")]
    DepthStencilReadOnlyEXT = unchecked((uint)0x9590),

    [NativeName("GL_LAYOUT_SHADER_READ_ONLY_EXT")]
    ShaderReadOnlyEXT = unchecked((uint)0x9591),

    [NativeName("GL_LAYOUT_TRANSFER_SRC_EXT")]
    TransferSrcEXT = unchecked((uint)0x9592),

    [NativeName("GL_LAYOUT_TRANSFER_DST_EXT")]
    TransferDstEXT = unchecked((uint)0x9593),

    [NativeName("GL_LAYOUT_DEPTH_READ_ONLY_STENCIL_ATTACHMENT_EXT")]
    DepthReadOnlyStencilAttachmentEXT = unchecked((uint)0x9530),

    [NativeName("GL_LAYOUT_DEPTH_ATTACHMENT_STENCIL_READ_ONLY_EXT")]
    DepthAttachmentStencilReadOnlyEXT = unchecked((uint)0x9531),
}
