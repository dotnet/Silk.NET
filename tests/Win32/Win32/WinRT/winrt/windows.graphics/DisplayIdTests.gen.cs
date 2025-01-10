// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.graphics.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref = "DisplayId"/> struct.</summary>
public static unsafe partial class DisplayIdTests
{
    /// <summary>Validates that the <see cref = "DisplayId"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DisplayId>(), Is.EqualTo(sizeof(DisplayId)));
    }

    /// <summary>Validates that the <see cref = "DisplayId"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DisplayId).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DisplayId"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DisplayId), Is.EqualTo(8));
    }
}
