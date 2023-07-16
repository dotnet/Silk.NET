// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodecsdk.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using static Silk.NET.Windows.CLSID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "CLSID"/> class.</summary>
public static partial class CLSIDTests
{
    /// <summary>Validates that the value of the <see cref = "CLSID_WICUnknownMetadataReader"/> property is correct.</summary>
    [Test]
    public static void CLSID_WICUnknownMetadataReaderTest()
    {
        Assert.That(CLSID_WICUnknownMetadataReader, Is.EqualTo(new Guid(0x699745c2, 0x5066, 0x4b82, 0xa8, 0xe3, 0xd4, 0x4, 0x78, 0xdb, 0xec, 0x8c)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICUnknownMetadataWriter"/> property is correct.</summary>
    [Test]
    public static void CLSID_WICUnknownMetadataWriterTest()
    {
        Assert.That(CLSID_WICUnknownMetadataWriter, Is.EqualTo(new Guid(0xa09cca86, 0x27ba, 0x4f39, 0x90, 0x53, 0x12, 0x1f, 0xa4, 0xdc, 0x8, 0xfc)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICApp0MetadataWriter"/> property is correct.</summary>
    [Test]
    public static void CLSID_WICApp0MetadataWriterTest()
    {
        Assert.That(CLSID_WICApp0MetadataWriter, Is.EqualTo(new Guid(0xF3C633A2, 0x46C8, 0x498e, 0x8F, 0xBB, 0xCC, 0x6F, 0x72, 0x1B, 0xBC, 0xDE)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICApp0MetadataReader"/> property is correct.</summary>
    [Test]
    public static void CLSID_WICApp0MetadataReaderTest()
    {
        Assert.That(CLSID_WICApp0MetadataReader, Is.EqualTo(new Guid(0x43324B33, 0xA78F, 0x480f, 0x91, 0x11, 0x96, 0x38, 0xAA, 0xCC, 0xC8, 0x32)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICApp1MetadataWriter"/> property is correct.</summary>
    [Test]
    public static void CLSID_WICApp1MetadataWriterTest()
    {
        Assert.That(CLSID_WICApp1MetadataWriter, Is.EqualTo(new Guid(0xee366069, 0x1832, 0x420f, 0xb3, 0x81, 0x04, 0x79, 0xad, 0x06, 0x6f, 0x19)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICApp1MetadataReader"/> property is correct.</summary>
    [Test]
    public static void CLSID_WICApp1MetadataReaderTest()
    {
        Assert.That(CLSID_WICApp1MetadataReader, Is.EqualTo(new Guid(0xdde33513, 0x774e, 0x4bcd, 0xae, 0x79, 0x02, 0xf4, 0xad, 0xfe, 0x62, 0xfc)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICApp13MetadataWriter"/> property is correct.</summary>
    [Test]
    public static void CLSID_WICApp13MetadataWriterTest()
    {
        Assert.That(CLSID_WICApp13MetadataWriter, Is.EqualTo(new Guid(0x7B19A919, 0xA9D6, 0x49E5, 0xBD, 0x45, 0x02, 0xC3, 0x4E, 0x4E, 0x4C, 0xD5)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICApp13MetadataReader"/> property is correct.</summary>
    [Test]
    public static void CLSID_WICApp13MetadataReaderTest()
    {
        Assert.That(CLSID_WICApp13MetadataReader, Is.EqualTo(new Guid(0xAA7E3C50, 0x864C, 0x4604, 0xBC, 0x04, 0x8B, 0x0B, 0x76, 0xE6, 0x37, 0xF6)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICIfdMetadataReader"/> property is correct.</summary>
    [Test]
    public static void CLSID_WICIfdMetadataReaderTest()
    {
        Assert.That(CLSID_WICIfdMetadataReader, Is.EqualTo(new Guid(0x8f914656, 0x9d0a, 0x4eb2, 0x90, 0x19, 0xb, 0xf9, 0x6d, 0x8a, 0x9e, 0xe6)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICIfdMetadataWriter"/> property is correct.</summary>
    [Test]
    public static void CLSID_WICIfdMetadataWriterTest()
    {
        Assert.That(CLSID_WICIfdMetadataWriter, Is.EqualTo(new Guid(0xb1ebfc28, 0xc9bd, 0x47a2, 0x8d, 0x33, 0xb9, 0x48, 0x76, 0x97, 0x77, 0xa7)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICSubIfdMetadataReader"/> property is correct.</summary>
    [Test]
    public static void CLSID_WICSubIfdMetadataReaderTest()
    {
        Assert.That(CLSID_WICSubIfdMetadataReader, Is.EqualTo(new Guid(0x50D42F09, 0xECD1, 0x4B41, 0xB6, 0x5D, 0xDA, 0x1F, 0xDA, 0xA7, 0x56, 0x63)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICSubIfdMetadataWriter"/> property is correct.</summary>
    [Test]
    public static void CLSID_WICSubIfdMetadataWriterTest()
    {
        Assert.That(CLSID_WICSubIfdMetadataWriter, Is.EqualTo(new Guid(0x8ADE5386, 0x8E9B, 0x4F4C, 0xAC, 0xF2, 0xF0, 0x00, 0x87, 0x06, 0xB2, 0x38)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICExifMetadataReader"/> property is correct.</summary>
    [Test]
    public static void CLSID_WICExifMetadataReaderTest()
    {
        Assert.That(CLSID_WICExifMetadataReader, Is.EqualTo(new Guid(0xd9403860, 0x297f, 0x4a49, 0xbf, 0x9b, 0x77, 0x89, 0x81, 0x50, 0xa4, 0x42)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICExifMetadataWriter"/> property is correct.</summary>
    [Test]
    public static void CLSID_WICExifMetadataWriterTest()
    {
        Assert.That(CLSID_WICExifMetadataWriter, Is.EqualTo(new Guid(0xc9a14cda, 0xc339, 0x460b, 0x90, 0x78, 0xd4, 0xde, 0xbc, 0xfa, 0xbe, 0x91)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICGpsMetadataReader"/> property is correct.</summary>
    [Test]
    public static void CLSID_WICGpsMetadataReaderTest()
    {
        Assert.That(CLSID_WICGpsMetadataReader, Is.EqualTo(new Guid(0x3697790B, 0x223B, 0x484E, 0x99, 0x25, 0xC4, 0x86, 0x92, 0x18, 0xF1, 0x7A)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICGpsMetadataWriter"/> property is correct.</summary>
    [Test]
    public static void CLSID_WICGpsMetadataWriterTest()
    {
        Assert.That(CLSID_WICGpsMetadataWriter, Is.EqualTo(new Guid(0xCB8C13E4, 0x62B5, 0x4C96, 0xA4, 0x8B, 0x6B, 0xA6, 0xAC, 0xE3, 0x9C, 0x76)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICInteropMetadataReader"/> property is correct.</summary>
    [Test]
    public static void CLSID_WICInteropMetadataReaderTest()
    {
        Assert.That(CLSID_WICInteropMetadataReader, Is.EqualTo(new Guid(0xB5C8B898, 0x0074, 0x459F, 0xB7, 0x00, 0x86, 0x0D, 0x46, 0x51, 0xEA, 0x14)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICInteropMetadataWriter"/> property is correct.</summary>
    [Test]
    public static void CLSID_WICInteropMetadataWriterTest()
    {
        Assert.That(CLSID_WICInteropMetadataWriter, Is.EqualTo(new Guid(0x122EC645, 0xCD7E, 0x44D8, 0xB1, 0x86, 0x2C, 0x8C, 0x20, 0xC3, 0xB5, 0x0F)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICThumbnailMetadataReader"/> property is correct.</summary>
    [Test]
    public static void CLSID_WICThumbnailMetadataReaderTest()
    {
        Assert.That(CLSID_WICThumbnailMetadataReader, Is.EqualTo(new Guid(0xfb012959, 0xf4f6, 0x44d7, 0x9d, 0x9, 0xda, 0xa0, 0x87, 0xa9, 0xdb, 0x57)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICThumbnailMetadataWriter"/> property is correct.</summary>
    [Test]
    public static void CLSID_WICThumbnailMetadataWriterTest()
    {
        Assert.That(CLSID_WICThumbnailMetadataWriter, Is.EqualTo(new Guid(0xd049b20c, 0x5dd0, 0x44fe, 0xb0, 0xb3, 0x8f, 0x92, 0xc8, 0xe6, 0xd0, 0x80)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICIPTCMetadataReader"/> property is correct.</summary>
    [Test]
    public static void CLSID_WICIPTCMetadataReaderTest()
    {
        Assert.That(CLSID_WICIPTCMetadataReader, Is.EqualTo(new Guid(0x03012959, 0xf4f6, 0x44d7, 0x9d, 0x9, 0xda, 0xa0, 0x87, 0xa9, 0xdb, 0x57)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICIPTCMetadataWriter"/> property is correct.</summary>
    [Test]
    public static void CLSID_WICIPTCMetadataWriterTest()
    {
        Assert.That(CLSID_WICIPTCMetadataWriter, Is.EqualTo(new Guid(0x1249b20c, 0x5dd0, 0x44fe, 0xb0, 0xb3, 0x8f, 0x92, 0xc8, 0xe6, 0xd0, 0x80)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICIRBMetadataReader"/> property is correct.</summary>
    [Test]
    public static void CLSID_WICIRBMetadataReaderTest()
    {
        Assert.That(CLSID_WICIRBMetadataReader, Is.EqualTo(new Guid(0xD4DCD3D7, 0xB4C2, 0x47D9, 0xA6, 0xBF, 0xB8, 0x9B, 0xA3, 0x96, 0xA4, 0xA3)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICIRBMetadataWriter"/> property is correct.</summary>
    [Test]
    public static void CLSID_WICIRBMetadataWriterTest()
    {
        Assert.That(CLSID_WICIRBMetadataWriter, Is.EqualTo(new Guid(0x5C5C1935, 0x0235, 0x4434, 0x80, 0xBC, 0x25, 0x1B, 0xC1, 0xEC, 0x39, 0xC6)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WIC8BIMIPTCMetadataReader"/> property is correct.</summary>
    [Test]
    public static void CLSID_WIC8BIMIPTCMetadataReaderTest()
    {
        Assert.That(CLSID_WIC8BIMIPTCMetadataReader, Is.EqualTo(new Guid(0x0010668c, 0x0801, 0x4da6, 0xa4, 0xa4, 0x82, 0x65, 0x22, 0xb6, 0xd2, 0x8f)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WIC8BIMIPTCMetadataWriter"/> property is correct.</summary>
    [Test]
    public static void CLSID_WIC8BIMIPTCMetadataWriterTest()
    {
        Assert.That(CLSID_WIC8BIMIPTCMetadataWriter, Is.EqualTo(new Guid(0x00108226, 0xee41, 0x44a2, 0x9e, 0x9c, 0x4b, 0xe4, 0xd5, 0xb1, 0xd2, 0xcd)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WIC8BIMResolutionInfoMetadataReader"/> property is correct.</summary>
    [Test]
    public static void CLSID_WIC8BIMResolutionInfoMetadataReaderTest()
    {
        Assert.That(CLSID_WIC8BIMResolutionInfoMetadataReader, Is.EqualTo(new Guid(0x5805137A, 0xE348, 0x4F7C, 0xB3, 0xCC, 0x6D, 0xB9, 0x96, 0x5A, 0x05, 0x99)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WIC8BIMResolutionInfoMetadataWriter"/> property is correct.</summary>
    [Test]
    public static void CLSID_WIC8BIMResolutionInfoMetadataWriterTest()
    {
        Assert.That(CLSID_WIC8BIMResolutionInfoMetadataWriter, Is.EqualTo(new Guid(0x4ff2fe0e, 0xe74a, 0x4b71, 0x98, 0xc4, 0xab, 0x7d, 0xc1, 0x67, 0x7, 0xba)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WIC8BIMIPTCDigestMetadataReader"/> property is correct.</summary>
    [Test]
    public static void CLSID_WIC8BIMIPTCDigestMetadataReaderTest()
    {
        Assert.That(CLSID_WIC8BIMIPTCDigestMetadataReader, Is.EqualTo(new Guid(0x02805F1E, 0xD5AA, 0x415b, 0x82, 0xC5, 0x61, 0xC0, 0x33, 0xA9, 0x88, 0xA6)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WIC8BIMIPTCDigestMetadataWriter"/> property is correct.</summary>
    [Test]
    public static void CLSID_WIC8BIMIPTCDigestMetadataWriterTest()
    {
        Assert.That(CLSID_WIC8BIMIPTCDigestMetadataWriter, Is.EqualTo(new Guid(0x2DB5E62B, 0x0D67, 0x495f, 0x8F, 0x9D, 0xC2, 0xF0, 0x18, 0x86, 0x47, 0xAC)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICPngTextMetadataReader"/> property is correct.</summary>
    [Test]
    public static void CLSID_WICPngTextMetadataReaderTest()
    {
        Assert.That(CLSID_WICPngTextMetadataReader, Is.EqualTo(new Guid(0x4b59afcc, 0xb8c3, 0x408a, 0xb6, 0x70, 0x89, 0xe5, 0xfa, 0xb6, 0xfd, 0xa7)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICPngTextMetadataWriter"/> property is correct.</summary>
    [Test]
    public static void CLSID_WICPngTextMetadataWriterTest()
    {
        Assert.That(CLSID_WICPngTextMetadataWriter, Is.EqualTo(new Guid(0xb5ebafb9, 0x253e, 0x4a72, 0xa7, 0x44, 0x7, 0x62, 0xd2, 0x68, 0x56, 0x83)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICXMPMetadataReader"/> property is correct.</summary>
    [Test]
    public static void CLSID_WICXMPMetadataReaderTest()
    {
        Assert.That(CLSID_WICXMPMetadataReader, Is.EqualTo(new Guid(0x72B624DF, 0xAE11, 0x4948, 0xA6, 0x5C, 0x35, 0x1E, 0xB0, 0x82, 0x94, 0x19)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICXMPMetadataWriter"/> property is correct.</summary>
    [Test]
    public static void CLSID_WICXMPMetadataWriterTest()
    {
        Assert.That(CLSID_WICXMPMetadataWriter, Is.EqualTo(new Guid(0x1765E14E, 0x1BD4, 0x462E, 0xB6, 0xB1, 0x59, 0x0B, 0xF1, 0x26, 0x2A, 0xC6)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICXMPStructMetadataReader"/> property is correct.</summary>
    [Test]
    public static void CLSID_WICXMPStructMetadataReaderTest()
    {
        Assert.That(CLSID_WICXMPStructMetadataReader, Is.EqualTo(new Guid(0x01B90D9A, 0x8209, 0x47F7, 0x9C, 0x52, 0xE1, 0x24, 0x4B, 0xF5, 0x0C, 0xED)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICXMPStructMetadataWriter"/> property is correct.</summary>
    [Test]
    public static void CLSID_WICXMPStructMetadataWriterTest()
    {
        Assert.That(CLSID_WICXMPStructMetadataWriter, Is.EqualTo(new Guid(0x22C21F93, 0x7DDB, 0x411C, 0x9B, 0x17, 0xC5, 0xB7, 0xBD, 0x06, 0x4A, 0xBC)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICXMPBagMetadataReader"/> property is correct.</summary>
    [Test]
    public static void CLSID_WICXMPBagMetadataReaderTest()
    {
        Assert.That(CLSID_WICXMPBagMetadataReader, Is.EqualTo(new Guid(0xE7E79A30, 0x4F2C, 0x4FAB, 0x8D, 0x00, 0x39, 0x4F, 0x2D, 0x6B, 0xBE, 0xBE)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICXMPBagMetadataWriter"/> property is correct.</summary>
    [Test]
    public static void CLSID_WICXMPBagMetadataWriterTest()
    {
        Assert.That(CLSID_WICXMPBagMetadataWriter, Is.EqualTo(new Guid(0xED822C8C, 0xD6BE, 0x4301, 0xA6, 0x31, 0x0E, 0x14, 0x16, 0xBA, 0xD2, 0x8F)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICXMPSeqMetadataReader"/> property is correct.</summary>
    [Test]
    public static void CLSID_WICXMPSeqMetadataReaderTest()
    {
        Assert.That(CLSID_WICXMPSeqMetadataReader, Is.EqualTo(new Guid(0x7F12E753, 0xFC71, 0x43D7, 0xA5, 0x1D, 0x92, 0xF3, 0x59, 0x77, 0xAB, 0xB5)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICXMPSeqMetadataWriter"/> property is correct.</summary>
    [Test]
    public static void CLSID_WICXMPSeqMetadataWriterTest()
    {
        Assert.That(CLSID_WICXMPSeqMetadataWriter, Is.EqualTo(new Guid(0x6D68D1DE, 0xD432, 0x4B0F, 0x92, 0x3A, 0x09, 0x11, 0x83, 0xA9, 0xBD, 0xA7)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICXMPAltMetadataReader"/> property is correct.</summary>
    [Test]
    public static void CLSID_WICXMPAltMetadataReaderTest()
    {
        Assert.That(CLSID_WICXMPAltMetadataReader, Is.EqualTo(new Guid(0xAA94DCC2, 0xB8B0, 0x4898, 0xB8, 0x35, 0x00, 0x0A, 0xAB, 0xD7, 0x43, 0x93)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICXMPAltMetadataWriter"/> property is correct.</summary>
    [Test]
    public static void CLSID_WICXMPAltMetadataWriterTest()
    {
        Assert.That(CLSID_WICXMPAltMetadataWriter, Is.EqualTo(new Guid(0x076C2A6C, 0xF78F, 0x4C46, 0xA7, 0x23, 0x35, 0x83, 0xE7, 0x08, 0x76, 0xEA)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICLSDMetadataReader"/> property is correct.</summary>
    [Test]
    public static void CLSID_WICLSDMetadataReaderTest()
    {
        Assert.That(CLSID_WICLSDMetadataReader, Is.EqualTo(new Guid(0x41070793, 0x59E4, 0x479A, 0xA1, 0xF7, 0x95, 0x4A, 0xDC, 0x2E, 0xF5, 0xFC)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICLSDMetadataWriter"/> property is correct.</summary>
    [Test]
    public static void CLSID_WICLSDMetadataWriterTest()
    {
        Assert.That(CLSID_WICLSDMetadataWriter, Is.EqualTo(new Guid(0x73C037E7, 0xE5D9, 0x4954, 0x87, 0x6A, 0x6D, 0xA8, 0x1D, 0x6E, 0x57, 0x68)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICGCEMetadataReader"/> property is correct.</summary>
    [Test]
    public static void CLSID_WICGCEMetadataReaderTest()
    {
        Assert.That(CLSID_WICGCEMetadataReader, Is.EqualTo(new Guid(0xB92E345D, 0xF52D, 0x41F3, 0xB5, 0x62, 0x8, 0x1B, 0xC7, 0x72, 0xE3, 0xB9)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICGCEMetadataWriter"/> property is correct.</summary>
    [Test]
    public static void CLSID_WICGCEMetadataWriterTest()
    {
        Assert.That(CLSID_WICGCEMetadataWriter, Is.EqualTo(new Guid(0xAF95DC76, 0x16B2, 0x47F4, 0xB3, 0xEA, 0x3C, 0x31, 0x79, 0x66, 0x93, 0xE7)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICIMDMetadataReader"/> property is correct.</summary>
    [Test]
    public static void CLSID_WICIMDMetadataReaderTest()
    {
        Assert.That(CLSID_WICIMDMetadataReader, Is.EqualTo(new Guid(0x7447A267, 0x15, 0x42C8, 0xA8, 0xF1, 0xFB, 0x3B, 0x94, 0xC6, 0x83, 0x61)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICIMDMetadataWriter"/> property is correct.</summary>
    [Test]
    public static void CLSID_WICIMDMetadataWriterTest()
    {
        Assert.That(CLSID_WICIMDMetadataWriter, Is.EqualTo(new Guid(0x8C89071F, 0x452E, 0x4E95, 0x96, 0x82, 0x9D, 0x10, 0x24, 0x62, 0x71, 0x72)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICAPEMetadataReader"/> property is correct.</summary>
    [Test]
    public static void CLSID_WICAPEMetadataReaderTest()
    {
        Assert.That(CLSID_WICAPEMetadataReader, Is.EqualTo(new Guid(0x1767B93A, 0xB021, 0x44EA, 0x92, 0xF, 0x86, 0x3C, 0x11, 0xF4, 0xF7, 0x68)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICAPEMetadataWriter"/> property is correct.</summary>
    [Test]
    public static void CLSID_WICAPEMetadataWriterTest()
    {
        Assert.That(CLSID_WICAPEMetadataWriter, Is.EqualTo(new Guid(0xBD6EDFCA, 0x2890, 0x482F, 0xB2, 0x33, 0x8D, 0x73, 0x39, 0xA1, 0xCF, 0x8D)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICJpegChrominanceMetadataReader"/> property is correct.</summary>
    [Test]
    public static void CLSID_WICJpegChrominanceMetadataReaderTest()
    {
        Assert.That(CLSID_WICJpegChrominanceMetadataReader, Is.EqualTo(new Guid(0x50B1904B, 0xF28F, 0x4574, 0x93, 0xF4, 0x0B, 0xAD, 0xE8, 0x2C, 0x69, 0xE9)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICJpegChrominanceMetadataWriter"/> property is correct.</summary>
    [Test]
    public static void CLSID_WICJpegChrominanceMetadataWriterTest()
    {
        Assert.That(CLSID_WICJpegChrominanceMetadataWriter, Is.EqualTo(new Guid(0x3FF566F0, 0x6E6B, 0x49D4, 0x96, 0xE6, 0xB7, 0x88, 0x86, 0x69, 0x2C, 0x62)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICJpegLuminanceMetadataReader"/> property is correct.</summary>
    [Test]
    public static void CLSID_WICJpegLuminanceMetadataReaderTest()
    {
        Assert.That(CLSID_WICJpegLuminanceMetadataReader, Is.EqualTo(new Guid(0x356F2F88, 0x5A6, 0x4728, 0xB9, 0xA4, 0x1B, 0xFB, 0xCE, 0x04, 0xD8, 0x38)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICJpegLuminanceMetadataWriter"/> property is correct.</summary>
    [Test]
    public static void CLSID_WICJpegLuminanceMetadataWriterTest()
    {
        Assert.That(CLSID_WICJpegLuminanceMetadataWriter, Is.EqualTo(new Guid(0x1D583ABC, 0x8A0E, 0x4657, 0x99, 0x82, 0xA3, 0x80, 0xCA, 0x58, 0xFB, 0x4B)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICJpegCommentMetadataReader"/> property is correct.</summary>
    [Test]
    public static void CLSID_WICJpegCommentMetadataReaderTest()
    {
        Assert.That(CLSID_WICJpegCommentMetadataReader, Is.EqualTo(new Guid(0x9f66347C, 0x60C4, 0x4C4D, 0xAB, 0x58, 0xD2, 0x35, 0x86, 0x85, 0xf6, 0x07)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICJpegCommentMetadataWriter"/> property is correct.</summary>
    [Test]
    public static void CLSID_WICJpegCommentMetadataWriterTest()
    {
        Assert.That(CLSID_WICJpegCommentMetadataWriter, Is.EqualTo(new Guid(0xE573236F, 0x55B1, 0x4EDA, 0x81, 0xEA, 0x9F, 0x65, 0xDB, 0x02, 0x90, 0xD3)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICGifCommentMetadataReader"/> property is correct.</summary>
    [Test]
    public static void CLSID_WICGifCommentMetadataReaderTest()
    {
        Assert.That(CLSID_WICGifCommentMetadataReader, Is.EqualTo(new Guid(0x32557D3B, 0x69DC, 0x4F95, 0x83, 0x6E, 0xF5, 0x97, 0x2B, 0x2F, 0x61, 0x59)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICGifCommentMetadataWriter"/> property is correct.</summary>
    [Test]
    public static void CLSID_WICGifCommentMetadataWriterTest()
    {
        Assert.That(CLSID_WICGifCommentMetadataWriter, Is.EqualTo(new Guid(0xA02797fC, 0xC4AE, 0x418C, 0xAF, 0x95, 0xE6, 0x37, 0xC7, 0xEA, 0xD2, 0xA1)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICPngGamaMetadataReader"/> property is correct.</summary>
    [Test]
    public static void CLSID_WICPngGamaMetadataReaderTest()
    {
        Assert.That(CLSID_WICPngGamaMetadataReader, Is.EqualTo(new Guid(0x3692CA39, 0xE082, 0x4350, 0x9E, 0x1F, 0x37, 0x4, 0xCB, 0x8, 0x3C, 0xD5)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICPngGamaMetadataWriter"/> property is correct.</summary>
    [Test]
    public static void CLSID_WICPngGamaMetadataWriterTest()
    {
        Assert.That(CLSID_WICPngGamaMetadataWriter, Is.EqualTo(new Guid(0xFF036D13, 0x5D4B, 0x46DD, 0xB1, 0xF, 0x10, 0x66, 0x93, 0xD9, 0xFE, 0x4F)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICPngBkgdMetadataReader"/> property is correct.</summary>
    [Test]
    public static void CLSID_WICPngBkgdMetadataReaderTest()
    {
        Assert.That(CLSID_WICPngBkgdMetadataReader, Is.EqualTo(new Guid(0xCE7A4A6, 0x3E8, 0x4A60, 0x9D, 0x15, 0x28, 0x2E, 0xF3, 0x2E, 0xE7, 0xDA)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICPngBkgdMetadataWriter"/> property is correct.</summary>
    [Test]
    public static void CLSID_WICPngBkgdMetadataWriterTest()
    {
        Assert.That(CLSID_WICPngBkgdMetadataWriter, Is.EqualTo(new Guid(0x68E3F2FD, 0x31AE, 0x4441, 0xBB, 0x6A, 0xFD, 0x70, 0x47, 0x52, 0x5F, 0x90)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICPngItxtMetadataReader"/> property is correct.</summary>
    [Test]
    public static void CLSID_WICPngItxtMetadataReaderTest()
    {
        Assert.That(CLSID_WICPngItxtMetadataReader, Is.EqualTo(new Guid(0xAABFB2FA, 0x3E1E, 0x4A8F, 0x89, 0x77, 0x55, 0x56, 0xFB, 0x94, 0xEA, 0x23)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICPngItxtMetadataWriter"/> property is correct.</summary>
    [Test]
    public static void CLSID_WICPngItxtMetadataWriterTest()
    {
        Assert.That(CLSID_WICPngItxtMetadataWriter, Is.EqualTo(new Guid(0x31879719, 0xE751, 0x4DF8, 0x98, 0x1D, 0x68, 0xDF, 0xF6, 0x77, 0x4, 0xED)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICPngChrmMetadataReader"/> property is correct.</summary>
    [Test]
    public static void CLSID_WICPngChrmMetadataReaderTest()
    {
        Assert.That(CLSID_WICPngChrmMetadataReader, Is.EqualTo(new Guid(0xF90B5F36, 0x367B, 0x402A, 0x9D, 0xD1, 0xBC, 0xF, 0xD5, 0x9D, 0x8F, 0x62)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICPngChrmMetadataWriter"/> property is correct.</summary>
    [Test]
    public static void CLSID_WICPngChrmMetadataWriterTest()
    {
        Assert.That(CLSID_WICPngChrmMetadataWriter, Is.EqualTo(new Guid(0xE23CE3EB, 0x5608, 0x4E83, 0xBC, 0xEF, 0x27, 0xB1, 0x98, 0x7E, 0x51, 0xD7)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICPngHistMetadataReader"/> property is correct.</summary>
    [Test]
    public static void CLSID_WICPngHistMetadataReaderTest()
    {
        Assert.That(CLSID_WICPngHistMetadataReader, Is.EqualTo(new Guid(0x877A0BB7, 0xA313, 0x4491, 0x87, 0xB5, 0x2E, 0x6D, 0x5, 0x94, 0xF5, 0x20)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICPngHistMetadataWriter"/> property is correct.</summary>
    [Test]
    public static void CLSID_WICPngHistMetadataWriterTest()
    {
        Assert.That(CLSID_WICPngHistMetadataWriter, Is.EqualTo(new Guid(0x8A03E749, 0x672E, 0x446E, 0xBF, 0x1F, 0x2C, 0x11, 0xD2, 0x33, 0xB6, 0xFF)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICPngIccpMetadataReader"/> property is correct.</summary>
    [Test]
    public static void CLSID_WICPngIccpMetadataReaderTest()
    {
        Assert.That(CLSID_WICPngIccpMetadataReader, Is.EqualTo(new Guid(0xF5D3E63B, 0xCB0F, 0x4628, 0xA4, 0x78, 0x6D, 0x82, 0x44, 0xBE, 0x36, 0xB1)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICPngIccpMetadataWriter"/> property is correct.</summary>
    [Test]
    public static void CLSID_WICPngIccpMetadataWriterTest()
    {
        Assert.That(CLSID_WICPngIccpMetadataWriter, Is.EqualTo(new Guid(0x16671E5F, 0xCE6, 0x4CC4, 0x97, 0x68, 0xE8, 0x9F, 0xE5, 0x1, 0x8A, 0xDE)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICPngSrgbMetadataReader"/> property is correct.</summary>
    [Test]
    public static void CLSID_WICPngSrgbMetadataReaderTest()
    {
        Assert.That(CLSID_WICPngSrgbMetadataReader, Is.EqualTo(new Guid(0xFB40360C, 0x547E, 0x4956, 0xA3, 0xB9, 0xD4, 0x41, 0x88, 0x59, 0xBA, 0x66)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICPngSrgbMetadataWriter"/> property is correct.</summary>
    [Test]
    public static void CLSID_WICPngSrgbMetadataWriterTest()
    {
        Assert.That(CLSID_WICPngSrgbMetadataWriter, Is.EqualTo(new Guid(0xA6EE35C6, 0x87EC, 0x47DF, 0x9F, 0x22, 0x1D, 0x5A, 0xAD, 0x84, 0xC, 0x82)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICPngTimeMetadataReader"/> property is correct.</summary>
    [Test]
    public static void CLSID_WICPngTimeMetadataReaderTest()
    {
        Assert.That(CLSID_WICPngTimeMetadataReader, Is.EqualTo(new Guid(0xD94EDF02, 0xEFE5, 0x4F0D, 0x85, 0xC8, 0xF5, 0xA6, 0x8B, 0x30, 0x0, 0xB1)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICPngTimeMetadataWriter"/> property is correct.</summary>
    [Test]
    public static void CLSID_WICPngTimeMetadataWriterTest()
    {
        Assert.That(CLSID_WICPngTimeMetadataWriter, Is.EqualTo(new Guid(0x1AB78400, 0xB5A3, 0x4D91, 0x8A, 0xCE, 0x33, 0xFC, 0xD1, 0x49, 0x9B, 0xE6)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICDdsMetadataReader"/> property is correct.</summary>
    [Test]
    public static void CLSID_WICDdsMetadataReaderTest()
    {
        Assert.That(CLSID_WICDdsMetadataReader, Is.EqualTo(new Guid(0x276c88ca, 0x7533, 0x4a86, 0xb6, 0x76, 0x66, 0xb3, 0x60, 0x80, 0xd4, 0x84)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICDdsMetadataWriter"/> property is correct.</summary>
    [Test]
    public static void CLSID_WICDdsMetadataWriterTest()
    {
        Assert.That(CLSID_WICDdsMetadataWriter, Is.EqualTo(new Guid(0xfd688bbd, 0x31ed, 0x4db7, 0xa7, 0x23, 0x93, 0x49, 0x27, 0xd3, 0x83, 0x67)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICHeifMetadataReader"/> property is correct.</summary>
    [Test]
    public static void CLSID_WICHeifMetadataReaderTest()
    {
        Assert.That(CLSID_WICHeifMetadataReader, Is.EqualTo(new Guid(0xACDDFC3F, 0x85EC, 0x41BC, 0xBD, 0xEF, 0x1B, 0xC2, 0x62, 0xE4, 0xDB, 0x05)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICHeifMetadataWriter"/> property is correct.</summary>
    [Test]
    public static void CLSID_WICHeifMetadataWriterTest()
    {
        Assert.That(CLSID_WICHeifMetadataWriter, Is.EqualTo(new Guid(0x3AE45E79, 0x40BC, 0x4401, 0xAC, 0xE5, 0xDD, 0x3C, 0xB1, 0x6E, 0x6A, 0xFE)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICHeifHDRMetadataReader"/> property is correct.</summary>
    [Test]
    public static void CLSID_WICHeifHDRMetadataReaderTest()
    {
        Assert.That(CLSID_WICHeifHDRMetadataReader, Is.EqualTo(new Guid(0x2438de3d, 0x94d9, 0x4be8, 0x84, 0xa8, 0x4d, 0xe9, 0x5a, 0x57, 0x5e, 0x75)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICWebpAnimMetadataReader"/> property is correct.</summary>
    [Test]
    public static void CLSID_WICWebpAnimMetadataReaderTest()
    {
        Assert.That(CLSID_WICWebpAnimMetadataReader, Is.EqualTo(new Guid(0x76f9911, 0xa348, 0x465c, 0xa8, 0x7, 0xa2, 0x52, 0xf3, 0xf2, 0xd3, 0xde)));
    }

    /// <summary>Validates that the value of the <see cref = "CLSID_WICWebpAnmfMetadataReader"/> property is correct.</summary>
    [Test]
    public static void CLSID_WICWebpAnmfMetadataReaderTest()
    {
        Assert.That(CLSID_WICWebpAnmfMetadataReader, Is.EqualTo(new Guid(0x85a10b03, 0xc9f6, 0x439f, 0xbe, 0x5e, 0xc0, 0xfb, 0xef, 0x67, 0x80, 0x7c)));
    }
}