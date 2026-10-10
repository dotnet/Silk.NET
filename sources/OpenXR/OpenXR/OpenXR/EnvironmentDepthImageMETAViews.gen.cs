// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenXR;

[NativeName("_views_e__FixedBuffer")]
[InlineArray(2)]
[SupportedApiProfile("openxr")]
public partial struct EnvironmentDepthImageMETAViews
{
    [NativeName("e0")]
    [SupportedApiProfile("openxr")]
    public EnvironmentDepthImageViewMETA E0;
}
