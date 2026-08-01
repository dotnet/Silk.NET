// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrCompositionLayerSecureContentFlagsFB")]
[Flags]
public enum CompositionLayerSecureContentFlagsFB : ulong
{
    None = 0x0,

    [NativeName("XR_COMPOSITION_LAYER_SECURE_CONTENT_EXCLUDE_LAYER_BIT_FB")]
    ExcludeLayerBit = 0x1,

    [NativeName("XR_COMPOSITION_LAYER_SECURE_CONTENT_REPLACE_LAYER_BIT_FB")]
    ReplaceLayerBit = 0x2,
}
