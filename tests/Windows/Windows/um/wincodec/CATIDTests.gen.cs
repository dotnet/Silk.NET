// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using static Silk.NET.Windows.CATID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "CATID"/> class.</summary>
public static partial class CATIDTests
{
    /// <summary>Validates that the value of the <see cref = "CATID_WICBitmapDecoders"/> property is correct.</summary>
    [Test]
    public static void CATID_WICBitmapDecodersTest()
    {
        Assert.That(CATID_WICBitmapDecoders, Is.EqualTo(new Guid(0x7ed96837, 0x96f0, 0x4812, 0xb2, 0x11, 0xf1, 0x3c, 0x24, 0x11, 0x7e, 0xd3)));
    }

    /// <summary>Validates that the value of the <see cref = "CATID_WICBitmapEncoders"/> property is correct.</summary>
    [Test]
    public static void CATID_WICBitmapEncodersTest()
    {
        Assert.That(CATID_WICBitmapEncoders, Is.EqualTo(new Guid(0xac757296, 0x3522, 0x4e11, 0x98, 0x62, 0xc1, 0x7b, 0xe5, 0xa1, 0x76, 0x7e)));
    }

    /// <summary>Validates that the value of the <see cref = "CATID_WICPixelFormats"/> property is correct.</summary>
    [Test]
    public static void CATID_WICPixelFormatsTest()
    {
        Assert.That(CATID_WICPixelFormats, Is.EqualTo(new Guid(0x2b46e70f, 0xcda7, 0x473e, 0x89, 0xf6, 0xdc, 0x96, 0x30, 0xa2, 0x39, 0x0b)));
    }

    /// <summary>Validates that the value of the <see cref = "CATID_WICFormatConverters"/> property is correct.</summary>
    [Test]
    public static void CATID_WICFormatConvertersTest()
    {
        Assert.That(CATID_WICFormatConverters, Is.EqualTo(new Guid(0x7835eae8, 0xbf14, 0x49d1, 0x93, 0xce, 0x53, 0x3a, 0x40, 0x7b, 0x22, 0x48)));
    }

    /// <summary>Validates that the value of the <see cref = "CATID_WICMetadataReader"/> property is correct.</summary>
    [Test]
    public static void CATID_WICMetadataReaderTest()
    {
        Assert.That(CATID_WICMetadataReader, Is.EqualTo(new Guid(0x05af94d8, 0x7174, 0x4cd2, 0xbe, 0x4a, 0x41, 0x24, 0xb8, 0x0e, 0xe4, 0xb8)));
    }

    /// <summary>Validates that the value of the <see cref = "CATID_WICMetadataWriter"/> property is correct.</summary>
    [Test]
    public static void CATID_WICMetadataWriterTest()
    {
        Assert.That(CATID_WICMetadataWriter, Is.EqualTo(new Guid(0xabe3b9a4, 0x257d, 0x4b97, 0xbd, 0x1a, 0x29, 0x4a, 0xf4, 0x96, 0x22, 0x2e)));
    }
}