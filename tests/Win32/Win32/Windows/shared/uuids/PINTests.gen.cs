// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/uuids.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using NUnit.Framework;
using static Silk.NET.Windows.PIN;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "PIN"/> class.</summary>
public static partial class PINTests
{
    /// <summary>Validates that the value of the <see cref = "PIN_CATEGORY_CAPTURE"/> property is correct.</summary>

    [Test]
    public static void PIN_CATEGORY_CAPTURETest()
    {
        Assert.That(
            PIN_CATEGORY_CAPTURE,
            Is.EqualTo(
                new Guid(0xfb6c4281, 0x0353, 0x11d1, 0x90, 0x5f, 0x00, 0x00, 0xc0, 0xcc, 0x16, 0xba)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "PIN_CATEGORY_PREVIEW"/> property is correct.</summary>

    [Test]
    public static void PIN_CATEGORY_PREVIEWTest()
    {
        Assert.That(
            PIN_CATEGORY_PREVIEW,
            Is.EqualTo(
                new Guid(0xfb6c4282, 0x0353, 0x11d1, 0x90, 0x5f, 0x00, 0x00, 0xc0, 0xcc, 0x16, 0xba)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "PIN_CATEGORY_ANALOGVIDEOIN"/> property is correct.</summary>

    [Test]
    public static void PIN_CATEGORY_ANALOGVIDEOINTest()
    {
        Assert.That(
            PIN_CATEGORY_ANALOGVIDEOIN,
            Is.EqualTo(
                new Guid(0xfb6c4283, 0x0353, 0x11d1, 0x90, 0x5f, 0x00, 0x00, 0xc0, 0xcc, 0x16, 0xba)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "PIN_CATEGORY_VBI"/> property is correct.</summary>

    [Test]
    public static void PIN_CATEGORY_VBITest()
    {
        Assert.That(
            PIN_CATEGORY_VBI,
            Is.EqualTo(
                new Guid(0xfb6c4284, 0x0353, 0x11d1, 0x90, 0x5f, 0x00, 0x00, 0xc0, 0xcc, 0x16, 0xba)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "PIN_CATEGORY_VIDEOPORT"/> property is correct.</summary>

    [Test]
    public static void PIN_CATEGORY_VIDEOPORTTest()
    {
        Assert.That(
            PIN_CATEGORY_VIDEOPORT,
            Is.EqualTo(
                new Guid(0xfb6c4285, 0x0353, 0x11d1, 0x90, 0x5f, 0x00, 0x00, 0xc0, 0xcc, 0x16, 0xba)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "PIN_CATEGORY_NABTS"/> property is correct.</summary>

    [Test]
    public static void PIN_CATEGORY_NABTSTest()
    {
        Assert.That(
            PIN_CATEGORY_NABTS,
            Is.EqualTo(
                new Guid(0xfb6c4286, 0x0353, 0x11d1, 0x90, 0x5f, 0x00, 0x00, 0xc0, 0xcc, 0x16, 0xba)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "PIN_CATEGORY_EDS"/> property is correct.</summary>

    [Test]
    public static void PIN_CATEGORY_EDSTest()
    {
        Assert.That(
            PIN_CATEGORY_EDS,
            Is.EqualTo(
                new Guid(0xfb6c4287, 0x0353, 0x11d1, 0x90, 0x5f, 0x00, 0x00, 0xc0, 0xcc, 0x16, 0xba)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "PIN_CATEGORY_TELETEXT"/> property is correct.</summary>

    [Test]
    public static void PIN_CATEGORY_TELETEXTTest()
    {
        Assert.That(
            PIN_CATEGORY_TELETEXT,
            Is.EqualTo(
                new Guid(0xfb6c4288, 0x0353, 0x11d1, 0x90, 0x5f, 0x00, 0x00, 0xc0, 0xcc, 0x16, 0xba)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "PIN_CATEGORY_CC"/> property is correct.</summary>

    [Test]
    public static void PIN_CATEGORY_CCTest()
    {
        Assert.That(
            PIN_CATEGORY_CC,
            Is.EqualTo(
                new Guid(0xfb6c4289, 0x0353, 0x11d1, 0x90, 0x5f, 0x00, 0x00, 0xc0, 0xcc, 0x16, 0xba)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "PIN_CATEGORY_STILL"/> property is correct.</summary>

    [Test]
    public static void PIN_CATEGORY_STILLTest()
    {
        Assert.That(
            PIN_CATEGORY_STILL,
            Is.EqualTo(
                new Guid(0xfb6c428a, 0x0353, 0x11d1, 0x90, 0x5f, 0x00, 0x00, 0xc0, 0xcc, 0x16, 0xba)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "PIN_CATEGORY_TIMECODE"/> property is correct.</summary>

    [Test]
    public static void PIN_CATEGORY_TIMECODETest()
    {
        Assert.That(
            PIN_CATEGORY_TIMECODE,
            Is.EqualTo(
                new Guid(0xfb6c428b, 0x0353, 0x11d1, 0x90, 0x5f, 0x00, 0x00, 0xc0, 0xcc, 0x16, 0xba)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "PIN_CATEGORY_VIDEOPORT_VBI"/> property is correct.</summary>

    [Test]
    public static void PIN_CATEGORY_VIDEOPORT_VBITest()
    {
        Assert.That(
            PIN_CATEGORY_VIDEOPORT_VBI,
            Is.EqualTo(
                new Guid(0xfb6c428c, 0x0353, 0x11d1, 0x90, 0x5f, 0x00, 0x00, 0xc0, 0xcc, 0x16, 0xba)
            )
        );
    }
}
