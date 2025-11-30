// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("InvalidateFramebufferAttachment")]
[Transformed]
public enum InvalidateFramebufferAttachment : uint
{
    [NativeName("GL_COLOR")]
    Color = unchecked((uint)0x1800),

    [NativeName("GL_DEPTH")]
    Depth = unchecked((uint)0x1801),

    [NativeName("GL_STENCIL")]
    Stencil = unchecked((uint)0x1802),

    [NativeName("GL_DEPTH_STENCIL_ATTACHMENT")]
    DepthStencilAttachment = unchecked((uint)0x821A),

    [NativeName("GL_COLOR_ATTACHMENT0")]
    ColorAttachment0 = unchecked((uint)0x8CE0),

    [NativeName("GL_COLOR_ATTACHMENT1")]
    ColorAttachment1 = unchecked((uint)0x8CE1),

    [NativeName("GL_COLOR_ATTACHMENT2")]
    ColorAttachment2 = unchecked((uint)0x8CE2),

    [NativeName("GL_COLOR_ATTACHMENT3")]
    ColorAttachment3 = unchecked((uint)0x8CE3),

    [NativeName("GL_COLOR_ATTACHMENT4")]
    ColorAttachment4 = unchecked((uint)0x8CE4),

    [NativeName("GL_COLOR_ATTACHMENT5")]
    ColorAttachment5 = unchecked((uint)0x8CE5),

    [NativeName("GL_COLOR_ATTACHMENT6")]
    ColorAttachment6 = unchecked((uint)0x8CE6),

    [NativeName("GL_COLOR_ATTACHMENT7")]
    ColorAttachment7 = unchecked((uint)0x8CE7),

    [NativeName("GL_COLOR_ATTACHMENT8")]
    ColorAttachment8 = unchecked((uint)0x8CE8),

    [NativeName("GL_COLOR_ATTACHMENT9")]
    ColorAttachment9 = unchecked((uint)0x8CE9),

    [NativeName("GL_COLOR_ATTACHMENT10")]
    ColorAttachment10 = unchecked((uint)0x8CEA),

    [NativeName("GL_COLOR_ATTACHMENT11")]
    ColorAttachment11 = unchecked((uint)0x8CEB),

    [NativeName("GL_COLOR_ATTACHMENT12")]
    ColorAttachment12 = unchecked((uint)0x8CEC),

    [NativeName("GL_COLOR_ATTACHMENT13")]
    ColorAttachment13 = unchecked((uint)0x8CED),

    [NativeName("GL_COLOR_ATTACHMENT14")]
    ColorAttachment14 = unchecked((uint)0x8CEE),

    [NativeName("GL_COLOR_ATTACHMENT15")]
    ColorAttachment15 = unchecked((uint)0x8CEF),

    [NativeName("GL_COLOR_ATTACHMENT16")]
    ColorAttachment16 = unchecked((uint)0x8CF0),

    [NativeName("GL_COLOR_ATTACHMENT17")]
    ColorAttachment17 = unchecked((uint)0x8CF1),

    [NativeName("GL_COLOR_ATTACHMENT18")]
    ColorAttachment18 = unchecked((uint)0x8CF2),

    [NativeName("GL_COLOR_ATTACHMENT19")]
    ColorAttachment19 = unchecked((uint)0x8CF3),

    [NativeName("GL_COLOR_ATTACHMENT20")]
    ColorAttachment20 = unchecked((uint)0x8CF4),

    [NativeName("GL_COLOR_ATTACHMENT21")]
    ColorAttachment21 = unchecked((uint)0x8CF5),

    [NativeName("GL_COLOR_ATTACHMENT22")]
    ColorAttachment22 = unchecked((uint)0x8CF6),

    [NativeName("GL_COLOR_ATTACHMENT23")]
    ColorAttachment23 = unchecked((uint)0x8CF7),

    [NativeName("GL_COLOR_ATTACHMENT24")]
    ColorAttachment24 = unchecked((uint)0x8CF8),

    [NativeName("GL_COLOR_ATTACHMENT25")]
    ColorAttachment25 = unchecked((uint)0x8CF9),

    [NativeName("GL_COLOR_ATTACHMENT26")]
    ColorAttachment26 = unchecked((uint)0x8CFA),

    [NativeName("GL_COLOR_ATTACHMENT27")]
    ColorAttachment27 = unchecked((uint)0x8CFB),

    [NativeName("GL_COLOR_ATTACHMENT28")]
    ColorAttachment28 = unchecked((uint)0x8CFC),

    [NativeName("GL_COLOR_ATTACHMENT29")]
    ColorAttachment29 = unchecked((uint)0x8CFD),

    [NativeName("GL_COLOR_ATTACHMENT30")]
    ColorAttachment30 = unchecked((uint)0x8CFE),

    [NativeName("GL_COLOR_ATTACHMENT31")]
    ColorAttachment31 = unchecked((uint)0x8CFF),

