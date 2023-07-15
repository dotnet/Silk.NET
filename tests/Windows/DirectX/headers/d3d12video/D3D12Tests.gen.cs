// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using NUnit.Framework;
using System;
using static TerraFX.Interop.DirectX.D3D12;

namespace TerraFX.Interop.DirectX.UnitTests;
/// <summary>Provides validation of the <see cref = "D3D12"/> class.</summary>
public static partial class D3D12Tests
{
    /// <summary>Validates that the value of the <see cref = "D3D12_VIDEO_DECODE_PROFILE_MPEG2"/> property is correct.</summary>
    [Test]
    public static void D3D12_VIDEO_DECODE_PROFILE_MPEG2Test()
    {
        Assert.That(D3D12_VIDEO_DECODE_PROFILE_MPEG2, Is.EqualTo(new Guid(0xee27417f, 0x5e28, 0x4e65, 0xbe, 0xea, 0x1d, 0x26, 0xb5, 0x08, 0xad, 0xc9)));
    }

    /// <summary>Validates that the value of the <see cref = "D3D12_VIDEO_DECODE_PROFILE_MPEG1_AND_MPEG2"/> property is correct.</summary>
    [Test]
    public static void D3D12_VIDEO_DECODE_PROFILE_MPEG1_AND_MPEG2Test()
    {
        Assert.That(D3D12_VIDEO_DECODE_PROFILE_MPEG1_AND_MPEG2, Is.EqualTo(new Guid(0x86695f12, 0x340e, 0x4f04, 0x9f, 0xd3, 0x92, 0x53, 0xdd, 0x32, 0x74, 0x60)));
    }

    /// <summary>Validates that the value of the <see cref = "D3D12_VIDEO_DECODE_PROFILE_H264"/> property is correct.</summary>
    [Test]
    public static void D3D12_VIDEO_DECODE_PROFILE_H264Test()
    {
        Assert.That(D3D12_VIDEO_DECODE_PROFILE_H264, Is.EqualTo(new Guid(0x1b81be68, 0xa0c7, 0x11d3, 0xb9, 0x84, 0x00, 0xc0, 0x4f, 0x2e, 0x73, 0xc5)));
    }

    /// <summary>Validates that the value of the <see cref = "D3D12_VIDEO_DECODE_PROFILE_H264_STEREO_PROGRESSIVE"/> property is correct.</summary>
    [Test]
    public static void D3D12_VIDEO_DECODE_PROFILE_H264_STEREO_PROGRESSIVETest()
    {
        Assert.That(D3D12_VIDEO_DECODE_PROFILE_H264_STEREO_PROGRESSIVE, Is.EqualTo(new Guid(0xd79be8da, 0x0cf1, 0x4c81, 0xb8, 0x2a, 0x69, 0xa4, 0xe2, 0x36, 0xf4, 0x3d)));
    }

    /// <summary>Validates that the value of the <see cref = "D3D12_VIDEO_DECODE_PROFILE_H264_STEREO"/> property is correct.</summary>
    [Test]
    public static void D3D12_VIDEO_DECODE_PROFILE_H264_STEREOTest()
    {
        Assert.That(D3D12_VIDEO_DECODE_PROFILE_H264_STEREO, Is.EqualTo(new Guid(0xf9aaccbb, 0xc2b6, 0x4cfc, 0x87, 0x79, 0x57, 0x07, 0xb1, 0x76, 0x05, 0x52)));
    }

    /// <summary>Validates that the value of the <see cref = "D3D12_VIDEO_DECODE_PROFILE_H264_MULTIVIEW"/> property is correct.</summary>
    [Test]
    public static void D3D12_VIDEO_DECODE_PROFILE_H264_MULTIVIEWTest()
    {
        Assert.That(D3D12_VIDEO_DECODE_PROFILE_H264_MULTIVIEW, Is.EqualTo(new Guid(0x705b9d82, 0x76cf, 0x49d6, 0xb7, 0xe6, 0xac, 0x88, 0x72, 0xdb, 0x01, 0x3c)));
    }

