// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using NUnit.Framework;
using static Silk.NET.Windows.TF;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "TF"/> class.</summary>
public static unsafe partial class TFTests
{
    /// <summary>Validates that the value of the <see cref = "TF_PROFILE_NEWPHONETIC"/> property is correct.</summary>

    [Test]
    public static void TF_PROFILE_NEWPHONETICTest()
    {
        Assert.That(
            TF_PROFILE_NEWPHONETIC,
            Is.EqualTo(
                new Guid(0xB2F9C502, 0x1742, 0x11D4, 0x97, 0x90, 0x00, 0x80, 0xC8, 0x82, 0x68, 0x7E)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "TF_PROFILE_PHONETIC"/> property is correct.</summary>

    [Test]
    public static void TF_PROFILE_PHONETICTest()
    {
        Assert.That(
            TF_PROFILE_PHONETIC,
            Is.EqualTo(
                new Guid(0x761309DE, 0x317A, 0x11D4, 0x9B, 0x5D, 0x00, 0x80, 0xC8, 0x82, 0x68, 0x7E)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "TF_PROFILE_NEWCHANGJIE"/> property is correct.</summary>

    [Test]
    public static void TF_PROFILE_NEWCHANGJIETest()
    {
        Assert.That(
            TF_PROFILE_NEWCHANGJIE,
            Is.EqualTo(
                new Guid(0xF3BA907A, 0x6C7E, 0x11D4, 0x97, 0xFA, 0x00, 0x80, 0xC8, 0x82, 0x68, 0x7E)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "TF_PROFILE_CHANGJIE"/> property is correct.</summary>

    [Test]
    public static void TF_PROFILE_CHANGJIETest()
    {
        Assert.That(
            TF_PROFILE_CHANGJIE,
            Is.EqualTo(
                new Guid(0x4BDF9F03, 0xC7D3, 0x11D4, 0xB2, 0xAB, 0x00, 0x80, 0xC8, 0x82, 0x68, 0x7E)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "TF_PROFILE_NEWQUICK"/> property is correct.</summary>

    [Test]
    public static void TF_PROFILE_NEWQUICKTest()
    {
        Assert.That(
            TF_PROFILE_NEWQUICK,
            Is.EqualTo(
                new Guid(0x0B883BA0, 0xC1C7, 0x11D4, 0x87, 0xF9, 0x00, 0x80, 0xC8, 0x82, 0x68, 0x7E)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "TF_PROFILE_QUICK"/> property is correct.</summary>

    [Test]
    public static void TF_PROFILE_QUICKTest()
    {
        Assert.That(
            TF_PROFILE_QUICK,
            Is.EqualTo(
                new Guid(0x6024B45F, 0x5C54, 0x11D4, 0xB9, 0x21, 0x00, 0x80, 0xC8, 0x82, 0x68, 0x7E)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "TF_PROFILE_CANTONESE"/> property is correct.</summary>

    [Test]
    public static void TF_PROFILE_CANTONESETest()
    {
        Assert.That(
            TF_PROFILE_CANTONESE,
            Is.EqualTo(
                new Guid(0x0AEC109C, 0x7E96, 0x11D4, 0xB2, 0xEF, 0x00, 0x80, 0xC8, 0x82, 0x68, 0x7E)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "TF_PROFILE_PINYIN"/> property is correct.</summary>

    [Test]
    public static void TF_PROFILE_PINYINTest()
    {
        Assert.That(
            TF_PROFILE_PINYIN,
            Is.EqualTo(
                new Guid(0xF3BA9077, 0x6C7E, 0x11D4, 0x97, 0xFA, 0x00, 0x80, 0xC8, 0x82, 0x68, 0x7E)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "TF_PROFILE_SIMPLEFAST"/> property is correct.</summary>

    [Test]
    public static void TF_PROFILE_SIMPLEFASTTest()
    {
        Assert.That(
            TF_PROFILE_SIMPLEFAST,
            Is.EqualTo(
                new Guid(0xFA550B04, 0x5AD7, 0x411F, 0xA5, 0xAC, 0xCA, 0x03, 0x8E, 0xC5, 0x15, 0xD7)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "TF_PROFILE_WUBI"/> property is correct.</summary>

    [Test]
    public static void TF_PROFILE_WUBITest()
    {
        Assert.That(
            TF_PROFILE_WUBI,
            Is.EqualTo(
                new Guid(0x82590C13, 0xF4DD, 0x44F4, 0xBA, 0x1D, 0x86, 0x67, 0x24, 0x6F, 0xDF, 0x8E)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "TF_PROFILE_DAYI"/> property is correct.</summary>

    [Test]
    public static void TF_PROFILE_DAYITest()
    {
        Assert.That(
            TF_PROFILE_DAYI,
            Is.EqualTo(
                new Guid(0x037B2C25, 0x480C, 0x4D7F, 0xB0, 0x27, 0xD6, 0xCA, 0x6B, 0x69, 0x78, 0x8A)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "TF_PROFILE_ARRAY"/> property is correct.</summary>

    [Test]
    public static void TF_PROFILE_ARRAYTest()
    {
        Assert.That(
            TF_PROFILE_ARRAY,
            Is.EqualTo(
                new Guid(0xD38EFF65, 0xAA46, 0x4FD5, 0x91, 0xA7, 0x67, 0x84, 0x5F, 0xB0, 0x2F, 0x5B)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "TF_PROFILE_YI"/> property is correct.</summary>

    [Test]
    public static void TF_PROFILE_YITest()
    {
        Assert.That(
            TF_PROFILE_YI,
            Is.EqualTo(
                new Guid(0x409C8376, 0x007B, 0x4357, 0xAE, 0x8E, 0x26, 0x31, 0x6E, 0xE3, 0xFB, 0x0D)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "TF_PROFILE_TIGRINYA"/> property is correct.</summary>

    [Test]
    public static void TF_PROFILE_TIGRINYATest()
    {
        Assert.That(
            TF_PROFILE_TIGRINYA,
            Is.EqualTo(
                new Guid(0x3CAB88B7, 0xCC3E, 0x46A6, 0x97, 0x65, 0xB7, 0x72, 0xAD, 0x77, 0x61, 0xFF)
            )
        );
    }
}
