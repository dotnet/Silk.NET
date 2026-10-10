// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenCL headers and corresponding dependencies.
// Original source is Copyright 2013-2026 The Khronos Group Inc. Licensed under the Apache 2.0 license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenCL;

[NativeName("cl_channel_order")]
public enum ChannelOrder : uint
{
    [NativeName("CL_R")]
    R = 4272,

    [NativeName("CL_A")]
    A = 4273,

    [NativeName("CL_RG")]
    Rg = 4274,

    [NativeName("CL_RA")]
    Ra = 4275,

    [NativeName("CL_RGB")]
    Rgb = 4276,

    [NativeName("CL_RGBA")]
    Rgba = 4277,

    [NativeName("CL_BGRA")]
    Bgra = 4278,

    [NativeName("CL_ARGB")]
    Argb = 4279,

    [NativeName("CL_INTENSITY")]
    Intensity = 4280,

    [NativeName("CL_LUMINANCE")]
    Luminance = 4281,

    [NativeName("CL_Rx")]
    Rx = 4282,

    [NativeName("CL_RGx")]
    RGx = 4283,

    [NativeName("CL_RGBx")]
    RGBx = 4284,

    [NativeName("CL_DEPTH")]
    Depth = 4285,

    [NativeName("CL_sRGB")]
    SRgb = 4287,

    [NativeName("CL_sRGBx")]
    SRGBx = 4288,

    [NativeName("CL_sRGBA")]
    SRgba = 4289,

    [NativeName("CL_sBGRA")]
    SBgra = 4290,

    [NativeName("CL_ABGR")]
    Abgr = 4291,

    [NativeName("CL_NV21_IMG")]
    Nv21IMG = 16592,

    [NativeName("CL_YV12_IMG")]
    Yv12IMG = 16593,

    [NativeName("CL_YUYV_INTEL")]
    YuyvINTEL = 16502,

    [NativeName("CL_UYVY_INTEL")]
    UyvyINTEL = 16503,

    [NativeName("CL_YVYU_INTEL")]
    YvyuINTEL = 16504,

    [NativeName("CL_VYUY_INTEL")]
    VyuyINTEL = 16505,

    [NativeName("CL_NV12_INTEL")]
    Nv12INTEL = 16654,
}
