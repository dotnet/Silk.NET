// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.playback.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref = "IMediaPlayerSource"/> struct.</summary>
public static unsafe partial class IMediaPlayerSourceTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IMediaPlayerSource"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IMediaPlayerSource).GUID, Is.EqualTo(IID_IMediaPlayerSource));
    }

    /// <summary>Validates that the <see cref = "IMediaPlayerSource"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IMediaPlayerSource>(), Is.EqualTo(sizeof(IMediaPlayerSource)));
    }

    /// <summary>Validates that the <see cref = "IMediaPlayerSource"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IMediaPlayerSource).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IMediaPlayerSource"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IMediaPlayerSource), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IMediaPlayerSource), Is.EqualTo(4));
        }
    }
}
