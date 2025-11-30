// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("TextureLayout")]
[Transformed]
public enum TextureLayout : uint
{
    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_LAYOUT_GENERAL_EXT")]
    Generalext = unchecked((uint)0x958D),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_LAYOUT_COLOR_ATTACHMENT_EXT")]
    ColorAttachmentext = unchecked((uint)0x958E),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_LAYOUT_DEPTH_STENCIL_ATTACHMENT_EXT")]
    DepthStencilAttachmentext = unchecked((uint)0x958F),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_LAYOUT_DEPTH_STENCIL_READ_ONLY_EXT")]
    DepthStencilReadOnlyext = unchecked((uint)0x9590),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_LAYOUT_SHADER_READ_ONLY_EXT")]
    ShaderReadOnlyext = unchecked((uint)0x9591),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_LAYOUT_TRANSFER_SRC_EXT")]
    TransferSrcext = unchecked((uint)0x9592),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_LAYOUT_TRANSFER_DST_EXT")]
    TransferDstext = unchecked((uint)0x9593),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_LAYOUT_DEPTH_READ_ONLY_STENCIL_ATTACHMENT_EXT")]
    DepthReadOnlyStencilAttachmentext = unchecked((uint)0x9530),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_LAYOUT_DEPTH_ATTACHMENT_STENCIL_READ_ONLY_EXT")]
    DepthAttachmentStencilReadOnlyext = unchecked((uint)0x9531),
}
