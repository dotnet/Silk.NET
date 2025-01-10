// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/uuids.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using NUnit.Framework;
using static Silk.NET.Windows.MEDIASUBTYPE;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "MEDIASUBTYPE"/> class.</summary>
public static partial class MEDIASUBTYPETests
{
    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_None"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_NoneTest()
    {
        Assert.That(
            MEDIASUBTYPE_None,
            Is.EqualTo(
                new Guid(0xe436eb8e, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_DVB_SUBTITLES"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_DVB_SUBTITLESTest()
    {
        Assert.That(
            MEDIASUBTYPE_DVB_SUBTITLES,
            Is.EqualTo(
                new Guid(0x34FFCBC3, 0xD5B3, 0x4171, 0x90, 0x02, 0xD4, 0xC6, 0x03, 0x01, 0x69, 0x7F)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_ISDB_CAPTIONS"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_ISDB_CAPTIONSTest()
    {
        Assert.That(
            MEDIASUBTYPE_ISDB_CAPTIONS,
            Is.EqualTo(
                new Guid(0x059dd67d, 0x2e55, 0x4d41, 0x8d, 0x1b, 0x01, 0xf5, 0xe4, 0xf5, 0x06, 0x07)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_ISDB_SUPERIMPOSE"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_ISDB_SUPERIMPOSETest()
    {
        Assert.That(
            MEDIASUBTYPE_ISDB_SUPERIMPOSE,
            Is.EqualTo(
                new Guid(0x36dc6d28, 0xf1a6, 0x4216, 0x90, 0x48, 0x9c, 0xfc, 0xef, 0xeb, 0x5e, 0xba)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_CLPL"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_CLPLTest()
    {
        Assert.That(
            MEDIASUBTYPE_CLPL,
            Is.EqualTo(
                new Guid(0x4C504C43, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_YUYV"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_YUYVTest()
    {
        Assert.That(
            MEDIASUBTYPE_YUYV,
            Is.EqualTo(
                new Guid(0x56595559, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_IYUV"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_IYUVTest()
    {
        Assert.That(
            MEDIASUBTYPE_IYUV,
            Is.EqualTo(
                new Guid(0x56555949, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_YVU9"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_YVU9Test()
    {
        Assert.That(
            MEDIASUBTYPE_YVU9,
            Is.EqualTo(
                new Guid(0x39555659, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_Y411"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_Y411Test()
    {
        Assert.That(
            MEDIASUBTYPE_Y411,
            Is.EqualTo(
                new Guid(0x31313459, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_Y41P"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_Y41PTest()
    {
        Assert.That(
            MEDIASUBTYPE_Y41P,
            Is.EqualTo(
                new Guid(0x50313459, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_YUY2"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_YUY2Test()
    {
        Assert.That(
            MEDIASUBTYPE_YUY2,
            Is.EqualTo(
                new Guid(0x32595559, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_YVYU"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_YVYUTest()
    {
        Assert.That(
            MEDIASUBTYPE_YVYU,
            Is.EqualTo(
                new Guid(0x55595659, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_UYVY"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_UYVYTest()
    {
        Assert.That(
            MEDIASUBTYPE_UYVY,
            Is.EqualTo(
                new Guid(0x59565955, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_Y211"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_Y211Test()
    {
        Assert.That(
            MEDIASUBTYPE_Y211,
            Is.EqualTo(
                new Guid(0x31313259, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_CLJR"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_CLJRTest()
    {
        Assert.That(
            MEDIASUBTYPE_CLJR,
            Is.EqualTo(
                new Guid(0x524a4c43, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_IF09"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_IF09Test()
    {
        Assert.That(
            MEDIASUBTYPE_IF09,
            Is.EqualTo(
                new Guid(0x39304649, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_CPLA"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_CPLATest()
    {
        Assert.That(
            MEDIASUBTYPE_CPLA,
            Is.EqualTo(
                new Guid(0x414c5043, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_MJPG"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_MJPGTest()
    {
        Assert.That(
            MEDIASUBTYPE_MJPG,
            Is.EqualTo(
                new Guid(0x47504A4D, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_TVMJ"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_TVMJTest()
    {
        Assert.That(
            MEDIASUBTYPE_TVMJ,
            Is.EqualTo(
                new Guid(0x4A4D5654, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_WAKE"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_WAKETest()
    {
        Assert.That(
            MEDIASUBTYPE_WAKE,
            Is.EqualTo(
                new Guid(0x454B4157, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_CFCC"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_CFCCTest()
    {
        Assert.That(
            MEDIASUBTYPE_CFCC,
            Is.EqualTo(
                new Guid(0x43434643, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_IJPG"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_IJPGTest()
    {
        Assert.That(
            MEDIASUBTYPE_IJPG,
            Is.EqualTo(
                new Guid(0x47504A49, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_Plum"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_PlumTest()
    {
        Assert.That(
            MEDIASUBTYPE_Plum,
            Is.EqualTo(
                new Guid(0x6D756C50, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_DVCS"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_DVCSTest()
    {
        Assert.That(
            MEDIASUBTYPE_DVCS,
            Is.EqualTo(
                new Guid(0x53435644, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_H264"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_H264Test()
    {
        Assert.That(
            MEDIASUBTYPE_H264,
            Is.EqualTo(
                new Guid(0x34363248, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_DVSD"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_DVSDTest()
    {
        Assert.That(
            MEDIASUBTYPE_DVSD,
            Is.EqualTo(
                new Guid(0x44535644, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_MDVF"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_MDVFTest()
    {
        Assert.That(
            MEDIASUBTYPE_MDVF,
            Is.EqualTo(
                new Guid(0x4656444D, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_RGB1"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_RGB1Test()
    {
        Assert.That(
            MEDIASUBTYPE_RGB1,
            Is.EqualTo(
                new Guid(0xe436eb78, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_RGB4"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_RGB4Test()
    {
        Assert.That(
            MEDIASUBTYPE_RGB4,
            Is.EqualTo(
                new Guid(0xe436eb79, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_RGB8"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_RGB8Test()
    {
        Assert.That(
            MEDIASUBTYPE_RGB8,
            Is.EqualTo(
                new Guid(0xe436eb7a, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_RGB565"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_RGB565Test()
    {
        Assert.That(
            MEDIASUBTYPE_RGB565,
            Is.EqualTo(
                new Guid(0xe436eb7b, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_RGB555"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_RGB555Test()
    {
        Assert.That(
            MEDIASUBTYPE_RGB555,
            Is.EqualTo(
                new Guid(0xe436eb7c, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_RGB24"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_RGB24Test()
    {
        Assert.That(
            MEDIASUBTYPE_RGB24,
            Is.EqualTo(
                new Guid(0xe436eb7d, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_RGB32"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_RGB32Test()
    {
        Assert.That(
            MEDIASUBTYPE_RGB32,
            Is.EqualTo(
                new Guid(0xe436eb7e, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_ARGB1555"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_ARGB1555Test()
    {
        Assert.That(
            MEDIASUBTYPE_ARGB1555,
            Is.EqualTo(
                new Guid(0x297c55af, 0xe209, 0x4cb3, 0xb7, 0x57, 0xc7, 0x6d, 0x6b, 0x9c, 0x88, 0xa8)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_ARGB4444"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_ARGB4444Test()
    {
        Assert.That(
            MEDIASUBTYPE_ARGB4444,
            Is.EqualTo(
                new Guid(0x6e6415e6, 0x5c24, 0x425f, 0x93, 0xcd, 0x80, 0x10, 0x2b, 0x3d, 0x1c, 0xca)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_ARGB32"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_ARGB32Test()
    {
        Assert.That(
            MEDIASUBTYPE_ARGB32,
            Is.EqualTo(
                new Guid(0x773c9ac0, 0x3274, 0x11d0, 0xb7, 0x24, 0x0, 0xaa, 0x0, 0x6c, 0x1a, 0x1)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_A2R10G10B10"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_A2R10G10B10Test()
    {
        Assert.That(
            MEDIASUBTYPE_A2R10G10B10,
            Is.EqualTo(
                new Guid(0x2f8bb76d, 0xb644, 0x4550, 0xac, 0xf3, 0xd3, 0x0c, 0xaa, 0x65, 0xd5, 0xc5)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_A2B10G10R10"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_A2B10G10R10Test()
    {
        Assert.That(
            MEDIASUBTYPE_A2B10G10R10,
            Is.EqualTo(
                new Guid(0x576f7893, 0xbdf6, 0x48c4, 0x87, 0x5f, 0xae, 0x7b, 0x81, 0x83, 0x45, 0x67)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_AYUV"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_AYUVTest()
    {
        Assert.That(
            MEDIASUBTYPE_AYUV,
            Is.EqualTo(
                new Guid(0x56555941, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_AI44"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_AI44Test()
    {
        Assert.That(
            MEDIASUBTYPE_AI44,
            Is.EqualTo(
                new Guid(0x34344941, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_IA44"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_IA44Test()
    {
        Assert.That(
            MEDIASUBTYPE_IA44,
            Is.EqualTo(
                new Guid(0x34344149, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_RGB32_D3D_DX7_RT"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_RGB32_D3D_DX7_RTTest()
    {
        Assert.That(
            MEDIASUBTYPE_RGB32_D3D_DX7_RT,
            Is.EqualTo(
                new Guid(0x32335237, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_RGB16_D3D_DX7_RT"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_RGB16_D3D_DX7_RTTest()
    {
        Assert.That(
            MEDIASUBTYPE_RGB16_D3D_DX7_RT,
            Is.EqualTo(
                new Guid(0x36315237, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_ARGB32_D3D_DX7_RT"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_ARGB32_D3D_DX7_RTTest()
    {
        Assert.That(
            MEDIASUBTYPE_ARGB32_D3D_DX7_RT,
            Is.EqualTo(
                new Guid(0x38384137, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_ARGB4444_D3D_DX7_RT"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_ARGB4444_D3D_DX7_RTTest()
    {
        Assert.That(
            MEDIASUBTYPE_ARGB4444_D3D_DX7_RT,
            Is.EqualTo(
                new Guid(0x34344137, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_ARGB1555_D3D_DX7_RT"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_ARGB1555_D3D_DX7_RTTest()
    {
        Assert.That(
            MEDIASUBTYPE_ARGB1555_D3D_DX7_RT,
            Is.EqualTo(
                new Guid(0x35314137, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_RGB32_D3D_DX9_RT"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_RGB32_D3D_DX9_RTTest()
    {
        Assert.That(
            MEDIASUBTYPE_RGB32_D3D_DX9_RT,
            Is.EqualTo(
                new Guid(0x32335239, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_RGB16_D3D_DX9_RT"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_RGB16_D3D_DX9_RTTest()
    {
        Assert.That(
            MEDIASUBTYPE_RGB16_D3D_DX9_RT,
            Is.EqualTo(
                new Guid(0x36315239, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_ARGB32_D3D_DX9_RT"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_ARGB32_D3D_DX9_RTTest()
    {
        Assert.That(
            MEDIASUBTYPE_ARGB32_D3D_DX9_RT,
            Is.EqualTo(
                new Guid(0x38384139, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_ARGB4444_D3D_DX9_RT"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_ARGB4444_D3D_DX9_RTTest()
    {
        Assert.That(
            MEDIASUBTYPE_ARGB4444_D3D_DX9_RT,
            Is.EqualTo(
                new Guid(0x34344139, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_ARGB1555_D3D_DX9_RT"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_ARGB1555_D3D_DX9_RTTest()
    {
        Assert.That(
            MEDIASUBTYPE_ARGB1555_D3D_DX9_RT,
            Is.EqualTo(
                new Guid(0x35314139, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_YV12"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_YV12Test()
    {
        Assert.That(
            MEDIASUBTYPE_YV12,
            Is.EqualTo(
                new Guid(0x32315659, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_NV12"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_NV12Test()
    {
        Assert.That(
            MEDIASUBTYPE_NV12,
            Is.EqualTo(
                new Guid(0x3231564E, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_NV11"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_NV11Test()
    {
        Assert.That(
            MEDIASUBTYPE_NV11,
            Is.EqualTo(
                new Guid(0x3131564E, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_P208"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_P208Test()
    {
        Assert.That(
            MEDIASUBTYPE_P208,
            Is.EqualTo(
                new Guid(0x38303250, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_P210"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_P210Test()
    {
        Assert.That(
            MEDIASUBTYPE_P210,
            Is.EqualTo(
                new Guid(0x30313250, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_P216"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_P216Test()
    {
        Assert.That(
            MEDIASUBTYPE_P216,
            Is.EqualTo(
                new Guid(0x36313250, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_P010"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_P010Test()
    {
        Assert.That(
            MEDIASUBTYPE_P010,
            Is.EqualTo(
                new Guid(0x30313050, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_P016"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_P016Test()
    {
        Assert.That(
            MEDIASUBTYPE_P016,
            Is.EqualTo(
                new Guid(0x36313050, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_Y210"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_Y210Test()
    {
        Assert.That(
            MEDIASUBTYPE_Y210,
            Is.EqualTo(
                new Guid(0x30313259, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_Y216"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_Y216Test()
    {
        Assert.That(
            MEDIASUBTYPE_Y216,
            Is.EqualTo(
                new Guid(0x36313259, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_P408"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_P408Test()
    {
        Assert.That(
            MEDIASUBTYPE_P408,
            Is.EqualTo(
                new Guid(0x38303450, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_NV24"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_NV24Test()
    {
        Assert.That(
            MEDIASUBTYPE_NV24,
            Is.EqualTo(
                new Guid(0x3432564E, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_420O"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_420OTest()
    {
        Assert.That(
            MEDIASUBTYPE_420O,
            Is.EqualTo(
                new Guid(0x4F303234, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_IMC1"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_IMC1Test()
    {
        Assert.That(
            MEDIASUBTYPE_IMC1,
            Is.EqualTo(
                new Guid(0x31434D49, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_IMC2"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_IMC2Test()
    {
        Assert.That(
            MEDIASUBTYPE_IMC2,
            Is.EqualTo(
                new Guid(0x32434D49, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_IMC3"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_IMC3Test()
    {
        Assert.That(
            MEDIASUBTYPE_IMC3,
            Is.EqualTo(
                new Guid(0x33434D49, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_IMC4"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_IMC4Test()
    {
        Assert.That(
            MEDIASUBTYPE_IMC4,
            Is.EqualTo(
                new Guid(0x34434D49, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_S340"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_S340Test()
    {
        Assert.That(
            MEDIASUBTYPE_S340,
            Is.EqualTo(
                new Guid(0x30343353, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_S342"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_S342Test()
    {
        Assert.That(
            MEDIASUBTYPE_S342,
            Is.EqualTo(
                new Guid(0x32343353, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_Overlay"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_OverlayTest()
    {
        Assert.That(
            MEDIASUBTYPE_Overlay,
            Is.EqualTo(
                new Guid(0xe436eb7f, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_MPEG1Packet"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_MPEG1PacketTest()
    {
        Assert.That(
            MEDIASUBTYPE_MPEG1Packet,
            Is.EqualTo(
                new Guid(0xe436eb80, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_MPEG1Payload"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_MPEG1PayloadTest()
    {
        Assert.That(
            MEDIASUBTYPE_MPEG1Payload,
            Is.EqualTo(
                new Guid(0xe436eb81, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_MPEG1AudioPayload"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_MPEG1AudioPayloadTest()
    {
        Assert.That(
            MEDIASUBTYPE_MPEG1AudioPayload,
            Is.EqualTo(
                new Guid(0x00000050, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xAA, 0x00, 0x38, 0x9B, 0x71)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_MPEG1System"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_MPEG1SystemTest()
    {
        Assert.That(
            MEDIASUBTYPE_MPEG1System,
            Is.EqualTo(
                new Guid(0xe436eb84, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_MPEG1VideoCD"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_MPEG1VideoCDTest()
    {
        Assert.That(
            MEDIASUBTYPE_MPEG1VideoCD,
            Is.EqualTo(
                new Guid(0xe436eb85, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_MPEG1Video"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_MPEG1VideoTest()
    {
        Assert.That(
            MEDIASUBTYPE_MPEG1Video,
            Is.EqualTo(
                new Guid(0xe436eb86, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_MPEG1Audio"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_MPEG1AudioTest()
    {
        Assert.That(
            MEDIASUBTYPE_MPEG1Audio,
            Is.EqualTo(
                new Guid(0xe436eb87, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_Avi"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_AviTest()
    {
        Assert.That(
            MEDIASUBTYPE_Avi,
            Is.EqualTo(
                new Guid(0xe436eb88, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_Asf"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_AsfTest()
    {
        Assert.That(
            MEDIASUBTYPE_Asf,
            Is.EqualTo(
                new Guid(0x3db80f90, 0x9412, 0x11d1, 0xad, 0xed, 0x0, 0x0, 0xf8, 0x75, 0x4b, 0x99)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_QTMovie"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_QTMovieTest()
    {
        Assert.That(
            MEDIASUBTYPE_QTMovie,
            Is.EqualTo(
                new Guid(0xe436eb89, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_QTRpza"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_QTRpzaTest()
    {
        Assert.That(
            MEDIASUBTYPE_QTRpza,
            Is.EqualTo(
                new Guid(0x617a7072, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_QTSmc"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_QTSmcTest()
    {
        Assert.That(
            MEDIASUBTYPE_QTSmc,
            Is.EqualTo(
                new Guid(0x20636d73, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_QTRle"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_QTRleTest()
    {
        Assert.That(
            MEDIASUBTYPE_QTRle,
            Is.EqualTo(
                new Guid(0x20656c72, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_QTJpeg"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_QTJpegTest()
    {
        Assert.That(
            MEDIASUBTYPE_QTJpeg,
            Is.EqualTo(
                new Guid(0x6765706a, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_PCMAudio_Obsolete"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_PCMAudio_ObsoleteTest()
    {
        Assert.That(
            MEDIASUBTYPE_PCMAudio_Obsolete,
            Is.EqualTo(
                new Guid(0xe436eb8a, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_PCM"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_PCMTest()
    {
        Assert.That(
            MEDIASUBTYPE_PCM,
            Is.EqualTo(
                new Guid(0x00000001, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xAA, 0x00, 0x38, 0x9B, 0x71)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_WAVE"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_WAVETest()
    {
        Assert.That(
            MEDIASUBTYPE_WAVE,
            Is.EqualTo(
                new Guid(0xe436eb8b, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_AU"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_AUTest()
    {
        Assert.That(
            MEDIASUBTYPE_AU,
            Is.EqualTo(
                new Guid(0xe436eb8c, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_AIFF"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_AIFFTest()
    {
        Assert.That(
            MEDIASUBTYPE_AIFF,
            Is.EqualTo(
                new Guid(0xe436eb8d, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_dvsd"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_dvsdTest()
    {
        Assert.That(
            MEDIASUBTYPE_dvsd,
            Is.EqualTo(
                new Guid(0x64737664, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_dvhd"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_dvhdTest()
    {
        Assert.That(
            MEDIASUBTYPE_dvhd,
            Is.EqualTo(
                new Guid(0x64687664, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_dvsl"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_dvslTest()
    {
        Assert.That(
            MEDIASUBTYPE_dvsl,
            Is.EqualTo(
                new Guid(0x6c737664, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_dv25"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_dv25Test()
    {
        Assert.That(
            MEDIASUBTYPE_dv25,
            Is.EqualTo(
                new Guid(0x35327664, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_dv50"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_dv50Test()
    {
        Assert.That(
            MEDIASUBTYPE_dv50,
            Is.EqualTo(
                new Guid(0x30357664, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_dvh1"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_dvh1Test()
    {
        Assert.That(
            MEDIASUBTYPE_dvh1,
            Is.EqualTo(
                new Guid(0x31687664, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_Line21_BytePair"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_Line21_BytePairTest()
    {
        Assert.That(
            MEDIASUBTYPE_Line21_BytePair,
            Is.EqualTo(
                new Guid(0x6e8d4a22, 0x310c, 0x11d0, 0xb7, 0x9a, 0x0, 0xaa, 0x0, 0x37, 0x67, 0xa7)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_Line21_GOPPacket"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_Line21_GOPPacketTest()
    {
        Assert.That(
            MEDIASUBTYPE_Line21_GOPPacket,
            Is.EqualTo(
                new Guid(0x6e8d4a23, 0x310c, 0x11d0, 0xb7, 0x9a, 0x0, 0xaa, 0x0, 0x37, 0x67, 0xa7)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_Line21_VBIRawData"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_Line21_VBIRawDataTest()
    {
        Assert.That(
            MEDIASUBTYPE_Line21_VBIRawData,
            Is.EqualTo(
                new Guid(0x6e8d4a24, 0x310c, 0x11d0, 0xb7, 0x9a, 0x0, 0xaa, 0x0, 0x37, 0x67, 0xa7)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_708_608Data"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_708_608DataTest()
    {
        Assert.That(
            MEDIASUBTYPE_708_608Data,
            Is.EqualTo(
                new Guid(0xaf414bc, 0x4ed2, 0x445e, 0x98, 0x39, 0x8f, 0x9, 0x55, 0x68, 0xab, 0x3c)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_DtvCcData"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_DtvCcDataTest()
    {
        Assert.That(
            MEDIASUBTYPE_DtvCcData,
            Is.EqualTo(
                new Guid(0xF52ADDAA, 0x36F0, 0x43F5, 0x95, 0xEA, 0x6D, 0x86, 0x64, 0x84, 0x26, 0x2A)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_CC_CONTAINER"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_CC_CONTAINERTest()
    {
        Assert.That(
            MEDIASUBTYPE_CC_CONTAINER,
            Is.EqualTo(
                new Guid(0x7ea626db, 0x54da, 0x437b, 0xbe, 0x9f, 0xf7, 0x30, 0x73, 0xad, 0xfa, 0x3c)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_TELETEXT"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_TELETEXTTest()
    {
        Assert.That(
            MEDIASUBTYPE_TELETEXT,
            Is.EqualTo(
                new Guid(0xf72a76e3, 0xeb0a, 0x11d0, 0xac, 0xe4, 0x00, 0x00, 0xc0, 0xcc, 0x16, 0xba)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_VBI"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_VBITest()
    {
        Assert.That(
            MEDIASUBTYPE_VBI,
            Is.EqualTo(
                new Guid(0x663da43c, 0x3e8, 0x4e9a, 0x9c, 0xd5, 0xbf, 0x11, 0xed, 0xd, 0xef, 0x76)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_WSS"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_WSSTest()
    {
        Assert.That(
            MEDIASUBTYPE_WSS,
            Is.EqualTo(
                new Guid(0x2791D576, 0x8E7A, 0x466F, 0x9E, 0x90, 0x5D, 0x3F, 0x30, 0x83, 0x73, 0x8B)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_XDS"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_XDSTest()
    {
        Assert.That(
            MEDIASUBTYPE_XDS,
            Is.EqualTo(
                new Guid(0x1ca73e3, 0xdce6, 0x4575, 0xaf, 0xe1, 0x2b, 0xf1, 0xc9, 0x2, 0xca, 0xf3)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_VPS"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_VPSTest()
    {
        Assert.That(
            MEDIASUBTYPE_VPS,
            Is.EqualTo(
                new Guid(0xa1b3f620, 0x9792, 0x4d8d, 0x81, 0xa4, 0x86, 0xaf, 0x25, 0x77, 0x20, 0x90)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_DRM_Audio"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_DRM_AudioTest()
    {
        Assert.That(
            MEDIASUBTYPE_DRM_Audio,
            Is.EqualTo(
                new Guid(0x00000009, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_IEEE_FLOAT"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_IEEE_FLOATTest()
    {
        Assert.That(
            MEDIASUBTYPE_IEEE_FLOAT,
            Is.EqualTo(
                new Guid(0x00000003, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_DOLBY_AC3_SPDIF"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_DOLBY_AC3_SPDIFTest()
    {
        Assert.That(
            MEDIASUBTYPE_DOLBY_AC3_SPDIF,
            Is.EqualTo(
                new Guid(0x00000092, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_RAW_SPORT"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_RAW_SPORTTest()
    {
        Assert.That(
            MEDIASUBTYPE_RAW_SPORT,
            Is.EqualTo(
                new Guid(0x00000240, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_SPDIF_TAG_241h"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_SPDIF_TAG_241hTest()
    {
        Assert.That(
            MEDIASUBTYPE_SPDIF_TAG_241h,
            Is.EqualTo(
                new Guid(0x00000241, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_DssVideo"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_DssVideoTest()
    {
        Assert.That(
            MEDIASUBTYPE_DssVideo,
            Is.EqualTo(
                new Guid(0xa0af4f81, 0xe163, 0x11d0, 0xba, 0xd9, 0x0, 0x60, 0x97, 0x44, 0x11, 0x1a)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_DssAudio"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_DssAudioTest()
    {
        Assert.That(
            MEDIASUBTYPE_DssAudio,
            Is.EqualTo(
                new Guid(0xa0af4f82, 0xe163, 0x11d0, 0xba, 0xd9, 0x0, 0x60, 0x97, 0x44, 0x11, 0x1a)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_VPVideo"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_VPVideoTest()
    {
        Assert.That(
            MEDIASUBTYPE_VPVideo,
            Is.EqualTo(
                new Guid(0x5a9b6a40, 0x1a22, 0x11d1, 0xba, 0xd9, 0x0, 0x60, 0x97, 0x44, 0x11, 0x1a)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_VPVBI"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_VPVBITest()
    {
        Assert.That(
            MEDIASUBTYPE_VPVBI,
            Is.EqualTo(
                new Guid(0x5a9b6a41, 0x1a22, 0x11d1, 0xba, 0xd9, 0x0, 0x60, 0x97, 0x44, 0x11, 0x1a)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_AnalogVideo_NTSC_M"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_AnalogVideo_NTSC_MTest()
    {
        Assert.That(
            MEDIASUBTYPE_AnalogVideo_NTSC_M,
            Is.EqualTo(
                new Guid(0x482dde2, 0x7817, 0x11cf, 0x8a, 0x3, 0x0, 0xaa, 0x0, 0x6e, 0xcb, 0x65)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_AnalogVideo_PAL_B"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_AnalogVideo_PAL_BTest()
    {
        Assert.That(
            MEDIASUBTYPE_AnalogVideo_PAL_B,
            Is.EqualTo(
                new Guid(0x482dde5, 0x7817, 0x11cf, 0x8a, 0x3, 0x0, 0xaa, 0x0, 0x6e, 0xcb, 0x65)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_AnalogVideo_PAL_D"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_AnalogVideo_PAL_DTest()
    {
        Assert.That(
            MEDIASUBTYPE_AnalogVideo_PAL_D,
            Is.EqualTo(
                new Guid(0x482dde6, 0x7817, 0x11cf, 0x8a, 0x3, 0x0, 0xaa, 0x0, 0x6e, 0xcb, 0x65)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_AnalogVideo_PAL_G"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_AnalogVideo_PAL_GTest()
    {
        Assert.That(
            MEDIASUBTYPE_AnalogVideo_PAL_G,
            Is.EqualTo(
                new Guid(0x482dde7, 0x7817, 0x11cf, 0x8a, 0x3, 0x0, 0xaa, 0x0, 0x6e, 0xcb, 0x65)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_AnalogVideo_PAL_H"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_AnalogVideo_PAL_HTest()
    {
        Assert.That(
            MEDIASUBTYPE_AnalogVideo_PAL_H,
            Is.EqualTo(
                new Guid(0x482dde8, 0x7817, 0x11cf, 0x8a, 0x3, 0x0, 0xaa, 0x0, 0x6e, 0xcb, 0x65)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_AnalogVideo_PAL_I"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_AnalogVideo_PAL_ITest()
    {
        Assert.That(
            MEDIASUBTYPE_AnalogVideo_PAL_I,
            Is.EqualTo(
                new Guid(0x482dde9, 0x7817, 0x11cf, 0x8a, 0x3, 0x0, 0xaa, 0x0, 0x6e, 0xcb, 0x65)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_AnalogVideo_PAL_M"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_AnalogVideo_PAL_MTest()
    {
        Assert.That(
            MEDIASUBTYPE_AnalogVideo_PAL_M,
            Is.EqualTo(
                new Guid(0x482ddea, 0x7817, 0x11cf, 0x8a, 0x3, 0x0, 0xaa, 0x0, 0x6e, 0xcb, 0x65)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_AnalogVideo_PAL_N"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_AnalogVideo_PAL_NTest()
    {
        Assert.That(
            MEDIASUBTYPE_AnalogVideo_PAL_N,
            Is.EqualTo(
                new Guid(0x482ddeb, 0x7817, 0x11cf, 0x8a, 0x3, 0x0, 0xaa, 0x0, 0x6e, 0xcb, 0x65)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_AnalogVideo_PAL_N_COMBO"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_AnalogVideo_PAL_N_COMBOTest()
    {
        Assert.That(
            MEDIASUBTYPE_AnalogVideo_PAL_N_COMBO,
            Is.EqualTo(
                new Guid(0x482ddec, 0x7817, 0x11cf, 0x8a, 0x3, 0x0, 0xaa, 0x0, 0x6e, 0xcb, 0x65)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_AnalogVideo_SECAM_B"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_AnalogVideo_SECAM_BTest()
    {
        Assert.That(
            MEDIASUBTYPE_AnalogVideo_SECAM_B,
            Is.EqualTo(
                new Guid(0x482ddf0, 0x7817, 0x11cf, 0x8a, 0x3, 0x0, 0xaa, 0x0, 0x6e, 0xcb, 0x65)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_AnalogVideo_SECAM_D"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_AnalogVideo_SECAM_DTest()
    {
        Assert.That(
            MEDIASUBTYPE_AnalogVideo_SECAM_D,
            Is.EqualTo(
                new Guid(0x482ddf1, 0x7817, 0x11cf, 0x8a, 0x3, 0x0, 0xaa, 0x0, 0x6e, 0xcb, 0x65)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_AnalogVideo_SECAM_G"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_AnalogVideo_SECAM_GTest()
    {
        Assert.That(
            MEDIASUBTYPE_AnalogVideo_SECAM_G,
            Is.EqualTo(
                new Guid(0x482ddf2, 0x7817, 0x11cf, 0x8a, 0x3, 0x0, 0xaa, 0x0, 0x6e, 0xcb, 0x65)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_AnalogVideo_SECAM_H"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_AnalogVideo_SECAM_HTest()
    {
        Assert.That(
            MEDIASUBTYPE_AnalogVideo_SECAM_H,
            Is.EqualTo(
                new Guid(0x482ddf3, 0x7817, 0x11cf, 0x8a, 0x3, 0x0, 0xaa, 0x0, 0x6e, 0xcb, 0x65)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_AnalogVideo_SECAM_K"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_AnalogVideo_SECAM_KTest()
    {
        Assert.That(
            MEDIASUBTYPE_AnalogVideo_SECAM_K,
            Is.EqualTo(
                new Guid(0x482ddf4, 0x7817, 0x11cf, 0x8a, 0x3, 0x0, 0xaa, 0x0, 0x6e, 0xcb, 0x65)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_AnalogVideo_SECAM_K1"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_AnalogVideo_SECAM_K1Test()
    {
        Assert.That(
            MEDIASUBTYPE_AnalogVideo_SECAM_K1,
            Is.EqualTo(
                new Guid(0x482ddf5, 0x7817, 0x11cf, 0x8a, 0x3, 0x0, 0xaa, 0x0, 0x6e, 0xcb, 0x65)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MEDIASUBTYPE_AnalogVideo_SECAM_L"/> property is correct.</summary>

    [Test]
    public static void MEDIASUBTYPE_AnalogVideo_SECAM_LTest()
    {
        Assert.That(
            MEDIASUBTYPE_AnalogVideo_SECAM_L,
            Is.EqualTo(
                new Guid(0x482ddf6, 0x7817, 0x11cf, 0x8a, 0x3, 0x0, 0xaa, 0x0, 0x6e, 0xcb, 0x65)
            )
        );
    }
}
