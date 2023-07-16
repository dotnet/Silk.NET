// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodecsdk.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using static Silk.NET.Windows.GUID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "GUID"/> class.</summary>
public static partial class GUIDTests
{
    /// <summary>Validates that the value of the <see cref = "GUID_MetadataFormatUnknown"/> property is correct.</summary>
    [Test]
    public static void GUID_MetadataFormatUnknownTest()
    {
        Assert.That(GUID_MetadataFormatUnknown, Is.EqualTo(new Guid(0xA45E592F, 0x9078, 0x4A7C, 0xAD, 0xB5, 0x4E, 0xDC, 0x4F, 0xD6, 0x1B, 0x1F)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_MetadataFormatIfd"/> property is correct.</summary>
    [Test]
    public static void GUID_MetadataFormatIfdTest()
    {
        Assert.That(GUID_MetadataFormatIfd, Is.EqualTo(new Guid(0x537396C6, 0x2D8A, 0x4BB6, 0x9B, 0xF8, 0x2F, 0x0A, 0x8E, 0x2A, 0x3A, 0xDF)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_MetadataFormatSubIfd"/> property is correct.</summary>
    [Test]
    public static void GUID_MetadataFormatSubIfdTest()
    {
        Assert.That(GUID_MetadataFormatSubIfd, Is.EqualTo(new Guid(0x58A2E128, 0x2DB9, 0x4E57, 0xBB, 0x14, 0x51, 0x77, 0x89, 0x1E, 0xD3, 0x31)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_MetadataFormatExif"/> property is correct.</summary>
    [Test]
    public static void GUID_MetadataFormatExifTest()
    {
        Assert.That(GUID_MetadataFormatExif, Is.EqualTo(new Guid(0x1C3C4F9D, 0xB84A, 0x467D, 0x94, 0x93, 0x36, 0xCF, 0xBD, 0x59, 0xEA, 0x57)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_MetadataFormatGps"/> property is correct.</summary>
    [Test]
    public static void GUID_MetadataFormatGpsTest()
    {
        Assert.That(GUID_MetadataFormatGps, Is.EqualTo(new Guid(0x7134AB8A, 0x9351, 0x44AD, 0xAF, 0x62, 0x44, 0x8D, 0xB6, 0xB5, 0x02, 0xEC)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_MetadataFormatInterop"/> property is correct.</summary>
    [Test]
    public static void GUID_MetadataFormatInteropTest()
    {
        Assert.That(GUID_MetadataFormatInterop, Is.EqualTo(new Guid(0xED686F8E, 0x681F, 0x4C8B, 0xBD, 0x41, 0xA8, 0xAD, 0xDB, 0xF6, 0xB3, 0xFC)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_MetadataFormatApp0"/> property is correct.</summary>
    [Test]
    public static void GUID_MetadataFormatApp0Test()
    {
        Assert.That(GUID_MetadataFormatApp0, Is.EqualTo(new Guid(0x79007028, 0x268D, 0x45d6, 0xA3, 0xC2, 0x35, 0x4E, 0x6A, 0x50, 0x4B, 0xC9)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_MetadataFormatApp1"/> property is correct.</summary>
    [Test]
    public static void GUID_MetadataFormatApp1Test()
    {
        Assert.That(GUID_MetadataFormatApp1, Is.EqualTo(new Guid(0x8FD3DFC3, 0xF951, 0x492B, 0x81, 0x7F, 0x69, 0xC2, 0xE6, 0xD9, 0xA5, 0xB0)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_MetadataFormatApp13"/> property is correct.</summary>
    [Test]
    public static void GUID_MetadataFormatApp13Test()
    {
        Assert.That(GUID_MetadataFormatApp13, Is.EqualTo(new Guid(0x326556A2, 0xF502, 0x4354, 0x9C, 0xC0, 0x8E, 0x3F, 0x48, 0xEA, 0xF6, 0xB5)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_MetadataFormatIPTC"/> property is correct.</summary>
    [Test]
    public static void GUID_MetadataFormatIPTCTest()
    {
        Assert.That(GUID_MetadataFormatIPTC, Is.EqualTo(new Guid(0x4FAB0914, 0xE129, 0x4087, 0xA1, 0xD1, 0xBC, 0x81, 0x2D, 0x45, 0xA7, 0xB5)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_MetadataFormatIRB"/> property is correct.</summary>
    [Test]
    public static void GUID_MetadataFormatIRBTest()
    {
        Assert.That(GUID_MetadataFormatIRB, Is.EqualTo(new Guid(0x16100D66, 0x8570, 0x4BB9, 0xB9, 0x2D, 0xFD, 0xA4, 0xB2, 0x3E, 0xCE, 0x67)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_MetadataFormat8BIMIPTC"/> property is correct.</summary>
    [Test]
    public static void GUID_MetadataFormat8BIMIPTCTest()
    {
        Assert.That(GUID_MetadataFormat8BIMIPTC, Is.EqualTo(new Guid(0x0010568c, 0x0852, 0x4e6a, 0xb1, 0x91, 0x5c, 0x33, 0xac, 0x5b, 0x04, 0x30)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_MetadataFormat8BIMResolutionInfo"/> property is correct.</summary>
    [Test]
    public static void GUID_MetadataFormat8BIMResolutionInfoTest()
    {
        Assert.That(GUID_MetadataFormat8BIMResolutionInfo, Is.EqualTo(new Guid(0x739F305D, 0x81DB, 0x43CB, 0xAC, 0x5E, 0x55, 0x01, 0x3E, 0xF9, 0xF0, 0x03)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_MetadataFormat8BIMIPTCDigest"/> property is correct.</summary>
    [Test]
    public static void GUID_MetadataFormat8BIMIPTCDigestTest()
    {
        Assert.That(GUID_MetadataFormat8BIMIPTCDigest, Is.EqualTo(new Guid(0x1CA32285, 0x9CCD, 0x4786, 0x8B, 0xD8, 0x79, 0x53, 0x9D, 0xB6, 0xA0, 0x06)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_MetadataFormatXMP"/> property is correct.</summary>
    [Test]
    public static void GUID_MetadataFormatXMPTest()
    {
        Assert.That(GUID_MetadataFormatXMP, Is.EqualTo(new Guid(0xBB5ACC38, 0xF216, 0x4CEC, 0xA6, 0xC5, 0x5F, 0x6E, 0x73, 0x97, 0x63, 0xA9)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_MetadataFormatThumbnail"/> property is correct.</summary>
    [Test]
    public static void GUID_MetadataFormatThumbnailTest()
    {
        Assert.That(GUID_MetadataFormatThumbnail, Is.EqualTo(new Guid(0x243dcee9, 0x8703, 0x40ee, 0x8e, 0xf0, 0x22, 0xa6, 0x0, 0xb8, 0x5, 0x8c)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_MetadataFormatChunktEXt"/> property is correct.</summary>
    [Test]
    public static void GUID_MetadataFormatChunktEXtTest()
    {
        Assert.That(GUID_MetadataFormatChunktEXt, Is.EqualTo(new Guid(0x568d8936, 0xc0a9, 0x4923, 0x90, 0x5d, 0xdf, 0x2b, 0x38, 0x23, 0x8f, 0xbc)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_MetadataFormatXMPStruct"/> property is correct.</summary>
    [Test]
    public static void GUID_MetadataFormatXMPStructTest()
    {
        Assert.That(GUID_MetadataFormatXMPStruct, Is.EqualTo(new Guid(0x22383CF1, 0xED17, 0x4E2E, 0xAF, 0x17, 0xD8, 0x5B, 0x8F, 0x6B, 0x30, 0xD0)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_MetadataFormatXMPBag"/> property is correct.</summary>
    [Test]
    public static void GUID_MetadataFormatXMPBagTest()
    {
        Assert.That(GUID_MetadataFormatXMPBag, Is.EqualTo(new Guid(0x833CCA5F, 0xDCB7, 0x4516, 0x80, 0x6F, 0x65, 0x96, 0xAB, 0x26, 0xDC, 0xE4)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_MetadataFormatXMPSeq"/> property is correct.</summary>
    [Test]
    public static void GUID_MetadataFormatXMPSeqTest()
    {
        Assert.That(GUID_MetadataFormatXMPSeq, Is.EqualTo(new Guid(0x63E8DF02, 0xEB6C, 0x456C, 0xA2, 0x24, 0xB2, 0x5E, 0x79, 0x4F, 0xD6, 0x48)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_MetadataFormatXMPAlt"/> property is correct.</summary>
    [Test]
    public static void GUID_MetadataFormatXMPAltTest()
    {
        Assert.That(GUID_MetadataFormatXMPAlt, Is.EqualTo(new Guid(0x7B08A675, 0x91AA, 0x481B, 0xA7, 0x98, 0x4D, 0xA9, 0x49, 0x08, 0x61, 0x3B)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_MetadataFormatLSD"/> property is correct.</summary>
    [Test]
    public static void GUID_MetadataFormatLSDTest()
    {
        Assert.That(GUID_MetadataFormatLSD, Is.EqualTo(new Guid(0xE256031E, 0x6299, 0x4929, 0xB9, 0x8D, 0x5A, 0xC8, 0x84, 0xAF, 0xBA, 0x92)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_MetadataFormatIMD"/> property is correct.</summary>
    [Test]
    public static void GUID_MetadataFormatIMDTest()
    {
        Assert.That(GUID_MetadataFormatIMD, Is.EqualTo(new Guid(0xBD2BB086, 0x4D52, 0x48DD, 0x96, 0x77, 0xDB, 0x48, 0x3E, 0x85, 0xAE, 0x8F)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_MetadataFormatGCE"/> property is correct.</summary>
    [Test]
    public static void GUID_MetadataFormatGCETest()
    {
        Assert.That(GUID_MetadataFormatGCE, Is.EqualTo(new Guid(0x2A25CAD8, 0xDEEB, 0x4C69, 0xA7, 0x88, 0xE, 0xC2, 0x26, 0x6D, 0xCA, 0xFD)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_MetadataFormatAPE"/> property is correct.</summary>
    [Test]
    public static void GUID_MetadataFormatAPETest()
    {
        Assert.That(GUID_MetadataFormatAPE, Is.EqualTo(new Guid(0x2E043DC2, 0xC967, 0x4E05, 0x87, 0x5E, 0x61, 0x8B, 0xF6, 0x7E, 0x85, 0xC3)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_MetadataFormatJpegChrominance"/> property is correct.</summary>
    [Test]
    public static void GUID_MetadataFormatJpegChrominanceTest()
    {
        Assert.That(GUID_MetadataFormatJpegChrominance, Is.EqualTo(new Guid(0xF73D0DCF, 0xCEC6, 0x4F85, 0x9B, 0x0E, 0x1C, 0x39, 0x56, 0xB1, 0xBE, 0xF7)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_MetadataFormatJpegLuminance"/> property is correct.</summary>
    [Test]
    public static void GUID_MetadataFormatJpegLuminanceTest()
    {
        Assert.That(GUID_MetadataFormatJpegLuminance, Is.EqualTo(new Guid(0x86908007, 0xEDFC, 0x4860, 0x8D, 0x4B, 0x4E, 0xE6, 0xE8, 0x3E, 0x60, 0x58)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_MetadataFormatJpegComment"/> property is correct.</summary>
    [Test]
    public static void GUID_MetadataFormatJpegCommentTest()
    {
        Assert.That(GUID_MetadataFormatJpegComment, Is.EqualTo(new Guid(0x220E5F33, 0xAFD3, 0x474E, 0x9D, 0x31, 0x7D, 0x4F, 0xE7, 0x30, 0xF5, 0x57)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_MetadataFormatGifComment"/> property is correct.</summary>
    [Test]
    public static void GUID_MetadataFormatGifCommentTest()
    {
        Assert.That(GUID_MetadataFormatGifComment, Is.EqualTo(new Guid(0xC4B6E0E0, 0xCFB4, 0x4AD3, 0xAB, 0x33, 0x9A, 0xAD, 0x23, 0x55, 0xA3, 0x4A)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_MetadataFormatChunkgAMA"/> property is correct.</summary>
    [Test]
    public static void GUID_MetadataFormatChunkgAMATest()
    {
        Assert.That(GUID_MetadataFormatChunkgAMA, Is.EqualTo(new Guid(0xF00935A5, 0x1D5D, 0x4CD1, 0x81, 0xB2, 0x93, 0x24, 0xD7, 0xEC, 0xA7, 0x81)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_MetadataFormatChunkbKGD"/> property is correct.</summary>
    [Test]
    public static void GUID_MetadataFormatChunkbKGDTest()
    {
        Assert.That(GUID_MetadataFormatChunkbKGD, Is.EqualTo(new Guid(0xE14D3571, 0x6B47, 0x4DEA, 0xB6, 0xA, 0x87, 0xCE, 0xA, 0x78, 0xDF, 0xB7)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_MetadataFormatChunkiTXt"/> property is correct.</summary>
    [Test]
    public static void GUID_MetadataFormatChunkiTXtTest()
    {
        Assert.That(GUID_MetadataFormatChunkiTXt, Is.EqualTo(new Guid(0xC2BEC729, 0xB68, 0x4B77, 0xAA, 0xE, 0x62, 0x95, 0xA6, 0xAC, 0x18, 0x14)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_MetadataFormatChunkcHRM"/> property is correct.</summary>
    [Test]
    public static void GUID_MetadataFormatChunkcHRMTest()
    {
        Assert.That(GUID_MetadataFormatChunkcHRM, Is.EqualTo(new Guid(0x9DB3655B, 0x2842, 0x44B3, 0x80, 0x67, 0x12, 0xE9, 0xB3, 0x75, 0x55, 0x6A)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_MetadataFormatChunkhIST"/> property is correct.</summary>
    [Test]
    public static void GUID_MetadataFormatChunkhISTTest()
    {
        Assert.That(GUID_MetadataFormatChunkhIST, Is.EqualTo(new Guid(0xC59A82DA, 0xDB74, 0x48A4, 0xBD, 0x6A, 0xB6, 0x9C, 0x49, 0x31, 0xEF, 0x95)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_MetadataFormatChunkiCCP"/> property is correct.</summary>
    [Test]
    public static void GUID_MetadataFormatChunkiCCPTest()
    {
        Assert.That(GUID_MetadataFormatChunkiCCP, Is.EqualTo(new Guid(0xEB4349AB, 0xB685, 0x450F, 0x91, 0xB5, 0xE8, 0x2, 0xE8, 0x92, 0x53, 0x6C)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_MetadataFormatChunksRGB"/> property is correct.</summary>
    [Test]
    public static void GUID_MetadataFormatChunksRGBTest()
    {
        Assert.That(GUID_MetadataFormatChunksRGB, Is.EqualTo(new Guid(0xC115FD36, 0xCC6F, 0x4E3F, 0x83, 0x63, 0x52, 0x4B, 0x87, 0xC6, 0xB0, 0xD9)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_MetadataFormatChunktIME"/> property is correct.</summary>
    [Test]
    public static void GUID_MetadataFormatChunktIMETest()
    {
        Assert.That(GUID_MetadataFormatChunktIME, Is.EqualTo(new Guid(0x6B00AE2D, 0xE24B, 0x460A, 0x98, 0xB6, 0x87, 0x8B, 0xD0, 0x30, 0x72, 0xFD)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_MetadataFormatDds"/> property is correct.</summary>
    [Test]
    public static void GUID_MetadataFormatDdsTest()
    {
        Assert.That(GUID_MetadataFormatDds, Is.EqualTo(new Guid(0x4a064603, 0x8c33, 0x4e60, 0x9c, 0x29, 0x13, 0x62, 0x31, 0x70, 0x2d, 0x08)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_MetadataFormatHeif"/> property is correct.</summary>
    [Test]
    public static void GUID_MetadataFormatHeifTest()
    {
        Assert.That(GUID_MetadataFormatHeif, Is.EqualTo(new Guid(0x817EF3E1, 0x1288, 0x45F4, 0xA8, 0x52, 0x26, 0x0D, 0x9E, 0x7C, 0xCE, 0x83)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_MetadataFormatHeifHDR"/> property is correct.</summary>
    [Test]
    public static void GUID_MetadataFormatHeifHDRTest()
    {
        Assert.That(GUID_MetadataFormatHeifHDR, Is.EqualTo(new Guid(0x568b8d8a, 0x1e65, 0x438c, 0x89, 0x68, 0xd6, 0xe, 0x10, 0x12, 0xbe, 0xb9)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_MetadataFormatWebpANIM"/> property is correct.</summary>
    [Test]
    public static void GUID_MetadataFormatWebpANIMTest()
    {
        Assert.That(GUID_MetadataFormatWebpANIM, Is.EqualTo(new Guid(0x6dc4fda6, 0x78e6, 0x4102, 0xae, 0x35, 0xbc, 0xfa, 0x1e, 0xdc, 0xc7, 0x8b)));
    }

    /// <summary>Validates that the value of the <see cref = "GUID_MetadataFormatWebpANMF"/> property is correct.</summary>
    [Test]
    public static void GUID_MetadataFormatWebpANMFTest()
    {
        Assert.That(GUID_MetadataFormatWebpANMF, Is.EqualTo(new Guid(0x43c105ee, 0xb93b, 0x4abb, 0xb0, 0x3, 0xa0, 0x8c, 0xd, 0x87, 0x4, 0x71)));
    }
}