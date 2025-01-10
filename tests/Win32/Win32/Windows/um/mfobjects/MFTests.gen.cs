// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using NUnit.Framework;
using static Silk.NET.Windows.MF;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "MF"/> class.</summary>
public static partial class MFTests
{
    /// <summary>Validates that the value of the <see cref = "MF_BYTESTREAM_ORIGIN_NAME"/> property is correct.</summary>

    [Test]
    public static void MF_BYTESTREAM_ORIGIN_NAMETest()
    {
        Assert.That(
            MF_BYTESTREAM_ORIGIN_NAME,
            Is.EqualTo(
                new Guid(0xfc358288, 0x3cb6, 0x460c, 0xa4, 0x24, 0xb6, 0x68, 0x12, 0x60, 0x37, 0x5a)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MF_BYTESTREAM_CONTENT_TYPE"/> property is correct.</summary>

    [Test]
    public static void MF_BYTESTREAM_CONTENT_TYPETest()
    {
        Assert.That(
            MF_BYTESTREAM_CONTENT_TYPE,
            Is.EqualTo(
                new Guid(0xfc358289, 0x3cb6, 0x460c, 0xa4, 0x24, 0xb6, 0x68, 0x12, 0x60, 0x37, 0x5a)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MF_BYTESTREAM_DURATION"/> property is correct.</summary>

    [Test]
    public static void MF_BYTESTREAM_DURATIONTest()
    {
        Assert.That(
            MF_BYTESTREAM_DURATION,
            Is.EqualTo(
                new Guid(0xfc35828a, 0x3cb6, 0x460c, 0xa4, 0x24, 0xb6, 0x68, 0x12, 0x60, 0x37, 0x5a)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MF_BYTESTREAM_LAST_MODIFIED_TIME"/> property is correct.</summary>

    [Test]
    public static void MF_BYTESTREAM_LAST_MODIFIED_TIMETest()
    {
        Assert.That(
            MF_BYTESTREAM_LAST_MODIFIED_TIME,
            Is.EqualTo(
                new Guid(0xfc35828b, 0x3cb6, 0x460c, 0xa4, 0x24, 0xb6, 0x68, 0x12, 0x60, 0x37, 0x5a)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MF_BYTESTREAM_IFO_FILE_URI"/> property is correct.</summary>

    [Test]
    public static void MF_BYTESTREAM_IFO_FILE_URITest()
    {
        Assert.That(
            MF_BYTESTREAM_IFO_FILE_URI,
            Is.EqualTo(
                new Guid(0xfc35828c, 0x3cb6, 0x460c, 0xa4, 0x24, 0xb6, 0x68, 0x12, 0x60, 0x37, 0x5a)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MF_BYTESTREAM_DLNA_PROFILE_ID"/> property is correct.</summary>

    [Test]
    public static void MF_BYTESTREAM_DLNA_PROFILE_IDTest()
    {
        Assert.That(
            MF_BYTESTREAM_DLNA_PROFILE_ID,
            Is.EqualTo(
                new Guid(0xfc35828d, 0x3cb6, 0x460c, 0xa4, 0x24, 0xb6, 0x68, 0x12, 0x60, 0x37, 0x5a)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MF_BYTESTREAM_EFFECTIVE_URL"/> property is correct.</summary>

    [Test]
    public static void MF_BYTESTREAM_EFFECTIVE_URLTest()
    {
        Assert.That(
            MF_BYTESTREAM_EFFECTIVE_URL,
            Is.EqualTo(
                new Guid(0x9afa0209, 0x89d1, 0x42af, 0x84, 0x56, 0x1d, 0xe6, 0xb5, 0x62, 0xd6, 0x91)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "MF_BYTESTREAM_TRANSCODED"/> property is correct.</summary>

    [Test]
    public static void MF_BYTESTREAM_TRANSCODEDTest()
    {
        Assert.That(
            MF_BYTESTREAM_TRANSCODED,
            Is.EqualTo(
                new Guid(0xb6c5c282, 0x4dc9, 0x4db9, 0xab, 0x48, 0xcf, 0x3b, 0x6d, 0x8b, 0xc5, 0xe0)
            )
        );
    }
}
