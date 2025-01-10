// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.playback.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref = "IMediaPlaybackCommandManagerFastForwardReceivedEventArgs"/> struct.</summary>
public static unsafe partial class IMediaPlaybackCommandManagerFastForwardReceivedEventArgsTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IMediaPlaybackCommandManagerFastForwardReceivedEventArgs"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(
            typeof(IMediaPlaybackCommandManagerFastForwardReceivedEventArgs).GUID,
            Is.EqualTo(IID_IMediaPlaybackCommandManagerFastForwardReceivedEventArgs)
        );
    }

    /// <summary>Validates that the <see cref = "IMediaPlaybackCommandManagerFastForwardReceivedEventArgs"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<IMediaPlaybackCommandManagerFastForwardReceivedEventArgs>(),
            Is.EqualTo(sizeof(IMediaPlaybackCommandManagerFastForwardReceivedEventArgs))
        );
    }

    /// <summary>Validates that the <see cref = "IMediaPlaybackCommandManagerFastForwardReceivedEventArgs"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(
            typeof(IMediaPlaybackCommandManagerFastForwardReceivedEventArgs).IsLayoutSequential,
            Is.True
        );
    }

    /// <summary>Validates that the <see cref = "IMediaPlaybackCommandManagerFastForwardReceivedEventArgs"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(
                sizeof(IMediaPlaybackCommandManagerFastForwardReceivedEventArgs),
                Is.EqualTo(8)
            );
        }
        else
        {
            Assert.That(
                sizeof(IMediaPlaybackCommandManagerFastForwardReceivedEventArgs),
                Is.EqualTo(4)
            );
        }
    }
}
