// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dcommon.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "D2D_VECTOR_3F"/> struct.</summary>
public static unsafe partial class D2D_VECTOR_3FTests
{
    /// <summary>Validates that the <see cref = "D2D_VECTOR_3F"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<D2D_VECTOR_3F>(), Is.EqualTo(sizeof(D2D_VECTOR_3F)));
    }

    /// <summary>Validates that the <see cref = "D2D_VECTOR_3F"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(D2D_VECTOR_3F).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "D2D_VECTOR_3F"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(D2D_VECTOR_3F), Is.EqualTo(12));
    }
}