    /// <summary>Validates that the value of the <see cref = "D3D12_VIDEO_DECODE_PROFILE_VC1"/> property is correct.</summary>
    [Test]
    public static void D3D12_VIDEO_DECODE_PROFILE_VC1Test()
    {
        Assert.That(D3D12_VIDEO_DECODE_PROFILE_VC1, Is.EqualTo(new Guid(0x1b81beA3, 0xa0c7, 0x11d3, 0xb9, 0x84, 0x00, 0xc0, 0x4f, 0x2e, 0x73, 0xc5)));
    }

    /// <summary>Validates that the value of the <see cref = "D3D12_VIDEO_DECODE_PROFILE_VC1_D2010"/> property is correct.</summary>
    [Test]
    public static void D3D12_VIDEO_DECODE_PROFILE_VC1_D2010Test()
    {
        Assert.That(D3D12_VIDEO_DECODE_PROFILE_VC1_D2010, Is.EqualTo(new Guid(0x1b81beA4, 0xa0c7, 0x11d3, 0xb9, 0x84, 0x00, 0xc0, 0x4f, 0x2e, 0x73, 0xc5)));
    }

    /// <summary>Validates that the value of the <see cref = "D3D12_VIDEO_DECODE_PROFILE_MPEG4PT2_SIMPLE"/> property is correct.</summary>
    [Test]
    public static void D3D12_VIDEO_DECODE_PROFILE_MPEG4PT2_SIMPLETest()
    {
        Assert.That(D3D12_VIDEO_DECODE_PROFILE_MPEG4PT2_SIMPLE, Is.EqualTo(new Guid(0xefd64d74, 0xc9e8, 0x41d7, 0xa5, 0xe9, 0xe9, 0xb0, 0xe3, 0x9f, 0xa3, 0x19)));
    }

    /// <summary>Validates that the value of the <see cref = "D3D12_VIDEO_DECODE_PROFILE_MPEG4PT2_ADVSIMPLE_NOGMC"/> property is correct.</summary>
    [Test]
    public static void D3D12_VIDEO_DECODE_PROFILE_MPEG4PT2_ADVSIMPLE_NOGMCTest()
    {
        Assert.That(D3D12_VIDEO_DECODE_PROFILE_MPEG4PT2_ADVSIMPLE_NOGMC, Is.EqualTo(new Guid(0xed418a9f, 0x010d, 0x4eda, 0x9a, 0xe3, 0x9a, 0x65, 0x35, 0x8d, 0x8d, 0x2e)));
    }

    /// <summary>Validates that the value of the <see cref = "D3D12_VIDEO_DECODE_PROFILE_HEVC_MAIN"/> property is correct.</summary>
    [Test]
    public static void D3D12_VIDEO_DECODE_PROFILE_HEVC_MAINTest()
    {
        Assert.That(D3D12_VIDEO_DECODE_PROFILE_HEVC_MAIN, Is.EqualTo(new Guid(0x5b11d51b, 0x2f4c, 0x4452, 0xbc, 0xc3, 0x09, 0xf2, 0xa1, 0x16, 0x0c, 0xc0)));
    }

    /// <summary>Validates that the value of the <see cref = "D3D12_VIDEO_DECODE_PROFILE_HEVC_MAIN10"/> property is correct.</summary>
    [Test]
    public static void D3D12_VIDEO_DECODE_PROFILE_HEVC_MAIN10Test()
    {
        Assert.That(D3D12_VIDEO_DECODE_PROFILE_HEVC_MAIN10, Is.EqualTo(new Guid(0x107af0e0, 0xef1a, 0x4d19, 0xab, 0xa8, 0x67, 0xa1, 0x63, 0x07, 0x3d, 0x13)));
    }

    /// <summary>Validates that the value of the <see cref = "D3D12_VIDEO_DECODE_PROFILE_VP9"/> property is correct.</summary>
    [Test]
    public static void D3D12_VIDEO_DECODE_PROFILE_VP9Test()
    {
        Assert.That(D3D12_VIDEO_DECODE_PROFILE_VP9, Is.EqualTo(new Guid(0x463707f8, 0xa1d0, 0x4585, 0x87, 0x6d, 0x83, 0xaa, 0x6d, 0x60, 0xb8, 0x9e)));
    }

