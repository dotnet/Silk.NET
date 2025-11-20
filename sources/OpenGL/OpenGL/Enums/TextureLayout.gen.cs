// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum TextureLayout : uint
{
    GeneralEXT = unchecked((uint)0x958D),
    ColorAttachmentEXT = unchecked((uint)0x958E),
    DepthStencilAttachmentEXT = unchecked((uint)0x958F),
    DepthStencilReadOnlyEXT = unchecked((uint)0x9590),
    ShaderReadOnlyEXT = unchecked((uint)0x9591),
    TransferSrcEXT = unchecked((uint)0x9592),
    TransferDstEXT = unchecked((uint)0x9593),
    DepthReadOnlyStencilAttachmentEXT = unchecked((uint)0x9530),
    DepthAttachmentStencilReadOnlyEXT = unchecked((uint)0x9531),
}
