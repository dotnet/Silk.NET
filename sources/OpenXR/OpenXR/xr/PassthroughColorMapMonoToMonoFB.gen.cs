// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrPassthroughColorMapMonoToMonoFB")]
public unsafe partial struct PassthroughColorMapMonoToMonoFB
{
    [NativeName("type")]
    public StructureType Type = StructureType.PassthroughColorMapMonoToMonoFB;

    [NativeName("next")]
    public void* Next;

    [NativeName("textureColorMap")]
    public PassthroughColorMapMonoToMonoFBTextureColorMap TextureColorMap;

    public PassthroughColorMapMonoToMonoFB() { }
}