    [NativeName("GL_DEPTH_ATTACHMENT")]
    DepthAttachment = unchecked((uint)0x8D00),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_COLOR_ATTACHMENT0_EXT")]
    ColorAttachment0Ext = unchecked((uint)0x8CE0),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_COLOR_ATTACHMENT1_EXT")]
    ColorAttachment1Ext = unchecked((uint)0x8CE1),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_COLOR_ATTACHMENT2_EXT")]
    ColorAttachment2Ext = unchecked((uint)0x8CE2),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_COLOR_ATTACHMENT3_EXT")]
    ColorAttachment3Ext = unchecked((uint)0x8CE3),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_COLOR_ATTACHMENT4_EXT")]
    ColorAttachment4Ext = unchecked((uint)0x8CE4),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_COLOR_ATTACHMENT5_EXT")]
    ColorAttachment5Ext = unchecked((uint)0x8CE5),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_COLOR_ATTACHMENT6_EXT")]
    ColorAttachment6Ext = unchecked((uint)0x8CE6),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_COLOR_ATTACHMENT7_EXT")]
    ColorAttachment7Ext = unchecked((uint)0x8CE7),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_COLOR_ATTACHMENT8_EXT")]
    ColorAttachment8Ext = unchecked((uint)0x8CE8),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_COLOR_ATTACHMENT9_EXT")]
    ColorAttachment9Ext = unchecked((uint)0x8CE9),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_COLOR_ATTACHMENT10_EXT")]
    ColorAttachment10Ext = unchecked((uint)0x8CEA),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_COLOR_ATTACHMENT11_EXT")]
    ColorAttachment11Ext = unchecked((uint)0x8CEB),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_COLOR_ATTACHMENT12_EXT")]
    ColorAttachment12Ext = unchecked((uint)0x8CEC),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_COLOR_ATTACHMENT13_EXT")]
    ColorAttachment13Ext = unchecked((uint)0x8CED),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_COLOR_ATTACHMENT14_EXT")]
    ColorAttachment14Ext = unchecked((uint)0x8CEE),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_COLOR_ATTACHMENT15_EXT")]
    ColorAttachment15Ext = unchecked((uint)0x8CEF),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_DEPTH_ATTACHMENT_EXT")]
    DepthAttachmentext = unchecked((uint)0x8D00),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_STENCIL_ATTACHMENT_EXT")]
    StencilAttachmentext = unchecked((uint)0x8D20),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COLOR_ATTACHMENT0_NV")]
    ColorAttachment0Nv = unchecked((uint)0x8CE0),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COLOR_ATTACHMENT1_NV")]
    ColorAttachment1Nv = unchecked((uint)0x8CE1),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COLOR_ATTACHMENT2_NV")]
    ColorAttachment2Nv = unchecked((uint)0x8CE2),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COLOR_ATTACHMENT3_NV")]
    ColorAttachment3Nv = unchecked((uint)0x8CE3),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COLOR_ATTACHMENT4_NV")]
    ColorAttachment4Nv = unchecked((uint)0x8CE4),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COLOR_ATTACHMENT5_NV")]
    ColorAttachment5Nv = unchecked((uint)0x8CE5),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COLOR_ATTACHMENT6_NV")]
    ColorAttachment6Nv = unchecked((uint)0x8CE6),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COLOR_ATTACHMENT7_NV")]
    ColorAttachment7Nv = unchecked((uint)0x8CE7),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COLOR_ATTACHMENT8_NV")]
    ColorAttachment8Nv = unchecked((uint)0x8CE8),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COLOR_ATTACHMENT9_NV")]
    ColorAttachment9Nv = unchecked((uint)0x8CE9),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COLOR_ATTACHMENT10_NV")]
    ColorAttachment10Nv = unchecked((uint)0x8CEA),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COLOR_ATTACHMENT11_NV")]
    ColorAttachment11Nv = unchecked((uint)0x8CEB),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COLOR_ATTACHMENT12_NV")]
    ColorAttachment12Nv = unchecked((uint)0x8CEC),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COLOR_ATTACHMENT13_NV")]
    ColorAttachment13Nv = unchecked((uint)0x8CED),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COLOR_ATTACHMENT14_NV")]
    ColorAttachment14Nv = unchecked((uint)0x8CEE),

    [NameAffix("Suffix", "NV", 0)]
    [NativeName("GL_COLOR_ATTACHMENT15_NV")]
    ColorAttachment15Nv = unchecked((uint)0x8CEF),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_COLOR_ATTACHMENT0_OES")]
    ColorAttachment0Oes = unchecked((uint)0x8CE0),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_DEPTH_ATTACHMENT_OES")]
    DepthAttachmentoes = unchecked((uint)0x8D00),

    [NameAffix("Suffix", "OES", 0)]
    [NativeName("GL_STENCIL_ATTACHMENT_OES")]
    StencilAttachmentoes = unchecked((uint)0x8D20),
}
