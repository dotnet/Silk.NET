// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref = "MediaTimeRange"/> struct.</summary>
public static unsafe partial class MediaTimeRangeTests
{
    /// <summary>Validates that the <see cref = "MediaTimeRange"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<MediaTimeRange>(), Is.EqualTo(sizeof(MediaTimeRange)));
    }

    /// <summary>Validates that the <see cref = "MediaTimeRange"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(MediaTimeRange).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "MediaTimeRange"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(MediaTimeRange), Is.EqualTo(16));
    }
}
