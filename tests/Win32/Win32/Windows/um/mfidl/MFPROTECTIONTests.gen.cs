// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using NUnit.Framework;
using static Silk.NET.Windows.MFPROTECTION;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "MFPROTECTION"/> class.</summary>
public static partial class MFPROTECTIONTests
{
    /// <summary>Validates that the value of the <see cref = "MFPROTECTION_DISABLE"/> property is correct.</summary>

    [Test]
    public static void MFPROTECTION_DISABLETest()
    {
        Assert.That(
            MFPROTECTION_DISABLE,
            Is.EqualTo(
                new Guid(0x8cc6d81b, 0xfec6, 0x4d8f, 0x96, 0x4b, 0xcf, 0xba, 0x0b, 0x0d, 0xad, 0x0d)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFPROTECTION_CONSTRICTVIDEO"/> property is correct.</summary>

    [Test]
    public static void MFPROTECTION_CONSTRICTVIDEOTest()
    {
        Assert.That(
            MFPROTECTION_CONSTRICTVIDEO,
            Is.EqualTo(
                new Guid(0x193370ce, 0xc5e4, 0x4c3a, 0x8a, 0x66, 0x69, 0x59, 0xb4, 0xda, 0x44, 0x42)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFPROTECTION_CONSTRICTVIDEO_NOOPM"/> property is correct.</summary>

    [Test]
    public static void MFPROTECTION_CONSTRICTVIDEO_NOOPMTest()
    {
        Assert.That(
            MFPROTECTION_CONSTRICTVIDEO_NOOPM,
            Is.EqualTo(
                new Guid(0xa580e8cd, 0xc247, 0x4957, 0xb9, 0x83, 0x3c, 0x2e, 0xeb, 0xd1, 0xff, 0x59)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFPROTECTION_CONSTRICTAUDIO"/> property is correct.</summary>

    [Test]
    public static void MFPROTECTION_CONSTRICTAUDIOTest()
    {
        Assert.That(
            MFPROTECTION_CONSTRICTAUDIO,
            Is.EqualTo(
                new Guid(0xffc99b44, 0xdf48, 0x4e16, 0x8e, 0x66, 0x09, 0x68, 0x92, 0xc1, 0x57, 0x8a)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFPROTECTION_TRUSTEDAUDIODRIVERS"/> property is correct.</summary>

    [Test]
    public static void MFPROTECTION_TRUSTEDAUDIODRIVERSTest()
    {
        Assert.That(
            MFPROTECTION_TRUSTEDAUDIODRIVERS,
            Is.EqualTo(
                new Guid(0x65bdf3d2, 0x0168, 0x4816, 0xa5, 0x33, 0x55, 0xd4, 0x7b, 0x02, 0x71, 0x01)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFPROTECTION_HDCP"/> property is correct.</summary>

    [Test]
    public static void MFPROTECTION_HDCPTest()
    {
        Assert.That(
            MFPROTECTION_HDCP,
            Is.EqualTo(
                new Guid(0xAE7CC03D, 0xC828, 0x4021, 0xac, 0xb7, 0xd5, 0x78, 0xd2, 0x7a, 0xaf, 0x13)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFPROTECTION_CGMSA"/> property is correct.</summary>

    [Test]
    public static void MFPROTECTION_CGMSATest()
    {
        Assert.That(
            MFPROTECTION_CGMSA,
            Is.EqualTo(
                new Guid(0xE57E69E9, 0x226B, 0x4d31, 0xB4, 0xE3, 0xD3, 0xDB, 0x00, 0x87, 0x36, 0xDD)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFPROTECTION_ACP"/> property is correct.</summary>

    [Test]
    public static void MFPROTECTION_ACPTest()
    {
        Assert.That(
            MFPROTECTION_ACP,
            Is.EqualTo(
                new Guid(0xc3fd11c6, 0xf8b7, 0x4d20, 0xb0, 0x08, 0x1d, 0xb1, 0x7d, 0x61, 0xf2, 0xda)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFPROTECTION_WMDRMOTA"/> property is correct.</summary>

    [Test]
    public static void MFPROTECTION_WMDRMOTATest()
    {
        Assert.That(
            MFPROTECTION_WMDRMOTA,
            Is.EqualTo(
                new Guid(0xa267a6a1, 0x362e, 0x47d0, 0x88, 0x05, 0x46, 0x28, 0x59, 0x8a, 0x23, 0xe4)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFPROTECTION_FFT"/> property is correct.</summary>

    [Test]
    public static void MFPROTECTION_FFTTest()
    {
        Assert.That(
            MFPROTECTION_FFT,
            Is.EqualTo(
                new Guid(0x462a56b2, 0x2866, 0x4bb6, 0x98, 0x0d, 0x6d, 0x8d, 0x9e, 0xdb, 0x1a, 0x8c)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFPROTECTION_PROTECTED_SURFACE"/> property is correct.</summary>

    [Test]
    public static void MFPROTECTION_PROTECTED_SURFACETest()
    {
        Assert.That(
            MFPROTECTION_PROTECTED_SURFACE,
            Is.EqualTo(
                new Guid(0x4f5d9566, 0xe742, 0x4a25, 0x8d, 0x1f, 0xd2, 0x87, 0xb5, 0xfa, 0x0a, 0xde)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFPROTECTION_DISABLE_SCREEN_SCRAPE"/> property is correct.</summary>

    [Test]
    public static void MFPROTECTION_DISABLE_SCREEN_SCRAPETest()
    {
        Assert.That(
            MFPROTECTION_DISABLE_SCREEN_SCRAPE,
            Is.EqualTo(
                new Guid(0xa21179a4, 0xb7cd, 0x40d8, 0x96, 0x14, 0x8e, 0xf2, 0x37, 0x1b, 0xa7, 0x8d)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFPROTECTION_VIDEO_FRAMES"/> property is correct.</summary>

    [Test]
    public static void MFPROTECTION_VIDEO_FRAMESTest()
    {
        Assert.That(
            MFPROTECTION_VIDEO_FRAMES,
            Is.EqualTo(
                new Guid(0x36a59cbc, 0x7401, 0x4a8c, 0xbc, 0x20, 0x46, 0xa7, 0xc9, 0xe5, 0x97, 0xf0)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFPROTECTION_HARDWARE"/> property is correct.</summary>

    [Test]
    public static void MFPROTECTION_HARDWARETest()
    {
        Assert.That(
            MFPROTECTION_HARDWARE,
            Is.EqualTo(
                new Guid(0x4ee7f0c1, 0x9ed7, 0x424f, 0xb6, 0xbe, 0x99, 0x6b, 0x33, 0x52, 0x88, 0x56)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFPROTECTION_HDCP_WITH_TYPE_ENFORCEMENT"/> property is correct.</summary>

    [Test]
    public static void MFPROTECTION_HDCP_WITH_TYPE_ENFORCEMENTTest()
    {
        Assert.That(
            MFPROTECTION_HDCP_WITH_TYPE_ENFORCEMENT,
            Is.EqualTo(
                new Guid(0xa4a585e8, 0xed60, 0x442d, 0x81, 0x4d, 0xdb, 0x4d, 0x42, 0x20, 0xa0, 0x6d)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFPROTECTION_GRAPHICS_TRANSFER_AES_ENCRYPTION"/> property is correct.</summary>

    [Test]
    public static void MFPROTECTION_GRAPHICS_TRANSFER_AES_ENCRYPTIONTest()
    {
        Assert.That(
            MFPROTECTION_GRAPHICS_TRANSFER_AES_ENCRYPTION,
            Is.EqualTo(
                new Guid(0xc873de64, 0xd8a5, 0x49e6, 0x88, 0xbb, 0xfb, 0x96, 0x3f, 0xd3, 0xd4, 0xce)
            )
        );
    }
}