    /// <summary>Validates that the value of the <see cref = "D3D12_VIDEO_DECODE_PROFILE_VP9_10BIT_PROFILE2"/> property is correct.</summary>
    [Test]
    public static void D3D12_VIDEO_DECODE_PROFILE_VP9_10BIT_PROFILE2Test()
    {
        Assert.That(D3D12_VIDEO_DECODE_PROFILE_VP9_10BIT_PROFILE2, Is.EqualTo(new Guid(0xa4c749ef, 0x6ecf, 0x48aa, 0x84, 0x48, 0x50, 0xa7, 0xa1, 0x16, 0x5f, 0xf7)));
    }

    /// <summary>Validates that the value of the <see cref = "D3D12_VIDEO_DECODE_PROFILE_VP8"/> property is correct.</summary>
    [Test]
    public static void D3D12_VIDEO_DECODE_PROFILE_VP8Test()
    {
        Assert.That(D3D12_VIDEO_DECODE_PROFILE_VP8, Is.EqualTo(new Guid(0x90b899ea, 0x3a62, 0x4705, 0x88, 0xb3, 0x8d, 0xf0, 0x4b, 0x27, 0x44, 0xe7)));
    }

    /// <summary>Validates that the value of the <see cref = "D3D12_VIDEO_DECODE_PROFILE_AV1_PROFILE0"/> property is correct.</summary>
    [Test]
    public static void D3D12_VIDEO_DECODE_PROFILE_AV1_PROFILE0Test()
    {
        Assert.That(D3D12_VIDEO_DECODE_PROFILE_AV1_PROFILE0, Is.EqualTo(new Guid(0xb8be4ccb, 0xcf53, 0x46ba, 0x8d, 0x59, 0xd6, 0xb8, 0xa6, 0xda, 0x5d, 0x2a)));
    }

    /// <summary>Validates that the value of the <see cref = "D3D12_VIDEO_DECODE_PROFILE_AV1_PROFILE1"/> property is correct.</summary>
    [Test]
    public static void D3D12_VIDEO_DECODE_PROFILE_AV1_PROFILE1Test()
    {
        Assert.That(D3D12_VIDEO_DECODE_PROFILE_AV1_PROFILE1, Is.EqualTo(new Guid(0x6936ff0f, 0x45b1, 0x4163, 0x9c, 0xc1, 0x64, 0x6e, 0xf6, 0x94, 0x61, 0x08)));
    }

    /// <summary>Validates that the value of the <see cref = "D3D12_VIDEO_DECODE_PROFILE_AV1_PROFILE2"/> property is correct.</summary>
    [Test]
    public static void D3D12_VIDEO_DECODE_PROFILE_AV1_PROFILE2Test()
    {
        Assert.That(D3D12_VIDEO_DECODE_PROFILE_AV1_PROFILE2, Is.EqualTo(new Guid(0x0c5f2aa1, 0xe541, 0x4089, 0xbb, 0x7b, 0x98, 0x11, 0x0a, 0x19, 0xd7, 0xc8)));
    }

    /// <summary>Validates that the value of the <see cref = "D3D12_VIDEO_DECODE_PROFILE_AV1_12BIT_PROFILE2"/> property is correct.</summary>
    [Test]
    public static void D3D12_VIDEO_DECODE_PROFILE_AV1_12BIT_PROFILE2Test()
    {
        Assert.That(D3D12_VIDEO_DECODE_PROFILE_AV1_12BIT_PROFILE2, Is.EqualTo(new Guid(0x17127009, 0xa00f, 0x4ce1, 0x99, 0x4e, 0xbf, 0x40, 0x81, 0xf6, 0xf3, 0xf0)));
    }

    /// <summary>Validates that the value of the <see cref = "D3D12_VIDEO_DECODE_PROFILE_AV1_12BIT_PROFILE2_420"/> property is correct.</summary>
    [Test]
    public static void D3D12_VIDEO_DECODE_PROFILE_AV1_12BIT_PROFILE2_420Test()
    {
        Assert.That(D3D12_VIDEO_DECODE_PROFILE_AV1_12BIT_PROFILE2_420, Is.EqualTo(new Guid(0x2d80bed6, 0x9cac, 0x4835, 0x9e, 0x91, 0x32, 0x7b, 0xbc, 0x4f, 0x9e, 0xe8)));
    }
}