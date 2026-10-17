// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrCompositionLayerAlphaBlendFB")]
public unsafe partial struct CompositionLayerAlphaBlendFB
{
    [NativeName("type")]
    public StructureType Type = StructureType.CompositionLayerAlphaBlendFB;

    [NativeName("next")]
    public void* Next;

    [NativeName("srcFactorColor")]
    public BlendFactorFB SrcFactorColor;

    [NativeName("dstFactorColor")]
    public BlendFactorFB DstFactorColor;

    [NativeName("srcFactorAlpha")]
    public BlendFactorFB SrcFactorAlpha;

    [NativeName("dstFactorAlpha")]
    public BlendFactorFB DstFactorAlpha;

    public CompositionLayerAlphaBlendFB() { }
}
