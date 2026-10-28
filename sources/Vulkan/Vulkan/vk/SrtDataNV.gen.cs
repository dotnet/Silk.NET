// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkSRTDataNV")]
public partial struct SrtDataNV
{
    [NativeName("sx")]
    public float Sx;

    [NativeName("a")]
    public float A;

    [NativeName("b")]
    public float B;

    [NativeName("pvx")]
    public float Pvx;

    [NativeName("sy")]
    public float Sy;

    [NativeName("c")]
    public float C;

    [NativeName("pvy")]
    public float Pvy;

    [NativeName("sz")]
    public float Sz;

    [NativeName("pvz")]
    public float Pvz;

    [NativeName("qx")]
    public float Qx;

    [NativeName("qy")]
    public float Qy;

    [NativeName("qz")]
    public float Qz;

    [NativeName("qw")]
    public float Qw;

    [NativeName("tx")]
    public float Tx;

    [NativeName("ty")]
    public float Ty;

    [NativeName("tz")]
    public float Tz;
}
