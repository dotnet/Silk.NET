// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrPassthroughColorMapMonoToMonoFB")]
[SupportedApiProfile("openxr")]
public unsafe partial struct PassthroughColorMapMonoToMonoFB
{
    [NativeName("type")]
    [SupportedApiProfile("openxr", ["XR_FB_passthrough"])]
    public StructureType Type = StructureType.TypePassthroughColorMapMonoToMonoFB;

    [NativeName("next")]
    [SupportedApiProfile("openxr", ["XR_FB_passthrough"])]
    public void* Next;

    [NativeName("textureColorMap")]
    [SupportedApiProfile("openxr", ["XR_FB_passthrough"])]
    public PassthroughColorMapMonoToMonoFBTextureColorMap TextureColorMap;

    [SupportedApiProfile("openxr", ["XR_FB_passthrough"])]
    public PassthroughColorMapMonoToMonoFB() { }
}
