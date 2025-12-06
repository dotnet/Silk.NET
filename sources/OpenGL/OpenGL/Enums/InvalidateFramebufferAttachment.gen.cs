// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("InvalidateFramebufferAttachment")]
public enum InvalidateFramebufferAttachment : uint
{
    [NativeName("GL_COLOR_ATTACHMENT0_OES")]
    ColorAttachment0OES = 36064,

    [NativeName("GL_DEPTH_ATTACHMENT_OES")]
    DepthAttachmentOES = 36096,

    [NativeName("GL_STENCIL_ATTACHMENT_OES")]
    StencilAttachmentOES = 36128,

    [NativeName("GL_COLOR")]
    Color = 6144,

    [NativeName("GL_DEPTH")]
    Depth = 6145,

    [NativeName("GL_STENCIL")]
    Stencil = 6146,

    [NativeName("GL_DEPTH_STENCIL_ATTACHMENT")]
    DepthStencilAttachment = 33306,

    [NativeName("GL_COLOR_ATTACHMENT0")]
    ColorAttachment0 = 36064,

    [NativeName("GL_COLOR_ATTACHMENT1")]
    ColorAttachment1 = 36065,

    [NativeName("GL_COLOR_ATTACHMENT2")]
    ColorAttachment2 = 36066,

    [NativeName("GL_COLOR_ATTACHMENT3")]
    ColorAttachment3 = 36067,

    [NativeName("GL_COLOR_ATTACHMENT4")]
    ColorAttachment4 = 36068,

    [NativeName("GL_COLOR_ATTACHMENT5")]
    ColorAttachment5 = 36069,

    [NativeName("GL_COLOR_ATTACHMENT6")]
    ColorAttachment6 = 36070,

    [NativeName("GL_COLOR_ATTACHMENT7")]
    ColorAttachment7 = 36071,

    [NativeName("GL_COLOR_ATTACHMENT8")]
    ColorAttachment8 = 36072,

    [NativeName("GL_COLOR_ATTACHMENT9")]
    ColorAttachment9 = 36073,

    [NativeName("GL_COLOR_ATTACHMENT10")]
    ColorAttachment10 = 36074,

    [NativeName("GL_COLOR_ATTACHMENT11")]
    ColorAttachment11 = 36075,

    [NativeName("GL_COLOR_ATTACHMENT12")]
    ColorAttachment12 = 36076,

    [NativeName("GL_COLOR_ATTACHMENT13")]
    ColorAttachment13 = 36077,

    [NativeName("GL_COLOR_ATTACHMENT14")]
    ColorAttachment14 = 36078,

    [NativeName("GL_COLOR_ATTACHMENT15")]
    ColorAttachment15 = 36079,

    [NativeName("GL_COLOR_ATTACHMENT16")]
    ColorAttachment16 = 36080,

    [NativeName("GL_COLOR_ATTACHMENT17")]
    ColorAttachment17 = 36081,

    [NativeName("GL_COLOR_ATTACHMENT18")]
    ColorAttachment18 = 36082,

    [NativeName("GL_COLOR_ATTACHMENT19")]
    ColorAttachment19 = 36083,

    [NativeName("GL_COLOR_ATTACHMENT20")]
    ColorAttachment20 = 36084,

    [NativeName("GL_COLOR_ATTACHMENT21")]
    ColorAttachment21 = 36085,

    [NativeName("GL_COLOR_ATTACHMENT22")]
    ColorAttachment22 = 36086,

    [NativeName("GL_COLOR_ATTACHMENT23")]
    ColorAttachment23 = 36087,

    [NativeName("GL_COLOR_ATTACHMENT24")]
    ColorAttachment24 = 36088,

    [NativeName("GL_COLOR_ATTACHMENT25")]
    ColorAttachment25 = 36089,

    [NativeName("GL_COLOR_ATTACHMENT26")]
    ColorAttachment26 = 36090,

    [NativeName("GL_COLOR_ATTACHMENT27")]
    ColorAttachment27 = 36091,

    [NativeName("GL_COLOR_ATTACHMENT28")]
    ColorAttachment28 = 36092,

    [NativeName("GL_COLOR_ATTACHMENT29")]
    ColorAttachment29 = 36093,

    [NativeName("GL_COLOR_ATTACHMENT30")]
    ColorAttachment30 = 36094,

