// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL Core Profile headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[Transformed]
public enum TextureLayout
{
    GeneralEXT = 0x958D,
    ColorAttachmentEXT = 0x958E,
    DepthStencilAttachmentEXT = 0x958F,
    DepthStencilReadOnlyEXT = 0x9590,
    ShaderReadOnlyEXT = 0x9591,
    TransferSrcEXT = 0x9592,
    TransferDstEXT = 0x9593,
    DepthReadOnlyStencilAttachmentEXT = 0x9530,
    DepthAttachmentStencilReadOnlyEXT = 0x9531
}
