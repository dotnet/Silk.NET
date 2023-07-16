// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.DirectX.UnitTests;
/// <summary>Provides validation of the <see cref = "D2D1_BITMAP_PROPERTIES"/> struct.</summary>
public static unsafe partial class D2D1_BITMAP_PROPERTIESTests
{
    /// <summary>Validates that the <see cref = "D2D1_BITMAP_PROPERTIES"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<D2D1_BITMAP_PROPERTIES>(), Is.EqualTo(sizeof(D2D1_BITMAP_PROPERTIES)));
    }

    /// <summary>Validates that the <see cref = "D2D1_BITMAP_PROPERTIES"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(D2D1_BITMAP_PROPERTIES).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "D2D1_BITMAP_PROPERTIES"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(D2D1_BITMAP_PROPERTIES), Is.EqualTo(16));
    }
}