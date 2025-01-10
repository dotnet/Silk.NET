// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.streaming.adaptive.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref = "IAdaptiveMediaSourceDownloadCompletedEventArgs2"/> struct.</summary>
public static unsafe partial class IAdaptiveMediaSourceDownloadCompletedEventArgs2Tests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IAdaptiveMediaSourceDownloadCompletedEventArgs2"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(
            typeof(IAdaptiveMediaSourceDownloadCompletedEventArgs2).GUID,
            Is.EqualTo(IID_IAdaptiveMediaSourceDownloadCompletedEventArgs2)
        );
    }

    /// <summary>Validates that the <see cref = "IAdaptiveMediaSourceDownloadCompletedEventArgs2"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<IAdaptiveMediaSourceDownloadCompletedEventArgs2>(),
            Is.EqualTo(sizeof(IAdaptiveMediaSourceDownloadCompletedEventArgs2))
        );
    }

    /// <summary>Validates that the <see cref = "IAdaptiveMediaSourceDownloadCompletedEventArgs2"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(
            typeof(IAdaptiveMediaSourceDownloadCompletedEventArgs2).IsLayoutSequential,
            Is.True
        );
    }

    /// <summary>Validates that the <see cref = "IAdaptiveMediaSourceDownloadCompletedEventArgs2"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IAdaptiveMediaSourceDownloadCompletedEventArgs2), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IAdaptiveMediaSourceDownloadCompletedEventArgs2), Is.EqualTo(4));
        }
    }
}
