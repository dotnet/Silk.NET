// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/gdiplustypes.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Gdiplus.UnitTests;

/// <summary>Provides validation of the <see cref = "GpSizeF"/> struct.</summary>
public static unsafe partial class GpSizeFTests
{
    /// <summary>Validates that the <see cref = "GpSizeF"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<GpSizeF>(), Is.EqualTo(sizeof(GpSizeF)));
    }

    /// <summary>Validates that the <see cref = "GpSizeF"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(GpSizeF).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "GpSizeF"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(GpSizeF), Is.EqualTo(8));
    }
}
