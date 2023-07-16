// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using static Silk.NET.Windows.MFTranscodeContainerType;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "MFTranscodeContainerType"/> class.</summary>
public static partial class MFTranscodeContainerTypeTests
{
    /// <summary>Validates that the value of the <see cref = "MFTranscodeContainerType_ASF"/> property is correct.</summary>
    [Test]
    public static void MFTranscodeContainerType_ASFTest()
    {
        Assert.That(MFTranscodeContainerType_ASF, Is.EqualTo(new Guid(0x430f6f6e, 0xb6bf, 0x4fc1, 0xa0, 0xbd, 0x9e, 0xe4, 0x6e, 0xee, 0x2a, 0xfb)));
    }

    /// <summary>Validates that the value of the <see cref = "MFTranscodeContainerType_MPEG4"/> property is correct.</summary>
    [Test]
    public static void MFTranscodeContainerType_MPEG4Test()
    {
        Assert.That(MFTranscodeContainerType_MPEG4, Is.EqualTo(new Guid(0xdc6cd05d, 0xb9d0, 0x40ef, 0xbd, 0x35, 0xfa, 0x62, 0x2c, 0x1a, 0xb2, 0x8a)));
    }

    /// <summary>Validates that the value of the <see cref = "MFTranscodeContainerType_MP3"/> property is correct.</summary>
    [Test]
    public static void MFTranscodeContainerType_MP3Test()
    {
        Assert.That(MFTranscodeContainerType_MP3, Is.EqualTo(new Guid(0xe438b912, 0x83f1, 0x4de6, 0x9e, 0x3a, 0x9f, 0xfb, 0xc6, 0xdd, 0x24, 0xd1)));
    }

    /// <summary>Validates that the value of the <see cref = "MFTranscodeContainerType_FLAC"/> property is correct.</summary>
    [Test]
    public static void MFTranscodeContainerType_FLACTest()
    {
        Assert.That(MFTranscodeContainerType_FLAC, Is.EqualTo(new Guid(0x31344aa3, 0x05a9, 0x42b5, 0x90, 0x1b, 0x8e, 0x9d, 0x42, 0x57, 0xf7, 0x5e)));
    }

    /// <summary>Validates that the value of the <see cref = "MFTranscodeContainerType_3GP"/> property is correct.</summary>
    [Test]
    public static void MFTranscodeContainerType_3GPTest()
    {
        Assert.That(MFTranscodeContainerType_3GP, Is.EqualTo(new Guid(0x34c50167, 0x4472, 0x4f34, 0x9e, 0xa0, 0xc4, 0x9f, 0xba, 0xcf, 0x03, 0x7d)));
    }

    /// <summary>Validates that the value of the <see cref = "MFTranscodeContainerType_AC3"/> property is correct.</summary>
    [Test]
    public static void MFTranscodeContainerType_AC3Test()
    {
        Assert.That(MFTranscodeContainerType_AC3, Is.EqualTo(new Guid(0x6d8d91c3, 0x8c91, 0x4ed1, 0x87, 0x42, 0x8c, 0x34, 0x7d, 0x5b, 0x44, 0xd0)));
    }

    /// <summary>Validates that the value of the <see cref = "MFTranscodeContainerType_ADTS"/> property is correct.</summary>
    [Test]
    public static void MFTranscodeContainerType_ADTSTest()
    {
        Assert.That(MFTranscodeContainerType_ADTS, Is.EqualTo(new Guid(0x132fd27d, 0x0f02, 0x43de, 0xa3, 0x01, 0x38, 0xfb, 0xbb, 0xb3, 0x83, 0x4e)));
    }

    /// <summary>Validates that the value of the <see cref = "MFTranscodeContainerType_MPEG2"/> property is correct.</summary>
    [Test]
    public static void MFTranscodeContainerType_MPEG2Test()
    {
        Assert.That(MFTranscodeContainerType_MPEG2, Is.EqualTo(new Guid(0xbfc2dbf9, 0x7bb4, 0x4f8f, 0xaf, 0xde, 0xe1, 0x12, 0xc4, 0x4b, 0xa8, 0x82)));
    }

    /// <summary>Validates that the value of the <see cref = "MFTranscodeContainerType_WAVE"/> property is correct.</summary>
    [Test]
    public static void MFTranscodeContainerType_WAVETest()
    {
        Assert.That(MFTranscodeContainerType_WAVE, Is.EqualTo(new Guid(0x64c3453c, 0x0f26, 0x4741, 0xbe, 0x63, 0x87, 0xbd, 0xf8, 0xbb, 0x93, 0x5b)));
    }

    /// <summary>Validates that the value of the <see cref = "MFTranscodeContainerType_AVI"/> property is correct.</summary>
    [Test]
    public static void MFTranscodeContainerType_AVITest()
    {
        Assert.That(MFTranscodeContainerType_AVI, Is.EqualTo(new Guid(0x7edfe8af, 0x402f, 0x4d76, 0xa3, 0x3c, 0x61, 0x9f, 0xd1, 0x57, 0xd0, 0xf1)));
    }

    /// <summary>Validates that the value of the <see cref = "MFTranscodeContainerType_FMPEG4"/> property is correct.</summary>
    [Test]
    public static void MFTranscodeContainerType_FMPEG4Test()
    {
        Assert.That(MFTranscodeContainerType_FMPEG4, Is.EqualTo(new Guid(0x9ba876f1, 0x419f, 0x4b77, 0xa1, 0xe0, 0x35, 0x95, 0x9d, 0x9d, 0x40, 0x4)));
    }

    /// <summary>Validates that the value of the <see cref = "MFTranscodeContainerType_AMR"/> property is correct.</summary>
    [Test]
    public static void MFTranscodeContainerType_AMRTest()
    {
        Assert.That(MFTranscodeContainerType_AMR, Is.EqualTo(new Guid(0x25d5ad3, 0x621a, 0x475b, 0x96, 0x4d, 0x66, 0xb1, 0xc8, 0x24, 0xf0, 0x79)));
    }
}