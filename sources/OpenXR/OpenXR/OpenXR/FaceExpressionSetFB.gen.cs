// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("XrFaceExpressionSetFB")]
[SupportedApiProfile("openxr")]
public enum FaceExpressionSetFB : uint
{
    [NativeName("XR_FACE_EXPRESSION_SET_DEFAULT_FB")]
    [SupportedApiProfile("openxr", ["XR_FB_face_tracking"])]
    Default = 0,
}
