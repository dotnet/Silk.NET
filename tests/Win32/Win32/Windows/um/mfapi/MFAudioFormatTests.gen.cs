// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using NUnit.Framework;
using static Silk.NET.Windows.MFAudioFormat;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "MFAudioFormat"/> class.</summary>
public static partial class MFAudioFormatTests
{
    /// <summary>Validates that the value of the <see cref = "MFAudioFormat_Base"/> property is correct.</summary>

    [Test]
    public static void MFAudioFormat_BaseTest()
    {
        Assert.That(
            MFAudioFormat_Base,
            Is.EqualTo(
                new Guid(0x00000000, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFAudioFormat_PCM"/> property is correct.</summary>

    [Test]
    public static void MFAudioFormat_PCMTest()
    {
        Assert.That(
            MFAudioFormat_PCM,
            Is.EqualTo(new Guid(1, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71))
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFAudioFormat_Float"/> property is correct.</summary>

    [Test]
    public static void MFAudioFormat_FloatTest()
    {
        Assert.That(
            MFAudioFormat_Float,
            Is.EqualTo(
                new Guid(0x0003, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFAudioFormat_DTS"/> property is correct.</summary>

    [Test]
    public static void MFAudioFormat_DTSTest()
    {
        Assert.That(
            MFAudioFormat_DTS,
            Is.EqualTo(
                new Guid(0x0008, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFAudioFormat_Dolby_AC3_SPDIF"/> property is correct.</summary>

    [Test]
    public static void MFAudioFormat_Dolby_AC3_SPDIFTest()
    {
        Assert.That(
            MFAudioFormat_Dolby_AC3_SPDIF,
            Is.EqualTo(
                new Guid(0x0092, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFAudioFormat_DRM"/> property is correct.</summary>

    [Test]
    public static void MFAudioFormat_DRMTest()
    {
        Assert.That(
            MFAudioFormat_DRM,
            Is.EqualTo(
                new Guid(0x0009, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFAudioFormat_WMAudioV8"/> property is correct.</summary>

    [Test]
    public static void MFAudioFormat_WMAudioV8Test()
    {
        Assert.That(
            MFAudioFormat_WMAudioV8,
            Is.EqualTo(
                new Guid(0x0161, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFAudioFormat_WMAudioV9"/> property is correct.</summary>

    [Test]
    public static void MFAudioFormat_WMAudioV9Test()
    {
        Assert.That(
            MFAudioFormat_WMAudioV9,
            Is.EqualTo(
                new Guid(0x0162, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFAudioFormat_WMAudio_Lossless"/> property is correct.</summary>

    [Test]
    public static void MFAudioFormat_WMAudio_LosslessTest()
    {
        Assert.That(
            MFAudioFormat_WMAudio_Lossless,
            Is.EqualTo(
                new Guid(0x0163, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFAudioFormat_WMASPDIF"/> property is correct.</summary>

    [Test]
    public static void MFAudioFormat_WMASPDIFTest()
    {
        Assert.That(
            MFAudioFormat_WMASPDIF,
            Is.EqualTo(
                new Guid(0x0164, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFAudioFormat_MSP1"/> property is correct.</summary>

    [Test]
    public static void MFAudioFormat_MSP1Test()
    {
        Assert.That(
            MFAudioFormat_MSP1,
            Is.EqualTo(
                new Guid(0x000A, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFAudioFormat_MP3"/> property is correct.</summary>

    [Test]
    public static void MFAudioFormat_MP3Test()
    {
        Assert.That(
            MFAudioFormat_MP3,
            Is.EqualTo(
                new Guid(0x0055, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFAudioFormat_MPEG"/> property is correct.</summary>

    [Test]
    public static void MFAudioFormat_MPEGTest()
    {
        Assert.That(
            MFAudioFormat_MPEG,
            Is.EqualTo(
                new Guid(0x0050, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFAudioFormat_AAC"/> property is correct.</summary>

    [Test]
    public static void MFAudioFormat_AACTest()
    {
        Assert.That(
            MFAudioFormat_AAC,
            Is.EqualTo(
                new Guid(0x1610, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFAudioFormat_ADTS"/> property is correct.</summary>

    [Test]
    public static void MFAudioFormat_ADTSTest()
    {
        Assert.That(
            MFAudioFormat_ADTS,
            Is.EqualTo(
                new Guid(0x1600, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFAudioFormat_AMR_NB"/> property is correct.</summary>

    [Test]
    public static void MFAudioFormat_AMR_NBTest()
    {
        Assert.That(
            MFAudioFormat_AMR_NB,
            Is.EqualTo(
                new Guid(0x7361, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFAudioFormat_AMR_WB"/> property is correct.</summary>

    [Test]
    public static void MFAudioFormat_AMR_WBTest()
    {
        Assert.That(
            MFAudioFormat_AMR_WB,
            Is.EqualTo(
                new Guid(0x7362, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFAudioFormat_AMR_WP"/> property is correct.</summary>

    [Test]
    public static void MFAudioFormat_AMR_WPTest()
    {
        Assert.That(
            MFAudioFormat_AMR_WP,
            Is.EqualTo(
                new Guid(0x7363, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFAudioFormat_FLAC"/> property is correct.</summary>

    [Test]
    public static void MFAudioFormat_FLACTest()
    {
        Assert.That(
            MFAudioFormat_FLAC,
            Is.EqualTo(
                new Guid(0xF1AC, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFAudioFormat_ALAC"/> property is correct.</summary>

    [Test]
    public static void MFAudioFormat_ALACTest()
    {
        Assert.That(
            MFAudioFormat_ALAC,
            Is.EqualTo(
                new Guid(0x6C61, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFAudioFormat_Opus"/> property is correct.</summary>

    [Test]
    public static void MFAudioFormat_OpusTest()
    {
        Assert.That(
            MFAudioFormat_Opus,
            Is.EqualTo(
                new Guid(0x704F, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFAudioFormat_Dolby_AC4"/> property is correct.</summary>

    [Test]
    public static void MFAudioFormat_Dolby_AC4Test()
    {
        Assert.That(
            MFAudioFormat_Dolby_AC4,
            Is.EqualTo(
                new Guid(0xAC40, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFAudioFormat_Dolby_AC3"/> property is correct.</summary>

    [Test]
    public static void MFAudioFormat_Dolby_AC3Test()
    {
        Assert.That(
            MFAudioFormat_Dolby_AC3,
            Is.EqualTo(
                new Guid(
                    0xe06d802c,
                    0xdb46,
                    0x11cf,
                    0xb4,
                    0xd1,
                    0x00,
                    0x80,
                    0x05f,
                    0x6c,
                    0xbb,
                    0xea
                )
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFAudioFormat_Dolby_DDPlus"/> property is correct.</summary>

    [Test]
    public static void MFAudioFormat_Dolby_DDPlusTest()
    {
        Assert.That(
            MFAudioFormat_Dolby_DDPlus,
            Is.EqualTo(
                new Guid(0xa7fb87af, 0x2d02, 0x42fb, 0xa4, 0xd4, 0x5, 0xcd, 0x93, 0x84, 0x3b, 0xdd)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFAudioFormat_Dolby_AC4_V1"/> property is correct.</summary>

    [Test]
    public static void MFAudioFormat_Dolby_AC4_V1Test()
    {
        Assert.That(
            MFAudioFormat_Dolby_AC4_V1,
            Is.EqualTo(
                new Guid(0x36b7927c, 0x3d87, 0x4a2a, 0x91, 0x96, 0xa2, 0x1a, 0xd9, 0xe9, 0x35, 0xe6)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFAudioFormat_Dolby_AC4_V2"/> property is correct.</summary>

    [Test]
    public static void MFAudioFormat_Dolby_AC4_V2Test()
    {
        Assert.That(
            MFAudioFormat_Dolby_AC4_V2,
            Is.EqualTo(
                new Guid(0x7998b2a0, 0x17dd, 0x49b6, 0x8d, 0xfa, 0x9b, 0x27, 0x85, 0x52, 0xa2, 0xac)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFAudioFormat_Dolby_AC4_V1_ES"/> property is correct.</summary>

    [Test]
    public static void MFAudioFormat_Dolby_AC4_V1_ESTest()
    {
        Assert.That(
            MFAudioFormat_Dolby_AC4_V1_ES,
            Is.EqualTo(
                new Guid(0x9d8dccc6, 0xd156, 0x4fb8, 0x97, 0x9c, 0xa8, 0x5b, 0xe7, 0xd2, 0x1d, 0xfa)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFAudioFormat_Dolby_AC4_V2_ES"/> property is correct.</summary>

    [Test]
    public static void MFAudioFormat_Dolby_AC4_V2_ESTest()
    {
        Assert.That(
            MFAudioFormat_Dolby_AC4_V2_ES,
            Is.EqualTo(
                new Guid(0x7e58c9f9, 0xb070, 0x45f4, 0x8c, 0xcd, 0xa9, 0x9a, 0x04, 0x17, 0xc1, 0xac)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFAudioFormat_MPEGH"/> property is correct.</summary>

    [Test]
    public static void MFAudioFormat_MPEGHTest()
    {
        Assert.That(
            MFAudioFormat_MPEGH,
            Is.EqualTo(
                new Guid(0x7c13c441, 0xebf8, 0x4931, 0xb6, 0x78, 0x80, 0x0b, 0x19, 0x24, 0x22, 0x36)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFAudioFormat_MPEGH_ES"/> property is correct.</summary>

    [Test]
    public static void MFAudioFormat_MPEGH_ESTest()
    {
        Assert.That(
            MFAudioFormat_MPEGH_ES,
            Is.EqualTo(
                new Guid(0x19ee97fe, 0x1be0, 0x4255, 0xa8, 0x76, 0xe9, 0x9f, 0x53, 0xa4, 0x2a, 0xe3)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFAudioFormat_Vorbis"/> property is correct.</summary>

    [Test]
    public static void MFAudioFormat_VorbisTest()
    {
        Assert.That(
            MFAudioFormat_Vorbis,
            Is.EqualTo(
                new Guid(0x8D2FD10B, 0x5841, 0x4a6b, 0x89, 0x05, 0x58, 0x8F, 0xEC, 0x1A, 0xDE, 0xD9)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFAudioFormat_DTS_RAW"/> property is correct.</summary>

    [Test]
    public static void MFAudioFormat_DTS_RAWTest()
    {
        Assert.That(
            MFAudioFormat_DTS_RAW,
            Is.EqualTo(
                new Guid(0xE06D8033, 0xDB46, 0x11CF, 0xB4, 0xD1, 0x00, 0x80, 0x5F, 0x6C, 0xBB, 0xEA)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFAudioFormat_DTS_HD"/> property is correct.</summary>

    [Test]
    public static void MFAudioFormat_DTS_HDTest()
    {
        Assert.That(
            MFAudioFormat_DTS_HD,
            Is.EqualTo(
                new Guid(0xA2E58EB7, 0x0FA9, 0x48BB, 0xA4, 0x0C, 0xFA, 0x0E, 0x15, 0x6D, 0x06, 0x45)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFAudioFormat_DTS_XLL"/> property is correct.</summary>

    [Test]
    public static void MFAudioFormat_DTS_XLLTest()
    {
        Assert.That(
            MFAudioFormat_DTS_XLL,
            Is.EqualTo(
                new Guid(0x45B37C1B, 0x8C70, 0x4E59, 0xA7, 0xBE, 0xA1, 0xE4, 0x2C, 0x81, 0xC8, 0x0D)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFAudioFormat_DTS_LBR"/> property is correct.</summary>

    [Test]
    public static void MFAudioFormat_DTS_LBRTest()
    {
        Assert.That(
            MFAudioFormat_DTS_LBR,
            Is.EqualTo(
                new Guid(0xC2FE6F0A, 0x4E3C, 0x4DF1, 0x9B, 0x60, 0x50, 0x86, 0x30, 0x91, 0xE4, 0xB9)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFAudioFormat_DTS_UHD"/> property is correct.</summary>

    [Test]
    public static void MFAudioFormat_DTS_UHDTest()
    {
        Assert.That(
            MFAudioFormat_DTS_UHD,
            Is.EqualTo(
                new Guid(0x87020117, 0xACE3, 0x42DE, 0xB7, 0x3E, 0xC6, 0x56, 0x70, 0x62, 0x63, 0xF8)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFAudioFormat_DTS_UHDY"/> property is correct.</summary>

    [Test]
    public static void MFAudioFormat_DTS_UHDYTest()
    {
        Assert.That(
            MFAudioFormat_DTS_UHDY,
            Is.EqualTo(
                new Guid(0x9B9CCA00, 0x91B9, 0x4CCC, 0x88, 0x3A, 0x8F, 0x78, 0x7A, 0xC3, 0xCC, 0x86)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFAudioFormat_Float_SpatialObjects"/> property is correct.</summary>

    [Test]
    public static void MFAudioFormat_Float_SpatialObjectsTest()
    {
        Assert.That(
            MFAudioFormat_Float_SpatialObjects,
            Is.EqualTo(
                new Guid(0xfa39cd94, 0xbc64, 0x4ab1, 0x9b, 0x71, 0xdc, 0xd0, 0x9d, 0x5a, 0x7e, 0x7a)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFAudioFormat_LPCM"/> property is correct.</summary>

    [Test]
    public static void MFAudioFormat_LPCMTest()
    {
        Assert.That(
            MFAudioFormat_LPCM,
            Is.EqualTo(
                new Guid(0xe06d8032, 0xdb46, 0x11cf, 0xb4, 0xd1, 0x00, 0x80, 0x5f, 0x6c, 0xbb, 0xea)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFAudioFormat_PCM_HDCP"/> property is correct.</summary>

    [Test]
    public static void MFAudioFormat_PCM_HDCPTest()
    {
        Assert.That(
            MFAudioFormat_PCM_HDCP,
            Is.EqualTo(
                new Guid(0xa5e7ff01, 0x8411, 0x4acc, 0xa8, 0x65, 0x5f, 0x49, 0x41, 0x28, 0x8d, 0x80)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFAudioFormat_Dolby_AC3_HDCP"/> property is correct.</summary>

    [Test]
    public static void MFAudioFormat_Dolby_AC3_HDCPTest()
    {
        Assert.That(
            MFAudioFormat_Dolby_AC3_HDCP,
            Is.EqualTo(
                new Guid(0x97663a80, 0x8ffb, 0x4445, 0xa6, 0xba, 0x79, 0x2d, 0x90, 0x8f, 0x49, 0x7f)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFAudioFormat_AAC_HDCP"/> property is correct.</summary>

    [Test]
    public static void MFAudioFormat_AAC_HDCPTest()
    {
        Assert.That(
            MFAudioFormat_AAC_HDCP,
            Is.EqualTo(
                new Guid(0x419bce76, 0x8b72, 0x400f, 0xad, 0xeb, 0x84, 0xb5, 0x7d, 0x63, 0x48, 0x4d)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFAudioFormat_ADTS_HDCP"/> property is correct.</summary>

    [Test]
    public static void MFAudioFormat_ADTS_HDCPTest()
    {
        Assert.That(
            MFAudioFormat_ADTS_HDCP,
            Is.EqualTo(
                new Guid(0xda4963a3, 0x14d8, 0x4dcf, 0x92, 0xb7, 0x19, 0x3e, 0xb8, 0x43, 0x63, 0xdb)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MFAudioFormat_Base_HDCP"/> property is correct.</summary>

    [Test]
    public static void MFAudioFormat_Base_HDCPTest()
    {
        Assert.That(
            MFAudioFormat_Base_HDCP,
            Is.EqualTo(
                new Guid(0x3884b5bc, 0xe277, 0x43fd, 0x98, 0x3d, 0x03, 0x8a, 0xa8, 0xd9, 0xb6, 0x05)
            )
        );
    }
}
