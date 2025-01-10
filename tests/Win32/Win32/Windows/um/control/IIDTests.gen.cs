// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/control.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "IID"/> class.</summary>
public static partial class IIDTests
{
    /// <summary>Validates that the value of the <see cref = "IID_IAMCollection"/> property is correct.</summary>

    [Test]
    public static void IID_IAMCollectionTest()
    {
        Assert.That(
            IID_IAMCollection,
            Is.EqualTo(
                new Guid(0x56a868b9, 0x0ad4, 0x11ce, 0xb0, 0x3a, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_IMediaControl"/> property is correct.</summary>

    [Test]
    public static void IID_IMediaControlTest()
    {
        Assert.That(
            IID_IMediaControl,
            Is.EqualTo(
                new Guid(0x56a868b1, 0x0ad4, 0x11ce, 0xb0, 0x3a, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_IMediaEvent"/> property is correct.</summary>

    [Test]
    public static void IID_IMediaEventTest()
    {
        Assert.That(
            IID_IMediaEvent,
            Is.EqualTo(
                new Guid(0x56a868b6, 0x0ad4, 0x11ce, 0xb0, 0x3a, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_IMediaEventEx"/> property is correct.</summary>

    [Test]
    public static void IID_IMediaEventExTest()
    {
        Assert.That(
            IID_IMediaEventEx,
            Is.EqualTo(
                new Guid(0x56a868c0, 0x0ad4, 0x11ce, 0xb0, 0x3a, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_IMediaPosition"/> property is correct.</summary>

    [Test]
    public static void IID_IMediaPositionTest()
    {
        Assert.That(
            IID_IMediaPosition,
            Is.EqualTo(
                new Guid(0x56a868b2, 0x0ad4, 0x11ce, 0xb0, 0x3a, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_IBasicAudio"/> property is correct.</summary>

    [Test]
    public static void IID_IBasicAudioTest()
    {
        Assert.That(
            IID_IBasicAudio,
            Is.EqualTo(
                new Guid(0x56a868b3, 0x0ad4, 0x11ce, 0xb0, 0x3a, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_IVideoWindow"/> property is correct.</summary>

    [Test]
    public static void IID_IVideoWindowTest()
    {
        Assert.That(
            IID_IVideoWindow,
            Is.EqualTo(
                new Guid(0x56a868b4, 0x0ad4, 0x11ce, 0xb0, 0x3a, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_IBasicVideo"/> property is correct.</summary>

    [Test]
    public static void IID_IBasicVideoTest()
    {
        Assert.That(
            IID_IBasicVideo,
            Is.EqualTo(
                new Guid(0x56a868b5, 0x0ad4, 0x11ce, 0xb0, 0x3a, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_IBasicVideo2"/> property is correct.</summary>

    [Test]
    public static void IID_IBasicVideo2Test()
    {
        Assert.That(
            IID_IBasicVideo2,
            Is.EqualTo(
                new Guid(0x329bb360, 0xf6ea, 0x11d1, 0x90, 0x38, 0x00, 0xa0, 0xc9, 0x69, 0x72, 0x98)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_IDeferredCommand"/> property is correct.</summary>

    [Test]
    public static void IID_IDeferredCommandTest()
    {
        Assert.That(
            IID_IDeferredCommand,
            Is.EqualTo(
                new Guid(0x56a868b8, 0x0ad4, 0x11ce, 0xb0, 0x3a, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_IQueueCommand"/> property is correct.</summary>

    [Test]
    public static void IID_IQueueCommandTest()
    {
        Assert.That(
            IID_IQueueCommand,
            Is.EqualTo(
                new Guid(0x56a868b7, 0x0ad4, 0x11ce, 0xb0, 0x3a, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_IFilterInfo"/> property is correct.</summary>

    [Test]
    public static void IID_IFilterInfoTest()
    {
        Assert.That(
            IID_IFilterInfo,
            Is.EqualTo(
                new Guid(0x56a868ba, 0x0ad4, 0x11ce, 0xb0, 0x3a, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_IRegFilterInfo"/> property is correct.</summary>

    [Test]
    public static void IID_IRegFilterInfoTest()
    {
        Assert.That(
            IID_IRegFilterInfo,
            Is.EqualTo(
                new Guid(0x56a868bb, 0x0ad4, 0x11ce, 0xb0, 0x3a, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_IMediaTypeInfo"/> property is correct.</summary>

    [Test]
    public static void IID_IMediaTypeInfoTest()
    {
        Assert.That(
            IID_IMediaTypeInfo,
            Is.EqualTo(
                new Guid(0x56a868bc, 0x0ad4, 0x11ce, 0xb0, 0x3a, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_IPinInfo"/> property is correct.</summary>

    [Test]
    public static void IID_IPinInfoTest()
    {
        Assert.That(
            IID_IPinInfo,
            Is.EqualTo(
                new Guid(0x56a868bd, 0x0ad4, 0x11ce, 0xb0, 0x3a, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70)
            )
        );
    }

    /// <summary>Validates that the value of the <see cref = "IID_IAMStats"/> property is correct.</summary>

    [Test]
    public static void IID_IAMStatsTest()
    {
        Assert.That(
            IID_IAMStats,
            Is.EqualTo(
                new Guid(0xbc9bcf80, 0xdcd2, 0x11d2, 0xab, 0xf6, 0x00, 0xa0, 0xc9, 0x05, 0xf3, 0x75)
            )
        );
    }
}
