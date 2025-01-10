// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.graphics.imaging.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref = "BitmapSize"/> struct.</summary>
public static unsafe partial class BitmapSizeTests
{
    /// <summary>Validates that the <see cref = "BitmapSize"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<BitmapSize>(), Is.EqualTo(sizeof(BitmapSize)));
    }

    /// <summary>Validates that the <see cref = "BitmapSize"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(BitmapSize).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "BitmapSize"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(BitmapSize), Is.EqualTo(8));
    }
}
