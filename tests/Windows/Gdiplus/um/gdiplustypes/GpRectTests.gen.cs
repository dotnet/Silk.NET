// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/gdiplustypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.Gdiplus.UnitTests;
/// <summary>Provides validation of the <see cref = "GpRect"/> struct.</summary>
public static unsafe partial class GpRectTests
{
    /// <summary>Validates that the <see cref = "GpRect"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<GpRect>(), Is.EqualTo(sizeof(GpRect)));
    }

    /// <summary>Validates that the <see cref = "GpRect"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(GpRect).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "GpRect"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(GpRect), Is.EqualTo(16));
    }
}