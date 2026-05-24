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
    GeneralEXT = 38285,

    [NativeName("GL_LAYOUT_COLOR_ATTACHMENT_EXT")]
    ColorAttachmentEXT = 38286,

    [NativeName("GL_LAYOUT_DEPTH_STENCIL_ATTACHMENT_EXT")]
    DepthStencilAttachmentEXT = 38287,

    [NativeName("GL_LAYOUT_DEPTH_STENCIL_READ_ONLY_EXT")]
    DepthStencilReadOnlyEXT = 38288,

    [NativeName("GL_LAYOUT_SHADER_READ_ONLY_EXT")]
    ShaderReadOnlyEXT = 38289,

    [NativeName("GL_LAYOUT_TRANSFER_SRC_EXT")]
    TransferSrcEXT = 38290,

    [NativeName("GL_LAYOUT_TRANSFER_DST_EXT")]
    TransferDstEXT = 38291,

    [NativeName("GL_LAYOUT_DEPTH_READ_ONLY_STENCIL_ATTACHMENT_EXT")]
    DepthReadOnlyStencilAttachmentEXT = 38192,

    [NativeName("GL_LAYOUT_DEPTH_ATTACHMENT_STENCIL_READ_ONLY_EXT")]
    DepthAttachmentStencilReadOnlyEXT = 38193,
}