    [NativeName("GL_COLOR_ATTACHMENT31")]
    ColorAttachment31 = 36095,

    [NativeName("GL_DEPTH_ATTACHMENT")]
    DepthAttachment = 36096,

    [NativeName("GL_COLOR_ATTACHMENT0_EXT")]
    ColorAttachment0EXT = 36064,

    [NativeName("GL_COLOR_ATTACHMENT1_EXT")]
    ColorAttachment1EXT = 36065,

    [NativeName("GL_COLOR_ATTACHMENT2_EXT")]
    ColorAttachment2EXT = 36066,

    [NativeName("GL_COLOR_ATTACHMENT3_EXT")]
    ColorAttachment3EXT = 36067,

    [NativeName("GL_COLOR_ATTACHMENT4_EXT")]
    ColorAttachment4EXT = 36068,

    [NativeName("GL_COLOR_ATTACHMENT5_EXT")]
    ColorAttachment5EXT = 36069,

    [NativeName("GL_COLOR_ATTACHMENT6_EXT")]
    ColorAttachment6EXT = 36070,

    [NativeName("GL_COLOR_ATTACHMENT7_EXT")]
    ColorAttachment7EXT = 36071,

    [NativeName("GL_COLOR_ATTACHMENT8_EXT")]
    ColorAttachment8EXT = 36072,

    [NativeName("GL_COLOR_ATTACHMENT9_EXT")]
    ColorAttachment9EXT = 36073,

    [NativeName("GL_COLOR_ATTACHMENT10_EXT")]
    ColorAttachment10EXT = 36074,

    [NativeName("GL_COLOR_ATTACHMENT11_EXT")]
    ColorAttachment11EXT = 36075,

    [NativeName("GL_COLOR_ATTACHMENT12_EXT")]
    ColorAttachment12EXT = 36076,

    [NativeName("GL_COLOR_ATTACHMENT13_EXT")]
    ColorAttachment13EXT = 36077,

    [NativeName("GL_COLOR_ATTACHMENT14_EXT")]
    ColorAttachment14EXT = 36078,

    [NativeName("GL_COLOR_ATTACHMENT15_EXT")]
    ColorAttachment15EXT = 36079,

    [NativeName("GL_DEPTH_ATTACHMENT_EXT")]
    DepthAttachmentEXT = 36096,

    [NativeName("GL_STENCIL_ATTACHMENT_EXT")]
    StencilAttachmentEXT = 36128,

    [NativeName("GL_COLOR_ATTACHMENT0_NV")]
    ColorAttachment0NV = 36064,

    [NativeName("GL_COLOR_ATTACHMENT1_NV")]
    ColorAttachment1NV = 36065,

    [NativeName("GL_COLOR_ATTACHMENT2_NV")]
    ColorAttachment2NV = 36066,

    [NativeName("GL_COLOR_ATTACHMENT3_NV")]
    ColorAttachment3NV = 36067,

    [NativeName("GL_COLOR_ATTACHMENT4_NV")]
    ColorAttachment4NV = 36068,

    [NativeName("GL_COLOR_ATTACHMENT5_NV")]
    ColorAttachment5NV = 36069,

    [NativeName("GL_COLOR_ATTACHMENT6_NV")]
    ColorAttachment6NV = 36070,

    [NativeName("GL_COLOR_ATTACHMENT7_NV")]
    ColorAttachment7NV = 36071,

    [NativeName("GL_COLOR_ATTACHMENT8_NV")]
    ColorAttachment8NV = 36072,

    [NativeName("GL_COLOR_ATTACHMENT9_NV")]
    ColorAttachment9NV = 36073,

    [NativeName("GL_COLOR_ATTACHMENT10_NV")]
    ColorAttachment10NV = 36074,

    [NativeName("GL_COLOR_ATTACHMENT11_NV")]
    ColorAttachment11NV = 36075,

    [NativeName("GL_COLOR_ATTACHMENT12_NV")]
    ColorAttachment12NV = 36076,

    [NativeName("GL_COLOR_ATTACHMENT13_NV")]
    ColorAttachment13NV = 36077,

    [NativeName("GL_COLOR_ATTACHMENT14_NV")]
    ColorAttachment14NV = 36078,

    [NativeName("GL_COLOR_ATTACHMENT15_NV")]
    ColorAttachment15NV = 36079,
}
