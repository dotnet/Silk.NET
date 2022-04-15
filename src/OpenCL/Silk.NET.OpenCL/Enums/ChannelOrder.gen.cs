// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    [NativeName("Name", "cl_channel_order")]
    public enum ChannelOrder : int
    {
        [NativeName("Name", "CL_R")]
        R = 0x10B0,
        [NativeName("Name", "CL_A")]
        A = 0x10B1,
        [NativeName("Name", "CL_RG")]
        RG = 0x10B2,
        [NativeName("Name", "CL_RA")]
        RA = 0x10B3,
        [NativeName("Name", "CL_RGB")]
        Rgb = 0x10B4,
        [NativeName("Name", "CL_RGBA")]
        Rgba = 0x10B5,
        [NativeName("Name", "CL_BGRA")]
        Bgra = 0x10B6,
        [NativeName("Name", "CL_ARGB")]
        Argb = 0x10B7,
        [NativeName("Name", "CL_INTENSITY")]
        Intensity = 0x10B8,
        [NativeName("Name", "CL_LUMINANCE")]
        Luminance = 0x10B9,
        [NativeName("Name", "CL_Rx")]
        Rx = 0x10BA,
        [NativeName("Name", "CL_RGx")]
        RGx = 0x10BB,
        [NativeName("Name", "CL_RGBx")]
        Rgbx = 0x10BC,
        [NativeName("Name", "CL_DEPTH")]
        Depth = 0x10BD,
        [NativeName("Name", "CL_sRGB")]
        SRgb = 0x10BF,
        [NativeName("Name", "CL_sRGBx")]
        SRgbx = 0x10C0,
        [NativeName("Name", "CL_sRGBA")]
        SRgba = 0x10C1,
        [NativeName("Name", "CL_sBGRA")]
        SBgra = 0x10C2,
        [NativeName("Name", "CL_ABGR")]
        Abgr = 0x10C3,
        [NativeName("Name", "CL_NV21_IMG")]
        NV21Img = 0x40D0,
        [NativeName("Name", "CL_YV12_IMG")]
        YV12Img = 0x40D1,
        [NativeName("Name", "CL_YUYV_INTEL")]
        YuyvIntel = 0x4076,
        [NativeName("Name", "CL_UYVY_INTEL")]
        UyvyIntel = 0x4077,
        [NativeName("Name", "CL_YVYU_INTEL")]
        YvyuIntel = 0x4078,
        [NativeName("Name", "CL_VYUY_INTEL")]
        VyuyIntel = 0x4079,
        [NativeName("Name", "CL_NV12_INTEL")]
        NV12Intel = 0x410E,
        [NativeName("Name", "CL_DEPTH_STENCIL")]
        DepthStencil = 0x10BE,
    }
}
