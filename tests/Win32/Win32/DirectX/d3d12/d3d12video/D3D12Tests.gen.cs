// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
using NUnit.Framework;
using static Silk.NET.DirectX.D3D12;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "D3D12"/> class.</summary>
public static partial class D3D12Tests
{
    /// <summary>Validates that the value of the <see cref = "D3D12_VIDEO_DECODE_PROFILE_MPEG2"/> property is correct.</summary>

    [Test]
    public static void D3D12_VIDEO_DECODE_PROFILE_MPEG2Test()
    {
        Assert.That(
            D3D12_VIDEO_DECODE_PROFILE_MPEG2,
            Is.EqualTo(
                new Guid(0xee27417f, 0x5e28, 0x4e65, 0xbe, 0xea, 0x1d, 0x26, 0xb5, 0x08, 0xad, 0xc9)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "D3D12_VIDEO_DECODE_PROFILE_MPEG1_AND_MPEG2"/> property is correct.</summary>

    [Test]
    public static void D3D12_VIDEO_DECODE_PROFILE_MPEG1_AND_MPEG2Test()
    {
        Assert.That(
            D3D12_VIDEO_DECODE_PROFILE_MPEG1_AND_MPEG2,
            Is.EqualTo(
                new Guid(0x86695f12, 0x340e, 0x4f04, 0x9f, 0xd3, 0x92, 0x53, 0xdd, 0x32, 0x74, 0x60)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "D3D12_VIDEO_DECODE_PROFILE_H264"/> property is correct.</summary>

    [Test]
    public static void D3D12_VIDEO_DECODE_PROFILE_H264Test()
    {
        Assert.That(
            D3D12_VIDEO_DECODE_PROFILE_H264,
            Is.EqualTo(
                new Guid(0x1b81be68, 0xa0c7, 0x11d3, 0xb9, 0x84, 0x00, 0xc0, 0x4f, 0x2e, 0x73, 0xc5)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "D3D12_VIDEO_DECODE_PROFILE_H264_STEREO_PROGRESSIVE"/> property is correct.</summary>

    [Test]
    public static void D3D12_VIDEO_DECODE_PROFILE_H264_STEREO_PROGRESSIVETest()
    {
        Assert.That(
            D3D12_VIDEO_DECODE_PROFILE_H264_STEREO_PROGRESSIVE,
            Is.EqualTo(
                new Guid(0xd79be8da, 0x0cf1, 0x4c81, 0xb8, 0x2a, 0x69, 0xa4, 0xe2, 0x36, 0xf4, 0x3d)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "D3D12_VIDEO_DECODE_PROFILE_H264_STEREO"/> property is correct.</summary>

    [Test]
    public static void D3D12_VIDEO_DECODE_PROFILE_H264_STEREOTest()
    {
        Assert.That(
            D3D12_VIDEO_DECODE_PROFILE_H264_STEREO,
            Is.EqualTo(
                new Guid(0xf9aaccbb, 0xc2b6, 0x4cfc, 0x87, 0x79, 0x57, 0x07, 0xb1, 0x76, 0x05, 0x52)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "D3D12_VIDEO_DECODE_PROFILE_H264_MULTIVIEW"/> property is correct.</summary>

    [Test]
    public static void D3D12_VIDEO_DECODE_PROFILE_H264_MULTIVIEWTest()
    {
        Assert.That(
            D3D12_VIDEO_DECODE_PROFILE_H264_MULTIVIEW,
            Is.EqualTo(
                new Guid(0x705b9d82, 0x76cf, 0x49d6, 0xb7, 0xe6, 0xac, 0x88, 0x72, 0xdb, 0x01, 0x3c)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "D3D12_VIDEO_DECODE_PROFILE_VC1"/> property is correct.</summary>

    [Test]
    public static void D3D12_VIDEO_DECODE_PROFILE_VC1Test()
    {
        Assert.That(
            D3D12_VIDEO_DECODE_PROFILE_VC1,
            Is.EqualTo(
                new Guid(0x1b81beA3, 0xa0c7, 0x11d3, 0xb9, 0x84, 0x00, 0xc0, 0x4f, 0x2e, 0x73, 0xc5)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "D3D12_VIDEO_DECODE_PROFILE_VC1_D2010"/> property is correct.</summary>

    [Test]
    public static void D3D12_VIDEO_DECODE_PROFILE_VC1_D2010Test()
    {
        Assert.That(
            D3D12_VIDEO_DECODE_PROFILE_VC1_D2010,
            Is.EqualTo(
                new Guid(0x1b81beA4, 0xa0c7, 0x11d3, 0xb9, 0x84, 0x00, 0xc0, 0x4f, 0x2e, 0x73, 0xc5)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "D3D12_VIDEO_DECODE_PROFILE_MPEG4PT2_SIMPLE"/> property is correct.</summary>

    [Test]
    public static void D3D12_VIDEO_DECODE_PROFILE_MPEG4PT2_SIMPLETest()
    {
        Assert.That(
            D3D12_VIDEO_DECODE_PROFILE_MPEG4PT2_SIMPLE,
            Is.EqualTo(
                new Guid(0xefd64d74, 0xc9e8, 0x41d7, 0xa5, 0xe9, 0xe9, 0xb0, 0xe3, 0x9f, 0xa3, 0x19)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "D3D12_VIDEO_DECODE_PROFILE_MPEG4PT2_ADVSIMPLE_NOGMC"/> property is correct.</summary>

    [Test]
    public static void D3D12_VIDEO_DECODE_PROFILE_MPEG4PT2_ADVSIMPLE_NOGMCTest()
    {
        Assert.That(
            D3D12_VIDEO_DECODE_PROFILE_MPEG4PT2_ADVSIMPLE_NOGMC,
            Is.EqualTo(
                new Guid(0xed418a9f, 0x010d, 0x4eda, 0x9a, 0xe3, 0x9a, 0x65, 0x35, 0x8d, 0x8d, 0x2e)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "D3D12_VIDEO_DECODE_PROFILE_HEVC_MAIN"/> property is correct.</summary>

    [Test]
    public static void D3D12_VIDEO_DECODE_PROFILE_HEVC_MAINTest()
    {
        Assert.That(
            D3D12_VIDEO_DECODE_PROFILE_HEVC_MAIN,
            Is.EqualTo(
                new Guid(0x5b11d51b, 0x2f4c, 0x4452, 0xbc, 0xc3, 0x09, 0xf2, 0xa1, 0x16, 0x0c, 0xc0)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "D3D12_VIDEO_DECODE_PROFILE_HEVC_MAIN10"/> property is correct.</summary>

    [Test]
    public static void D3D12_VIDEO_DECODE_PROFILE_HEVC_MAIN10Test()
    {
        Assert.That(
            D3D12_VIDEO_DECODE_PROFILE_HEVC_MAIN10,
            Is.EqualTo(
                new Guid(0x107af0e0, 0xef1a, 0x4d19, 0xab, 0xa8, 0x67, 0xa1, 0x63, 0x07, 0x3d, 0x13)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "D3D12_VIDEO_DECODE_PROFILE_HEVC_MONOCHROME"/> property is correct.</summary>

    [Test]
    public static void D3D12_VIDEO_DECODE_PROFILE_HEVC_MONOCHROMETest()
    {
        Assert.That(
            D3D12_VIDEO_DECODE_PROFILE_HEVC_MONOCHROME,
            Is.EqualTo(
                new Guid(0x0685b993, 0x3d8c, 0x43a0, 0x8b, 0x28, 0xd7, 0x4c, 0x2d, 0x68, 0x99, 0xa4)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "D3D12_VIDEO_DECODE_PROFILE_HEVC_MONOCHROME10"/> property is correct.</summary>

    [Test]
    public static void D3D12_VIDEO_DECODE_PROFILE_HEVC_MONOCHROME10Test()
    {
        Assert.That(
            D3D12_VIDEO_DECODE_PROFILE_HEVC_MONOCHROME10,
            Is.EqualTo(
                new Guid(0x142a1d0f, 0x69dd, 0x4ec9, 0x85, 0x91, 0xb1, 0x2f, 0xfc, 0xb9, 0x1a, 0x29)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "D3D12_VIDEO_DECODE_PROFILE_HEVC_MAIN12"/> property is correct.</summary>

    [Test]
    public static void D3D12_VIDEO_DECODE_PROFILE_HEVC_MAIN12Test()
    {
        Assert.That(
            D3D12_VIDEO_DECODE_PROFILE_HEVC_MAIN12,
            Is.EqualTo(
                new Guid(0x1a72925f, 0x0c2c, 0x4f15, 0x96, 0xfb, 0xb1, 0x7d, 0x14, 0x73, 0x60, 0x3f)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "D3D12_VIDEO_DECODE_PROFILE_HEVC_MAIN10_422"/> property is correct.</summary>

    [Test]
    public static void D3D12_VIDEO_DECODE_PROFILE_HEVC_MAIN10_422Test()
    {
        Assert.That(
            D3D12_VIDEO_DECODE_PROFILE_HEVC_MAIN10_422,
            Is.EqualTo(
                new Guid(0x0bac4fe5, 0x1532, 0x4429, 0xa8, 0x54, 0xf8, 0x4d, 0xe0, 0x49, 0x53, 0xdb)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "D3D12_VIDEO_DECODE_PROFILE_HEVC_MAIN12_422"/> property is correct.</summary>

    [Test]
    public static void D3D12_VIDEO_DECODE_PROFILE_HEVC_MAIN12_422Test()
    {
        Assert.That(
            D3D12_VIDEO_DECODE_PROFILE_HEVC_MAIN12_422,
            Is.EqualTo(
                new Guid(0x55bcac81, 0xf311, 0x4093, 0xa7, 0xd0, 0x1c, 0xbc, 0x0b, 0x84, 0x9b, 0xee)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "D3D12_VIDEO_DECODE_PROFILE_HEVC_MAIN_444"/> property is correct.</summary>

    [Test]
    public static void D3D12_VIDEO_DECODE_PROFILE_HEVC_MAIN_444Test()
    {
        Assert.That(
            D3D12_VIDEO_DECODE_PROFILE_HEVC_MAIN_444,
            Is.EqualTo(
                new Guid(0x4008018f, 0xf537, 0x4b36, 0x98, 0xcf, 0x61, 0xaf, 0x8a, 0x2c, 0x1a, 0x33)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "D3D12_VIDEO_DECODE_PROFILE_HEVC_MAIN10_EXT"/> property is correct.</summary>

    [Test]
    public static void D3D12_VIDEO_DECODE_PROFILE_HEVC_MAIN10_EXTTest()
    {
        Assert.That(
            D3D12_VIDEO_DECODE_PROFILE_HEVC_MAIN10_EXT,
            Is.EqualTo(
                new Guid(0x9cc55490, 0xe37c, 0x4932, 0x86, 0x84, 0x49, 0x20, 0xf9, 0xf6, 0x40, 0x9c)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "D3D12_VIDEO_DECODE_PROFILE_HEVC_MAIN10_444"/> property is correct.</summary>

    [Test]
    public static void D3D12_VIDEO_DECODE_PROFILE_HEVC_MAIN10_444Test()
    {
        Assert.That(
            D3D12_VIDEO_DECODE_PROFILE_HEVC_MAIN10_444,
            Is.EqualTo(
                new Guid(0x0dabeffa, 0x4458, 0x4602, 0xbc, 0x03, 0x07, 0x95, 0x65, 0x9d, 0x61, 0x7c)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "D3D12_VIDEO_DECODE_PROFILE_HEVC_MAIN12_444"/> property is correct.</summary>

    [Test]
    public static void D3D12_VIDEO_DECODE_PROFILE_HEVC_MAIN12_444Test()
    {
        Assert.That(
            D3D12_VIDEO_DECODE_PROFILE_HEVC_MAIN12_444,
            Is.EqualTo(
                new Guid(0x9798634d, 0xfe9d, 0x48e5, 0xb4, 0xda, 0xdb, 0xec, 0x45, 0xb3, 0xdf, 0x01)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "D3D12_VIDEO_DECODE_PROFILE_HEVC_MAIN16"/> property is correct.</summary>

    [Test]
    public static void D3D12_VIDEO_DECODE_PROFILE_HEVC_MAIN16Test()
    {
        Assert.That(
            D3D12_VIDEO_DECODE_PROFILE_HEVC_MAIN16,
            Is.EqualTo(
                new Guid(0xa4fbdbb0, 0xa113, 0x482b, 0xa2, 0x32, 0x63, 0x5c, 0xc0, 0x69, 0x7f, 0x6d)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "D3D12_VIDEO_DECODE_PROFILE_VP9"/> property is correct.</summary>

    [Test]
    public static void D3D12_VIDEO_DECODE_PROFILE_VP9Test()
    {
        Assert.That(
            D3D12_VIDEO_DECODE_PROFILE_VP9,
            Is.EqualTo(
                new Guid(0x463707f8, 0xa1d0, 0x4585, 0x87, 0x6d, 0x83, 0xaa, 0x6d, 0x60, 0xb8, 0x9e)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "D3D12_VIDEO_DECODE_PROFILE_VP9_10BIT_PROFILE2"/> property is correct.</summary>

    [Test]
    public static void D3D12_VIDEO_DECODE_PROFILE_VP9_10BIT_PROFILE2Test()
    {
        Assert.That(
            D3D12_VIDEO_DECODE_PROFILE_VP9_10BIT_PROFILE2,
            Is.EqualTo(
                new Guid(0xa4c749ef, 0x6ecf, 0x48aa, 0x84, 0x48, 0x50, 0xa7, 0xa1, 0x16, 0x5f, 0xf7)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "D3D12_VIDEO_DECODE_PROFILE_VP8"/> property is correct.</summary>

    [Test]
    public static void D3D12_VIDEO_DECODE_PROFILE_VP8Test()
    {
        Assert.That(
            D3D12_VIDEO_DECODE_PROFILE_VP8,
            Is.EqualTo(
                new Guid(0x90b899ea, 0x3a62, 0x4705, 0x88, 0xb3, 0x8d, 0xf0, 0x4b, 0x27, 0x44, 0xe7)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "D3D12_VIDEO_DECODE_PROFILE_AV1_PROFILE0"/> property is correct.</summary>

    [Test]
    public static void D3D12_VIDEO_DECODE_PROFILE_AV1_PROFILE0Test()
    {
        Assert.That(
            D3D12_VIDEO_DECODE_PROFILE_AV1_PROFILE0,
            Is.EqualTo(
                new Guid(0xb8be4ccb, 0xcf53, 0x46ba, 0x8d, 0x59, 0xd6, 0xb8, 0xa6, 0xda, 0x5d, 0x2a)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "D3D12_VIDEO_DECODE_PROFILE_AV1_PROFILE1"/> property is correct.</summary>

    [Test]
    public static void D3D12_VIDEO_DECODE_PROFILE_AV1_PROFILE1Test()
    {
        Assert.That(
            D3D12_VIDEO_DECODE_PROFILE_AV1_PROFILE1,
            Is.EqualTo(
                new Guid(0x6936ff0f, 0x45b1, 0x4163, 0x9c, 0xc1, 0x64, 0x6e, 0xf6, 0x94, 0x61, 0x08)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "D3D12_VIDEO_DECODE_PROFILE_AV1_PROFILE2"/> property is correct.</summary>

    [Test]
    public static void D3D12_VIDEO_DECODE_PROFILE_AV1_PROFILE2Test()
    {
        Assert.That(
            D3D12_VIDEO_DECODE_PROFILE_AV1_PROFILE2,
            Is.EqualTo(
                new Guid(0x0c5f2aa1, 0xe541, 0x4089, 0xbb, 0x7b, 0x98, 0x11, 0x0a, 0x19, 0xd7, 0xc8)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "D3D12_VIDEO_DECODE_PROFILE_AV1_12BIT_PROFILE2"/> property is correct.</summary>

    [Test]
    public static void D3D12_VIDEO_DECODE_PROFILE_AV1_12BIT_PROFILE2Test()
    {
        Assert.That(
            D3D12_VIDEO_DECODE_PROFILE_AV1_12BIT_PROFILE2,
            Is.EqualTo(
                new Guid(0x17127009, 0xa00f, 0x4ce1, 0x99, 0x4e, 0xbf, 0x40, 0x81, 0xf6, 0xf3, 0xf0)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "D3D12_VIDEO_DECODE_PROFILE_AV1_12BIT_PROFILE2_420"/> property is correct.</summary>

    [Test]
    public static void D3D12_VIDEO_DECODE_PROFILE_AV1_12BIT_PROFILE2_420Test()
    {
        Assert.That(
            D3D12_VIDEO_DECODE_PROFILE_AV1_12BIT_PROFILE2_420,
            Is.EqualTo(
                new Guid(0x2d80bed6, 0x9cac, 0x4835, 0x9e, 0x91, 0x32, 0x7b, 0xbc, 0x4f, 0x9e, 0xe8)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "D3D12_VIDEO_DECODE_PROFILE_MJPEG_VLD_420"/> property is correct.</summary>

    [Test]
    public static void D3D12_VIDEO_DECODE_PROFILE_MJPEG_VLD_420Test()
    {
        Assert.That(
            D3D12_VIDEO_DECODE_PROFILE_MJPEG_VLD_420,
            Is.EqualTo(
                new Guid(0x725cb506, 0xc29, 0x43c4, 0x94, 0x40, 0x8e, 0x93, 0x97, 0x90, 0x3a, 0x4)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "D3D12_VIDEO_DECODE_PROFILE_MJPEG_VLD_422"/> property is correct.</summary>

    [Test]
    public static void D3D12_VIDEO_DECODE_PROFILE_MJPEG_VLD_422Test()
    {
        Assert.That(
            D3D12_VIDEO_DECODE_PROFILE_MJPEG_VLD_422,
            Is.EqualTo(
                new Guid(0x5b77b9cd, 0x1a35, 0x4c30, 0x9f, 0xd8, 0xef, 0x4b, 0x60, 0xc0, 0x35, 0xdd)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "D3D12_VIDEO_DECODE_PROFILE_MJPEG_VLD_444"/> property is correct.</summary>

    [Test]
    public static void D3D12_VIDEO_DECODE_PROFILE_MJPEG_VLD_444Test()
    {
        Assert.That(
            D3D12_VIDEO_DECODE_PROFILE_MJPEG_VLD_444,
            Is.EqualTo(
                new Guid(0xd95161f9, 0xd44, 0x47e6, 0xbc, 0xf5, 0x1b, 0xfb, 0xfb, 0x26, 0x8f, 0x97)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "D3D12_VIDEO_DECODE_PROFILE_MJPEG_VLD_4444"/> property is correct.</summary>

    [Test]
    public static void D3D12_VIDEO_DECODE_PROFILE_MJPEG_VLD_4444Test()
    {
        Assert.That(
            D3D12_VIDEO_DECODE_PROFILE_MJPEG_VLD_4444,
            Is.EqualTo(
                new Guid(0xc91748d5, 0xfd18, 0x4aca, 0x9d, 0xb3, 0x3a, 0x66, 0x34, 0xab, 0x54, 0x7d)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "D3D12_VIDEO_DECODE_PROFILE_JPEG_VLD_420"/> property is correct.</summary>

    [Test]
    public static void D3D12_VIDEO_DECODE_PROFILE_JPEG_VLD_420Test()
    {
        Assert.That(
            D3D12_VIDEO_DECODE_PROFILE_JPEG_VLD_420,
            Is.EqualTo(
                new Guid(0xcf782c83, 0xbef5, 0x4a2c, 0x87, 0xcb, 0x60, 0x19, 0xe7, 0xb1, 0x75, 0xac)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "D3D12_VIDEO_DECODE_PROFILE_JPEG_VLD_422"/> property is correct.</summary>

    [Test]
    public static void D3D12_VIDEO_DECODE_PROFILE_JPEG_VLD_422Test()
    {
        Assert.That(
            D3D12_VIDEO_DECODE_PROFILE_JPEG_VLD_422,
            Is.EqualTo(
                new Guid(0xf04df417, 0xeee2, 0x4067, 0xa7, 0x78, 0xf3, 0x5c, 0x15, 0xab, 0x97, 0x21)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "D3D12_VIDEO_DECODE_PROFILE_JPEG_VLD_444"/> property is correct.</summary>

    [Test]
    public static void D3D12_VIDEO_DECODE_PROFILE_JPEG_VLD_444Test()
    {
        Assert.That(
            D3D12_VIDEO_DECODE_PROFILE_JPEG_VLD_444,
            Is.EqualTo(
                new Guid(0x4cd00e17, 0x89ba, 0x48ef, 0xb9, 0xf9, 0xed, 0xcb, 0x82, 0x71, 0x3f, 0x65)
            )
        );
    }
}
