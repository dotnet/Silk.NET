// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/uuids.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using NUnit.Framework;
using static Silk.NET.Windows.TIME;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "TIME"/> class.</summary>
public static partial class TIMETests
{
    /// <summary>Validates that the value of the <see cref = "TIME_FORMAT_NONE"/> property is correct.</summary>

    [Test]
    public static void TIME_FORMAT_NONETest()
    {
        Assert.That(TIME_FORMAT_NONE, Is.EqualTo(new Guid(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0)));
    }

    /// <summary>Validates that the value of the <see cref = "TIME_FORMAT_FRAME"/> property is correct.</summary>

    [Test]
    public static void TIME_FORMAT_FRAMETest()
    {
        Assert.That(
            TIME_FORMAT_FRAME,
            Is.EqualTo(
                new Guid(0x7b785570, 0x8c82, 0x11cf, 0xbc, 0xc, 0x0, 0xaa, 0x0, 0xac, 0x74, 0xf6)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "TIME_FORMAT_BYTE"/> property is correct.</summary>

    [Test]
    public static void TIME_FORMAT_BYTETest()
    {
        Assert.That(
            TIME_FORMAT_BYTE,
            Is.EqualTo(
                new Guid(0x7b785571, 0x8c82, 0x11cf, 0xbc, 0xc, 0x0, 0xaa, 0x0, 0xac, 0x74, 0xf6)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "TIME_FORMAT_SAMPLE"/> property is correct.</summary>

    [Test]
    public static void TIME_FORMAT_SAMPLETest()
    {
        Assert.That(
            TIME_FORMAT_SAMPLE,
            Is.EqualTo(
                new Guid(0x7b785572, 0x8c82, 0x11cf, 0xbc, 0xc, 0x0, 0xaa, 0x0, 0xac, 0x74, 0xf6)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "TIME_FORMAT_FIELD"/> property is correct.</summary>

    [Test]
    public static void TIME_FORMAT_FIELDTest()
    {
        Assert.That(
            TIME_FORMAT_FIELD,
            Is.EqualTo(
                new Guid(0x7b785573, 0x8c82, 0x11cf, 0xbc, 0xc, 0x0, 0xaa, 0x0, 0xac, 0x74, 0xf6)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "TIME_FORMAT_MEDIA_TIME"/> property is correct.</summary>

    [Test]
    public static void TIME_FORMAT_MEDIA_TIMETest()
    {
        Assert.That(
            TIME_FORMAT_MEDIA_TIME,
            Is.EqualTo(
                new Guid(0x7b785574, 0x8c82, 0x11cf, 0xbc, 0xc, 0x0, 0xaa, 0x0, 0xac, 0x74, 0xf6)
            )
        );
    }
}
