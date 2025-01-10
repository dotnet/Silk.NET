// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/uuids.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using NUnit.Framework;
using static Silk.NET.Windows.FORMAT;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "FORMAT"/> class.</summary>
public static partial class FORMATTests
{
    /// <summary>Validates that the value of the <see cref = "FORMAT_None"/> property is correct.</summary>

    [Test]
    public static void FORMAT_NoneTest()
    {
        Assert.That(
            FORMAT_None,
            Is.EqualTo(
                new Guid(0x0F6417D6, 0xc318, 0x11d0, 0xa4, 0x3f, 0x00, 0xa0, 0xc9, 0x22, 0x31, 0x96)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "FORMAT_VideoInfo"/> property is correct.</summary>

    [Test]
    public static void FORMAT_VideoInfoTest()
    {
        Assert.That(
            FORMAT_VideoInfo,
            Is.EqualTo(
                new Guid(0x05589f80, 0xc356, 0x11ce, 0xbf, 0x01, 0x00, 0xaa, 0x00, 0x55, 0x59, 0x5a)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "FORMAT_VideoInfo2"/> property is correct.</summary>

    [Test]
    public static void FORMAT_VideoInfo2Test()
    {
        Assert.That(
            FORMAT_VideoInfo2,
            Is.EqualTo(
                new Guid(0xf72a76A0, 0xeb0a, 0x11d0, 0xac, 0xe4, 0x00, 0x00, 0xc0, 0xcc, 0x16, 0xba)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "FORMAT_WaveFormatEx"/> property is correct.</summary>

    [Test]
    public static void FORMAT_WaveFormatExTest()
    {
        Assert.That(
            FORMAT_WaveFormatEx,
            Is.EqualTo(
                new Guid(0x05589f81, 0xc356, 0x11ce, 0xbf, 0x01, 0x00, 0xaa, 0x00, 0x55, 0x59, 0x5a)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "FORMAT_MPEGVideo"/> property is correct.</summary>

    [Test]
    public static void FORMAT_MPEGVideoTest()
    {
        Assert.That(
            FORMAT_MPEGVideo,
            Is.EqualTo(
                new Guid(0x05589f82, 0xc356, 0x11ce, 0xbf, 0x01, 0x00, 0xaa, 0x00, 0x55, 0x59, 0x5a)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "FORMAT_MPEGStreams"/> property is correct.</summary>

    [Test]
    public static void FORMAT_MPEGStreamsTest()
    {
        Assert.That(
            FORMAT_MPEGStreams,
            Is.EqualTo(
                new Guid(0x05589f83, 0xc356, 0x11ce, 0xbf, 0x01, 0x00, 0xaa, 0x00, 0x55, 0x59, 0x5a)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "FORMAT_DvInfo"/> property is correct.</summary>

    [Test]
    public static void FORMAT_DvInfoTest()
    {
        Assert.That(
            FORMAT_DvInfo,
            Is.EqualTo(
                new Guid(0x05589f84, 0xc356, 0x11ce, 0xbf, 0x01, 0x00, 0xaa, 0x00, 0x55, 0x59, 0x5a)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "FORMAT_525WSS"/> property is correct.</summary>

    [Test]
    public static void FORMAT_525WSSTest()
    {
        Assert.That(
            FORMAT_525WSS,
            Is.EqualTo(
                new Guid(0xc7ecf04d, 0x4582, 0x4869, 0x9a, 0xbb, 0xbf, 0xb5, 0x23, 0xb6, 0x2e, 0xdf)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "FORMAT_AnalogVideo"/> property is correct.</summary>

    [Test]
    public static void FORMAT_AnalogVideoTest()
    {
        Assert.That(
            FORMAT_AnalogVideo,
            Is.EqualTo(
                new Guid(0x482dde0, 0x7817, 0x11cf, 0x8a, 0x3, 0x0, 0xaa, 0x0, 0x6e, 0xcb, 0x65)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "FORMAT_CAPTIONED_H264VIDEO"/> property is correct.</summary>

    [Test]
    public static void FORMAT_CAPTIONED_H264VIDEOTest()
    {
        Assert.That(
            FORMAT_CAPTIONED_H264VIDEO,
            Is.EqualTo(
                new Guid(0xa4efc024, 0x873e, 0x4da3, 0x89, 0x8b, 0x47, 0x4d, 0xdb, 0xd7, 0x9f, 0xd0)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "FORMAT_CC_CONTAINER"/> property is correct.</summary>

    [Test]
    public static void FORMAT_CC_CONTAINERTest()
    {
        Assert.That(
            FORMAT_CC_CONTAINER,
            Is.EqualTo(
                new Guid(0x50997a4a, 0xe508, 0x4054, 0xa2, 0xb2, 0x10, 0xff, 0xa, 0xc1, 0xa6, 0x9a)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "FORMAT_CAPTIONED_MPEG2VIDEO"/> property is correct.</summary>

    [Test]
    public static void FORMAT_CAPTIONED_MPEG2VIDEOTest()
    {
        Assert.That(
            FORMAT_CAPTIONED_MPEG2VIDEO,
            Is.EqualTo(
                new Guid(0x7ab2ada2, 0x81b6, 0x4f14, 0xb3, 0xc8, 0xd0, 0xc4, 0x86, 0x39, 0x3b, 0x67)
            )
        );
    }
}
